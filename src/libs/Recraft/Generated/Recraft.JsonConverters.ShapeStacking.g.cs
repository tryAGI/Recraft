#nullable enable

namespace Recraft.JsonConverters
{
    /// <inheritdoc />
    public sealed class ShapeStackingJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Recraft.ShapeStacking>
    {
        /// <inheritdoc />
        public override global::Recraft.ShapeStacking Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Recraft.ShapeStackingExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Recraft.ShapeStacking)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Recraft.ShapeStacking);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Recraft.ShapeStacking value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Recraft.ShapeStackingExtensions.ToValueString(value));
        }
    }
}
