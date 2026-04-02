#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Recraft.JsonConverters
{
    /// <inheritdoc />
    public class CreateStyleResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Recraft.CreateStyleResponse>
    {
        /// <inheritdoc />
        public override global::Recraft.CreateStyleResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("creation_time")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("is_private")) __score0++;
            if (__jsonProps.Contains("style")) __score0++;
            if (__jsonProps.Contains("substyle")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("credits")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Recraft.Style? style = default;
            global::Recraft.CreateStyleResponseVariant2? createStyleResponseVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.Style), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.Style> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.Style).Name}");
                        style = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.CreateStyleResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.CreateStyleResponseVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.CreateStyleResponseVariant2).Name}");
                        createStyleResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (style == null && createStyleResponseVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.Style), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.Style> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.Style).Name}");
                    style = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.CreateStyleResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.CreateStyleResponseVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.CreateStyleResponseVariant2).Name}");
                    createStyleResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Recraft.CreateStyleResponse(
                style,

                createStyleResponseVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Recraft.CreateStyleResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStyle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.Style), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.Style?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.Style).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Style!, typeInfo);
            }
            else if (value.IsCreateStyleResponseVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.CreateStyleResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.CreateStyleResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.CreateStyleResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateStyleResponseVariant2!, typeInfo);
            }
        }
    }
}