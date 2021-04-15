using System.Text.Json.Serialization;

namespace Dotnet_RPG.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RPGClass
    {
        Knight,
        Mage,
        Cleric,
    }
}
