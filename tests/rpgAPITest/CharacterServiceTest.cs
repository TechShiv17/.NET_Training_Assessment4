using rpgAPI.src.Model;
using rpgAPI.src.Service;

namespace rpgAPITest
{
    public class CharacterServiceTest
    {
        [Fact]

        public void GetAllCharacterGivenValidRequestGetResult()
        {
            var cs = new CharacterService();
            var result = cs.GetAllCharacter();
            Assert.NotNull(result);
        }

        [Fact]
        public void AddCharacterGivenValidRequestGetResult()
        {
            var character = new Character()
            {
                Name = "Unit Test",
                Id = 4,
            };
            var cs = new CharacterService();
            var result = cs.AddCharacter(character);
            Assert.NotNull(result);
            Assert.NotNull(result.Data.FirstOrDefault(x=>x.Id ==4));
        }

        [Fact]

        public void UpdateCharacterGivenValidRequestGetResult()
        {
            var character = new Character()
            {
                Name = "Update Character",
                Id = 5
            };
            var cs = new CharacterService();
            var result = cs.UpdateCharacter(character);
            Assert.NotNull(result);
            Assert.NotNull(result.Data.FirstOrDefault(x => x.Id == 5));
        }

        [Fact]

        public void UpdateCharacterGivenValidRequestNewCharacterAdded()
        {
            var character = new Character()
            {
                Name = "Update Character",
                Id = 5
            };
            var cs = new CharacterService();
            var result = cs.UpdateCharacter(character);
            Assert.NotNull(result);
            Assert.NotNull(result.Data.FirstOrDefault(x => x.Id == 5));
        }

        [Fact]

        public void UpdateCharacterGivenValidRequestOldCharacterUpdated()
        {
            var character = new Character()
            {
                Name = "Update Character",
                Id = 0
            };
            var cs = new CharacterService();
            var result = cs.UpdateCharacter(character);
            Assert.NotNull(result);
            Assert.NotNull(result.Data.FirstOrDefault(x => x.Name == "Update Character"));
        }

        [Fact]

        public void GetCharacterByIdGivenValidRequestGetResult()
        {
            var cs = new CharacterService();
            var result = cs.GetCharacterById(0);
            Assert.NotNull(result);
        }

    }
}