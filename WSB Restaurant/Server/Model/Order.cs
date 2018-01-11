namespace Server.Model
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Order" />
    /// </summary>
    public partial class Order
    {
        /// <summary>
        /// Gets or sets the ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the ClientType
        /// </summary>
        [JsonProperty("ClientType")]
        public string ClientType { get; set; }

        /// <summary>
        /// Gets or sets the ListOfProducts
        /// </summary>
        [JsonProperty("ListOfProducts")]
        public List<Product> ListOfProducts { get; set; }
    }

    /// <summary>
    /// Defines the <see cref="Order" />
    /// </summary>
    public partial class Order
    {
        /// <summary>
        /// The FromJson
        /// </summary>
        /// <param name="json">The <see cref="string"/></param>
        /// <returns>The <see cref="Order"/></returns>
        public static Order FromJson(string json) => JsonConvert.DeserializeObject<Order>(json, Converter.Settings);
    }

    /// <summary>
    /// Defines the <see cref="Serialize" />
    /// </summary>
    public static class Serialize
    {
        /// <summary>
        /// The ToJson
        /// </summary>
        /// <param name="self">The <see cref="Order"/></param>
        /// <returns>The <see cref="string"/></returns>
        public static string ToJson(this Order self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    /// <summary>
    /// Defines the <see cref="Converter" />
    /// </summary>
    public class Converter
    {
        /// <summary>
        /// Defines the Settings
        /// </summary>
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}
