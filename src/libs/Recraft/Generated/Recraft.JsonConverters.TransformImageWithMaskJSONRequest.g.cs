#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Recraft.JsonConverters
{
    /// <inheritdoc />
    public class TransformImageWithMaskJSONRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Recraft.TransformImageWithMaskJSONRequest>
    {
        /// <inheritdoc />
        public override global::Recraft.TransformImageWithMaskJSONRequest Read(
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
            var __score1 = 0;
            if (__jsonProps.Contains("mask_url")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Recraft.TransformImageJSONRequest? transformImageJSONRequest = default;
            global::Recraft.TransformImageWithMaskJSONRequestVariant2? transformImageWithMaskJSONRequestVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.TransformImageJSONRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.TransformImageJSONRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.TransformImageJSONRequest).Name}");
                        transformImageJSONRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.TransformImageWithMaskJSONRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.TransformImageWithMaskJSONRequestVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.TransformImageWithMaskJSONRequestVariant2).Name}");
                        transformImageWithMaskJSONRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (transformImageJSONRequest == null && transformImageWithMaskJSONRequestVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.TransformImageJSONRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.TransformImageJSONRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.TransformImageJSONRequest).Name}");
                    transformImageJSONRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (transformImageJSONRequest == null && transformImageWithMaskJSONRequestVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.TransformImageWithMaskJSONRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.TransformImageWithMaskJSONRequestVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.TransformImageWithMaskJSONRequestVariant2).Name}");
                    transformImageWithMaskJSONRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Recraft.TransformImageWithMaskJSONRequest(
                transformImageJSONRequest,

                transformImageWithMaskJSONRequestVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Recraft.TransformImageWithMaskJSONRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTransformImageJSONRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.TransformImageJSONRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.TransformImageJSONRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.TransformImageJSONRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransformImageJSONRequest!.Value, typeInfo);
            }
            else if (value.IsTransformImageWithMaskJSONRequestVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.TransformImageWithMaskJSONRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.TransformImageWithMaskJSONRequestVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.TransformImageWithMaskJSONRequestVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransformImageWithMaskJSONRequestVariant2!, typeInfo);
            }
        }
    }
}