namespace Server.Model
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines the <see cref="Product" />
    /// </summary>
    public partial class Product
    {
        /// <summary>
        /// Gets or sets the Image
        /// </summary>
        [JsonProperty("Image")]
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        [JsonProperty("Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Description
        /// </summary>
        [JsonProperty("Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Count
        /// </summary>
        [JsonProperty("Count")]
        public long Count { get; set; }

        /// <summary>
        /// Gets or sets the Price
        /// </summary>
        [JsonProperty("Price")]
        public double Price { get; set; }

        /// <summary>
        /// Gets or sets the TotalPrice
        /// </summary>
        [JsonProperty("TotalPrice")]
        public double TotalPrice { get; set; }
    }
}
