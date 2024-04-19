using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace rpgAPI.src.Model
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RPGClass
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3,
        Elf = 4
    }
}
