
#nullable enable

namespace Recraft
{
    public partial class ImageClient
    {
        partial void PrepareImageToImageArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Recraft.ImageToImageRequest request);
        partial void PrepareImageToImageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Recraft.ImageToImageRequest request);
        partial void ProcessImageToImageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessImageToImageResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate image from image and prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recraft.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Recraft.GenerateImageResponse> ImageToImageAsync(
            global::Recraft.ImageToImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareImageToImageArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Recraft.PathBuilder(
                path: "/v1/images/imageToImage",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (request.BlockNsfw != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.BlockNsfw}"),
                    name: "block_nsfw");
            } 
            if (request.CalculateFeatures != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.CalculateFeatures}"),
                    name: "calculate_features");
            } 
            if (request.Controls != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Controls}"),
                    name: "controls");
            } 
            if (request.Expire != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Expire}"),
                    name: "expire");
            } 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.Image ?? global::System.Array.Empty<byte>()),
                name: "image",
                fileName: request.Imagename ?? string.Empty);
            if (request.ImageFormat != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ImageFormat?.ToValueString()}"),
                    name: "image_format");
            } 
            if (request.Model != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Model?.ToValueString()}"),
                    name: "model");
            } 
            if (request.N != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.N}"),
                    name: "n");
            } 
            if (request.NegativePrompt != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.NegativePrompt}"),
                    name: "negative_prompt");
            } 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Prompt}"),
                name: "prompt");
            if (request.RandomSeed != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.RandomSeed}"),
                    name: "random_seed");
            } 
            if (request.ResponseFormat != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ResponseFormat?.ToValueString()}"),
                    name: "response_format");
            } 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Strength}"),
                name: "strength");
            if (request.Style != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Style?.ToValueString()}"),
                    name: "style");
            } 
            if (request.StyleId != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.StyleId}"),
                    name: "style_id");
            } 
            if (request.Substyle != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Substyle?.ToValueString()}"),
                    name: "substyle");
            } 
            if (request.TextLayout != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.TextLayout, x => x))}]"),
                    name: "text_layout");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareImageToImageRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessImageToImageResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessImageToImageResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Recraft.GenerateImageResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Recraft.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Recraft.GenerateImageResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Recraft.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }

        /// <summary>
        /// Generate image from image and prompt
        /// </summary>
        /// <param name="blockNsfw"></param>
        /// <param name="calculateFeatures"></param>
        /// <param name="controls"></param>
        /// <param name="expire"></param>
        /// <param name="image"></param>
        /// <param name="imagename"></param>
        /// <param name="imageFormat"></param>
        /// <param name="model"></param>
        /// <param name="n"></param>
        /// <param name="negativePrompt"></param>
        /// <param name="prompt"></param>
        /// <param name="randomSeed"></param>
        /// <param name="responseFormat"></param>
        /// <param name="strength"></param>
        /// <param name="style"></param>
        /// <param name="styleId"></param>
        /// <param name="substyle"></param>
        /// <param name="textLayout"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Recraft.GenerateImageResponse> ImageToImageAsync(
            byte[] image,
            string imagename,
            string prompt,
            double strength,
            bool? blockNsfw = default,
            bool? calculateFeatures = default,
            global::Recraft.UserControls? controls = default,
            bool? expire = default,
            global::Recraft.ImageFormat? imageFormat = default,
            global::Recraft.TransformModel? model = default,
            int? n = default,
            string? negativePrompt = default,
            int? randomSeed = default,
            global::Recraft.ResponseFormat? responseFormat = default,
            global::Recraft.ImageStyle? style = default,
            global::System.Guid? styleId = default,
            global::Recraft.ImageSubStyle? substyle = default,
            global::System.Collections.Generic.IList<global::Recraft.TextLayoutItem>? textLayout = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Recraft.ImageToImageRequest
            {
                BlockNsfw = blockNsfw,
                CalculateFeatures = calculateFeatures,
                Controls = controls,
                Expire = expire,
                Image = image,
                Imagename = imagename,
                ImageFormat = imageFormat,
                Model = model,
                N = n,
                NegativePrompt = negativePrompt,
                Prompt = prompt,
                RandomSeed = randomSeed,
                ResponseFormat = responseFormat,
                Strength = strength,
                Style = style,
                StyleId = styleId,
                Substyle = substyle,
                TextLayout = textLayout,
            };

            return await ImageToImageAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}