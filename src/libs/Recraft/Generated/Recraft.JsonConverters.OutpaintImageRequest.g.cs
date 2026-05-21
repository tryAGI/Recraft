#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Recraft.JsonConverters
{
    /// <inheritdoc />
    public class OutpaintImageRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Recraft.OutpaintImageRequest>
    {
        /// <inheritdoc />
        public override global::Recraft.OutpaintImageRequest Read(
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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("block_nsfw")) __score0++;
            if (__jsonProps.Contains("calculate_features")) __score0++;
            if (__jsonProps.Contains("controls")) __score0++;
            if (__jsonProps.Contains("controls.artistic_level")) __score0++;
            if (__jsonProps.Contains("controls.background_color")) __score0++;
            if (__jsonProps.Contains("controls.colors")) __score0++;
            if (__jsonProps.Contains("controls.no_text")) __score0++;
            if (__jsonProps.Contains("creativity")) __score0++;
            if (__jsonProps.Contains("expire")) __score0++;
            if (__jsonProps.Contains("image")) __score0++;
            if (__jsonProps.Contains("image_format")) __score0++;
            if (__jsonProps.Contains("model")) __score0++;
            if (__jsonProps.Contains("n")) __score0++;
            if (__jsonProps.Contains("negative_prompt")) __score0++;
            if (__jsonProps.Contains("prompt")) __score0++;
            if (__jsonProps.Contains("random_seed")) __score0++;
            if (__jsonProps.Contains("response_format")) __score0++;
            if (__jsonProps.Contains("style")) __score0++;
            if (__jsonProps.Contains("style_id")) __score0++;
            if (__jsonProps.Contains("substyle")) __score0++;
            if (__jsonProps.Contains("text_layout")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("expand_bottom")) __score1++;
            if (__jsonProps.Contains("expand_left")) __score1++;
            if (__jsonProps.Contains("expand_right")) __score1++;
            if (__jsonProps.Contains("expand_top")) __score1++;
            if (__jsonProps.Contains("size")) __score1++;
            if (__jsonProps.Contains("zoom_out_percentage")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Recraft.TransformImageRequest? transform = default;
            global::Recraft.OutpaintImageRequestVariant2? outpaintImageRequestVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.TransformImageRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.TransformImageRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.TransformImageRequest).Name}");
                        transform = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.OutpaintImageRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.OutpaintImageRequestVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.OutpaintImageRequestVariant2).Name}");
                        outpaintImageRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (transform == null && outpaintImageRequestVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.TransformImageRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.TransformImageRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.TransformImageRequest).Name}");
                    transform = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (transform == null && outpaintImageRequestVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.OutpaintImageRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.OutpaintImageRequestVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.OutpaintImageRequestVariant2).Name}");
                    outpaintImageRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Recraft.OutpaintImageRequest(
                transform,

                outpaintImageRequestVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Recraft.OutpaintImageRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTransform)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.TransformImageRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.TransformImageRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.TransformImageRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Transform!, typeInfo);
            }
            else if (value.IsOutpaintImageRequestVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.OutpaintImageRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.OutpaintImageRequestVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.OutpaintImageRequestVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutpaintImageRequestVariant2!, typeInfo);
            }
        }
    }
}