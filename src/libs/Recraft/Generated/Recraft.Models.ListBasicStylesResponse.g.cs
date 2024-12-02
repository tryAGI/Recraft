
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListBasicStylesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("styles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Recraft.BasicStyle> Styles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBasicStylesResponse" /> class.
        /// </summary>
        /// <param name="styles"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListBasicStylesResponse(
            global::System.Collections.Generic.IList<global::Recraft.BasicStyle> styles)
        {
            this.Styles = styles ?? throw new global::System.ArgumentNullException(nameof(styles));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBasicStylesResponse" /> class.
        /// </summary>
        public ListBasicStylesResponse()
        {
        }
    }
}