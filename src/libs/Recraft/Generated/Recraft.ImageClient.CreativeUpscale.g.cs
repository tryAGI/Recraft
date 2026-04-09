
#nullable enable

namespace Recraft
{
    public partial class ImageClient
    {


        private static readonly global::Recraft.EndPointSecurityRequirement s_CreativeUpscaleSecurityRequirement0 =
            new global::Recraft.EndPointSecurityRequirement
            {
                Authorizations = new global::Recraft.EndPointAuthorizationRequirement[]
                {                    new global::Recraft.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Recraft.EndPointSecurityRequirement[] s_CreativeUpscaleSecurityRequirements =
            new global::Recraft.EndPointSecurityRequirement[]
            {                s_CreativeUpscaleSecurityRequirement0,
            };
        partial void PrepareCreativeUpscaleArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::Recraft.BillingType? billing,
            global::Recraft.ProcessImageRequest request);
        partial void PrepareCreativeUpscaleRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Recraft.BillingType? billing,
            global::Recraft.ProcessImageRequest request);
        partial void ProcessCreativeUpscaleResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreativeUpscaleResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Creative Upscale
        /// </summary>
        /// <param name="billing"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recraft.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Recraft.ProcessImageResponse> CreativeUpscaleAsync(

            global::Recraft.ProcessImageRequest request,
            global::Recraft.BillingType? billing = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreativeUpscaleArguments(
                httpClient: HttpClient,
                billing: ref billing,
                request: request);


            var __authorizations = global::Recraft.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreativeUpscaleSecurityRequirements,
                operationName: "CreativeUpscaleAsync");

            var __pathBuilder = new global::Recraft.PathBuilder(
                path: "/v1/images/creativeUpscale",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("billing", billing?.ToValueString()) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
            if (billing != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{billing?.ToValueString()}"),
                    name: "\"billing\"");
            } 
            if (request.Expire != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Expire}"),
                    name: "\"expire\"");
            }
            var __contentImage = new global::System.Net.Http.ByteArrayContent(request.Image ?? global::System.Array.Empty<byte>());
            __httpRequestContent.Add(
                content: __contentImage,
                name: "\"image\"",
                fileName: request.Imagename != null ? $"\"{request.Imagename}\"" : string.Empty);
            if (__contentImage.Headers.ContentDisposition != null)
            {
                __contentImage.Headers.ContentDisposition.FileNameStar = null;
            }
            if (request.ImageFormat != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ImageFormat?.ToValueString()}"),
                    name: "\"image_format\"");
            } 
            if (request.ResponseFormat != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ResponseFormat?.ToValueString()}"),
                    name: "\"response_format\"");
            } 
            if (request.Upscale != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Upscale?.ToValueString()}"),
                    name: "\"upscale\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreativeUpscaleRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                billing: billing,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreativeUpscaleResponse(
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
                ProcessCreativeUpscaleResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Recraft.ProcessImageResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Recraft.ProcessImageResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

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
        }
        /// <summary>
        /// Creative Upscale
        /// </summary>
        /// <param name="billing"></param>
        /// <param name="expire"></param>
        /// <param name="image"></param>
        /// <param name="imagename"></param>
        /// <param name="imageFormat"></param>
        /// <param name="responseFormat"></param>
        /// <param name="upscale"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Recraft.ProcessImageResponse> CreativeUpscaleAsync(
            byte[] image,
            string imagename,
            global::Recraft.BillingType? billing = default,
            bool? expire = default,
            global::Recraft.ImageFormat? imageFormat = default,
            global::Recraft.ResponseFormat? responseFormat = default,
            global::Recraft.UpscaleMode? upscale = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Recraft.ProcessImageRequest
            {
                Expire = expire,
                Image = image,
                Imagename = imagename,
                ImageFormat = imageFormat,
                ResponseFormat = responseFormat,
                Upscale = upscale,
            };

            return await CreativeUpscaleAsync(
                billing: billing,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}