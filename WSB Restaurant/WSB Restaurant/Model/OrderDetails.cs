namespace WSB_Restaurant.Model
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines the <see cref="OrderDetails" />
    /// </summary>
    public partial class OrderDetails
    {
        /// <summary>
        /// Gets or sets the Number
        /// </summary>
        [JsonProperty("ID")]
        public long Number { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Response
        /// </summary>
        [JsonProperty("Response")]
        public bool Response { get; set; }
    }

    /// <summary>
    /// Defines the <see cref="OrderDetails" />
    /// </summary>
    public partial class OrderDetails
    {
        /// <summary>
        /// The FromJson
        /// </summary>
        /// <param name="json">The <see cref="string"/></param>
        /// <returns>The <see cref="OrderDetails"/></returns>
        public static OrderDetails FromJson(string json) => JsonConvert.DeserializeObject<OrderDetails>(json, Converter.Settings);
    }

    /// <summary>
    /// Defines the <see cref="Serialize" />
    /// </summary>
    public static class Serialize
    {
        /// <summary>
        /// The ToJson
        /// </summary>
        /// <param name="self">The <see cref="OrderDetails"/></param>
        /// <returns>The <see cref="string"/></returns>
        public static string ToJson(this OrderDetails self) => JsonConvert.SerializeObject(self, Converter.Settings);
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
