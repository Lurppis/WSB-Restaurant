using Newtonsoft.Json;
using System.Collections.Generic;

namespace Server.Model
{
    public partial class Order
    {
        public int ID { get; set; }
        [JsonProperty("ClientType")]
        public string ClientType { get; set; }

        [JsonProperty("ListOfProducts")]
        public List<Product> ListOfProducts { get; set; }
    }

    public partial class Order
    {
        public static Order FromJson(string json) => JsonConvert.DeserializeObject<Order>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Order self) => JsonConvert.SerializeObject(self, Converter.Settings);
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
