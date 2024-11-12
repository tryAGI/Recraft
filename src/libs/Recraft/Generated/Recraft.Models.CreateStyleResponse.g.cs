
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStyleResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStyleResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateStyleResponse(
            global::System.Guid id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStyleResponse" /> class.
        /// </summary>
        public CreateStyleResponse()
        {
        }
    }
}