
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnhancePromptResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Credits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhanced_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnhancedPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnhancePromptResponse" /> class.
        /// </summary>
        /// <param name="credits"></param>
        /// <param name="enhancedPrompt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnhancePromptResponse(
            int credits,
            string enhancedPrompt)
        {
            this.Credits = credits;
            this.EnhancedPrompt = enhancedPrompt ?? throw new global::System.ArgumentNullException(nameof(enhancedPrompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnhancePromptResponse" /> class.
        /// </summary>
        public EnhancePromptResponse()
        {
        }

    }
}