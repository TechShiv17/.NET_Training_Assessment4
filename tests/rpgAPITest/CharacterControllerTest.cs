using AutoFixture;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using rpgAPI.src.Controller;
using rpgAPI.src.Model;
using rpgAPI.src.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgAPITest
{
    public class CharacterControllerTest
    {
        #region Property

        public Mock<ICharacterService> mock = new Mock<ICharacterService>();

        #endregion

        [Fact]
        public void Test1()
        {
            var cList = new List<Character>()
            {
                new Character(),
                new Character() { Name = "Gollum", Id = 1 },
            };
            var serviceResponse = new ServiceResponse<List<Character>>()
            {
                Data = cList
            };
            var mockService = new Mock<ICharacterService>();
            mockService.Setup(x=>x.GetAllCharacter()).Returns(serviceResponse);
            var charController = new CharacterController(mockService.Object);

            var result = charController.GetCharacter();

            var okResult = (ObjectResult)result.Result;

            Assert.NotNull(result);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Fact]
        public void Test2()
        {
            var fixture = new Fixture();

            var serviceResponse = fixture.Create<ServiceResponse<Character>>();

            var mockService = new Mock<ICharacterService>();

            mockService.Setup(x=>x.GetCharacterById(0)).Returns(serviceResponse);

            var charController = new CharacterController(mockService.Object);

            var result = charController.GetId(0);

            Assert.NotNull(result);
        }
    }
}