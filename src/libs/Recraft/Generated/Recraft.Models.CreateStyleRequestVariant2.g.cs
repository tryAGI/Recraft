
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStyleRequestVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> Images { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStyleRequestVariant2" /> class.
        /// </summary>
        /// <param name="images"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStyleRequestVariant2(
            global::System.Collections.Generic.IList<byte[]> images)
        {
            this.Images = images ?? throw new global::System.ArgumentNullException(nameof(images));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStyleRequestVariant2" /> class.
        /// </summary>
        public CreateStyleRequestVariant2()
        {
        }

    }
}