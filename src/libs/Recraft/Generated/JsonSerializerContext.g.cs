
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::Recraft.JsonConverters.TransformModelJsonConverter),
            typeof(global::Recraft.JsonConverters.TransformModelNullableJsonConverter),
            typeof(global::Recraft.JsonConverters.ImageStyleJsonConverter),
            typeof(global::Recraft.JsonConverters.ImageStyleNullableJsonConverter),
            typeof(global::Recraft.JsonConverters.ImageSubStyleJsonConverter),
            typeof(global::Recraft.JsonConverters.ImageSubStyleNullableJsonConverter),
            typeof(global::Recraft.JsonConverters.ResponseFormatJsonConverter),
            typeof(global::Recraft.JsonConverters.ResponseFormatNullableJsonConverter),
            typeof(global::Recraft.JsonConverters.ImageSizeJsonConverter),
            typeof(global::Recraft.JsonConverters.ImageSizeNullableJsonConverter),
            typeof(global::Recraft.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}