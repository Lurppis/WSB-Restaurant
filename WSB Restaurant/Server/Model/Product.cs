using Newtonsoft.Json;

namespace Server.Model
{
    public partial class Product
    {
        [JsonProperty("Image")]
        public string Image { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Count")]
        public long Count { get; set; }

        [JsonProperty("Price")]
        public double Price { get; set; }

        [JsonProperty("TotalPrice")]
        public double TotalPrice { get; set; }
    }
}