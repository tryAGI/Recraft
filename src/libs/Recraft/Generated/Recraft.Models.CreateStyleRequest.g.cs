
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStyleRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_weights")]
        public global::System.Collections.Generic.IList<double>? ImageWeights { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<byte[]> Images { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mix_policy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recraft.JsonConverters.MixPolicyJsonConverter))]
        public global::Recraft.MixPolicy? MixPolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recraft.JsonConverters.TransformModelJsonConverter))]
        public global::Recraft.TransformModel? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("palette")]
        public global::Recraft.PaletteSuggest? Palette { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_style_weights")]
        public global::System.Collections.Generic.IList<double>? SourceStyleWeights { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_styles")]
        public global::System.Collections.Generic.IList<global::System.Guid>? SourceStyles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recraft.JsonConverters.ImageStyleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Recraft.ImageStyle Style { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStyleRequest" /> class.
        /// </summary>
        /// <param name="imageWeights"></param>
        /// <param name="images"></param>
        /// <param name="mixPolicy"></param>
        /// <param name="model"></param>
        /// <param name="palette"></param>
        /// <param name="private"></param>
        /// <param name="prompt"></param>
        /// <param name="sourceStyleWeights"></param>
        /// <param name="sourceStyles"></param>
        /// <param name="style"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStyleRequest(
            global::System.Collections.Generic.IList<byte[]> images,
            global::Recraft.ImageStyle style,
            global::System.Collections.Generic.IList<double>? imageWeights,
            global::Recraft.MixPolicy? mixPolicy,
            global::Recraft.TransformModel? model,
            global::Recraft.PaletteSuggest? palette,
            bool? @private,
            string? prompt,
            global::System.Collections.Generic.IList<double>? sourceStyleWeights,
            global::System.Collections.Generic.IList<global::System.Guid>? sourceStyles)
        {
            this.Images = images ?? throw new global::System.ArgumentNullException(nameof(images));
            this.Style = style;
            this.ImageWeights = imageWeights;
            this.MixPolicy = mixPolicy;
            this.Model = model;
            this.Palette = palette;
            this.Private = @private;
            this.Prompt = prompt;
            this.SourceStyleWeights = sourceStyleWeights;
            this.SourceStyles = sourceStyles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStyleRequest" /> class.
        /// </summary>
        public CreateStyleRequest()
        {
        }
    }
}