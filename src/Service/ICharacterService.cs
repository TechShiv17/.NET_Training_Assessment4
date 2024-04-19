using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using rpgAPI.src.Model;

namespace rpgAPI.src.Service
{
    public interface ICharacterService
    {
        ServiceResponse<List<Character>> GetAllCharacter();
        ServiceResponse<Character> GetCharacterById(int id);
        ServiceResponse<List<Character>> AddCharacter(Character newCharacter);
        ServiceResponse<List<Character>> UpdateCharacter(Character updateCharacter);
        ServiceResponse<Character> DeleteCharacter(int id);
    }
}