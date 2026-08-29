#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Recraft.JsonConverters
{
    /// <inheritdoc />
    public class ImageToImageJSONRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Recraft.ImageToImageJSONRequest>
    {
        /// <inheritdoc />
        public override global::Recraft.ImageToImageJSONRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Recraft.TransformImageJSONRequest? transform = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.TransformImageJSONRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.TransformImageJSONRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.TransformImageJSONRequest).Name}");
                transform = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Recraft.ImageToImageJSONRequestVariant2? imageToImageJSONRequestVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.ImageToImageJSONRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.ImageToImageJSONRequestVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.ImageToImageJSONRequestVariant2).Name}");
                imageToImageJSONRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Recraft.ImageToImageJSONRequest(
                transform,

                imageToImageJSONRequestVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Recraft.ImageToImageJSONRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsTransform)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.TransformImageJSONRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.TransformImageJSONRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.TransformImageJSONRequest).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.Transform!.Value, typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsImageToImageJSONRequestVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.ImageToImageJSONRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.ImageToImageJSONRequestVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.ImageToImageJSONRequestVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.ImageToImageJSONRequestVariant2!, typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}