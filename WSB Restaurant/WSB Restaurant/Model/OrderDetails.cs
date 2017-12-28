using Newtonsoft.Json;

namespace WSB_Restaurant.Model
{
    public partial class OrderDetails
    {
        [JsonProperty("ID")]
        public long Number { get; set; }

        [JsonProperty("Response")]
        public bool Response { get; set; }
    }

    public partial class OrderDetails
    {
        public static OrderDetails FromJson(string json) => JsonConvert.DeserializeObject<OrderDetails>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this OrderDetails self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}
