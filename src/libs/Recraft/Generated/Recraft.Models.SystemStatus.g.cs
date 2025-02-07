
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SystemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Generation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Service { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemStatus" /> class.
        /// </summary>
        /// <param name="generation"></param>
        /// <param name="service"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SystemStatus(
            bool generation,
            bool service)
        {
            this.Generation = generation;
            this.Service = service;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemStatus" /> class.
        /// </summary>
        public SystemStatus()
        {
        }
    }
}