
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Model
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> InputModalities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> OutputModalities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Recraft.ModelPricing Pricing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        /// <param name="created"></param>
        /// <param name="id"></param>
        /// <param name="inputModalities"></param>
        /// <param name="name"></param>
        /// <param name="outputModalities"></param>
        /// <param name="pricing"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Model(
            long created,
            string id,
            global::System.Collections.Generic.IList<string> inputModalities,
            string name,
            global::System.Collections.Generic.IList<string> outputModalities,
            global::Recraft.ModelPricing pricing,
            string? description)
        {
            this.Created = created;
            this.Description = description;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.InputModalities = inputModalities ?? throw new global::System.ArgumentNullException(nameof(inputModalities));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OutputModalities = outputModalities ?? throw new global::System.ArgumentNullException(nameof(outputModalities));
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        public Model()
        {
        }

    }
}