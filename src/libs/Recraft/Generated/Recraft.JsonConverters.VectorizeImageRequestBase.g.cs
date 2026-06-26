#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Recraft.JsonConverters
{
    /// <inheritdoc />
    public class VectorizeImageRequestBaseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Recraft.VectorizeImageRequestBase>
    {
        /// <inheritdoc />
        public override global::Recraft.VectorizeImageRequestBase Read(
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
            if (__jsonProps.Contains("expire")) __score0++;
            if (__jsonProps.Contains("image_format")) __score0++;
            if (__jsonProps.Contains("response_format")) __score0++;
            if (__jsonProps.Contains("upscale")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("color_reduction")) __score1++;
            if (__jsonProps.Contains("limit_num_shapes")) __score1++;
            if (__jsonProps.Contains("max_num_shapes")) __score1++;
            if (__jsonProps.Contains("return_gradients")) __score1++;
            if (__jsonProps.Contains("shape_stacking")) __score1++;
            if (__jsonProps.Contains("small_shape_filter")) __score1++;
            if (__jsonProps.Contains("strict_color_palette")) __score1++;
            if (__jsonProps.Contains("svg_compression")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Recraft.ProcessImageRequestBase? process = default;
            global::Recraft.VectorizeImageRequestBaseVariant2? vectorizeImageRequestBaseVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.ProcessImageRequestBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.ProcessImageRequestBase> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.ProcessImageRequestBase).Name}");
                        process = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.VectorizeImageRequestBaseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.VectorizeImageRequestBaseVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.VectorizeImageRequestBaseVariant2).Name}");
                        vectorizeImageRequestBaseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (process == null && vectorizeImageRequestBaseVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.ProcessImageRequestBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.ProcessImageRequestBase> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.ProcessImageRequestBase).Name}");
                    process = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (process == null && vectorizeImageRequestBaseVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.VectorizeImageRequestBaseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.VectorizeImageRequestBaseVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.VectorizeImageRequestBaseVariant2).Name}");
                    vectorizeImageRequestBaseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Recraft.VectorizeImageRequestBase(
                process,

                vectorizeImageRequestBaseVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Recraft.VectorizeImageRequestBase value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsProcess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.ProcessImageRequestBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.ProcessImageRequestBase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.ProcessImageRequestBase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Process!, typeInfo);
            }
            else if (value.IsVectorizeImageRequestBaseVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Recraft.VectorizeImageRequestBaseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Recraft.VectorizeImageRequestBaseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Recraft.VectorizeImageRequestBaseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VectorizeImageRequestBaseVariant2!, typeInfo);
            }
        }
    }
}