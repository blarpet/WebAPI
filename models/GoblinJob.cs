using System.Text.Json.Serialization;

namespace WEBAPI.models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum GoblinJob
    {
        Banker, 
        Coin_Polisher,
        Begger
    }
}