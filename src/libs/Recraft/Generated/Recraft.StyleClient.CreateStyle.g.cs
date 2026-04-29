
#nullable enable

namespace Recraft
{
    public partial class StyleClient
    {


        private static readonly global::Recraft.EndPointSecurityRequirement s_CreateStyleSecurityRequirement0 =
            new global::Recraft.EndPointSecurityRequirement
            {
                Authorizations = new global::Recraft.EndPointAuthorizationRequirement[]
                {                    new global::Recraft.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Recraft.EndPointSecurityRequirement[] s_CreateStyleSecurityRequirements =
            new global::Recraft.EndPointSecurityRequirement[]
            {                s_CreateStyleSecurityRequirement0,
            };
        partial void PrepareCreateStyleArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::Recraft.BillingType? billing,
            global::Recraft.CreateStyleRequest request);
        partial void PrepareCreateStyleRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Recraft.BillingType? billing,
            global::Recraft.CreateStyleRequest request);
        partial void ProcessCreateStyleResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateStyleResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Style
        /// </summary>
        /// <param name="billing"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recraft.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Recraft.CreateStyleResponse> CreateStyleAsync(

            global::Recraft.CreateStyleRequest request,
            global::Recraft.BillingType? billing = default,
            global::Recraft.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateStyleArguments(
                httpClient: HttpClient,
                billing: ref billing,
                request: request);


            var __authorizations = global::Recraft.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateStyleSecurityRequirements,
                operationName: "CreateStyleAsync");

            using var __timeoutCancellationTokenSource = global::Recraft.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Recraft.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Recraft.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::Recraft.PathBuilder(
                                path: "/v1/styles",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("billing", billing?.ToValueString()) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Recraft.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            if (billing != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((billing).HasValue ? (billing).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"billing\"");
                            } 
                            if (request.ImageWeights != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.ImageWeights, x => global::System.Convert.ToString(x, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty))}]"),
                                    name: "\"image_weights\"");
                            }
                            for (var __iImages = 0; __iImages < request.Images.Count; __iImages++)
                            {
                                var __contentImages = new global::System.Net.Http.ByteArrayContent(request.Images[__iImages]);
                            __contentImages.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
                                __httpRequestContent.Add(
                                    content: __contentImages,
                                    name: "\"images\"",
                                    fileName: $"\"file{__iImages}.bin\"");
                                if (__contentImages.Headers.ContentDisposition != null)
                                {
                                    __contentImages.Headers.ContentDisposition.FileNameStar = null;
                                }
                            }
                            if (request.MixPolicy != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.MixPolicy).HasValue ? (request.MixPolicy).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"mix_policy\"");
                            } 
                            if (request.Model != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.Model).HasValue ? (request.Model).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"model\"");
                            } 
                            if (request.Palette != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Palette.ToJson(JsonSerializerContext)),
                                    name: "\"palette\"");
                            } 
                            if (request.Private != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.Private, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"private\"");
                            } 
                            if (request.Prompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Prompt ?? string.Empty),
                                    name: "\"prompt\"");
                            } 
                            if (request.SourceStyleWeights != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.SourceStyleWeights, x => global::System.Convert.ToString(x, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty))}]"),
                                    name: "\"source_style_weights\"");
                            } 
                            if (request.SourceStyles != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.SourceStyles, x => x.ToString() ?? string.Empty))}]"),
                                    name: "\"source_styles\"");
                            }
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent(request.Style.ToValueString()),
                                name: "\"style\"");
                            __httpRequest.Content = __httpRequestContent;
                global::Recraft.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateStyleRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    billing: billing,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Recraft.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Recraft.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateStyle",
                                methodName: "CreateStyleAsync",
                                pathTemplate: "\"/v1/styles\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Recraft.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Recraft.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateStyle",
                                methodName: "CreateStyleAsync",
                                pathTemplate: "\"/v1/styles\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Recraft.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Recraft.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Recraft.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Recraft.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateStyle",
                                methodName: "CreateStyleAsync",
                                pathTemplate: "\"/v1/styles\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Recraft.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCreateStyleResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Recraft.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Recraft.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateStyle",
                                methodName: "CreateStyleAsync",
                                pathTemplate: "\"/v1/styles\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Recraft.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Recraft.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateStyle",
                                methodName: "CreateStyleAsync",
                                pathTemplate: "\"/v1/styles\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessCreateStyleResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Recraft.CreateStyleResponse.FromJson(__content, JsonSerializerContext) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::Recraft.CreateStyleResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Create Style
        /// </summary>
        /// <param name="billing"></param>
        /// <param name="imageWeights"></param>
        /// <param name="images"></param>
        /// <param name="mixPolicy"></param>
        /// <param name="model"></param>
        /// <param name="palette"></param>
        /// <param name="private"></param>
        /// <param name="prompt"></param>
        /// <param name="sourceStyleWeights"></param>
        /// <param name="sourceStyles"></param>
        /// <param name="style"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Recraft.CreateStyleResponse> CreateStyleAsync(
            global::System.Collections.Generic.IList<byte[]> images,
            global::Recraft.ImageStyle style,
            global::Recraft.BillingType? billing = default,
            global::System.Collections.Generic.IList<double>? imageWeights = default,
            global::Recraft.MixPolicy? mixPolicy = default,
            global::Recraft.TransformModel? model = default,
            global::Recraft.PaletteSuggest? palette = default,
            bool? @private = default,
            string? prompt = default,
            global::System.Collections.Generic.IList<double>? sourceStyleWeights = default,
            global::System.Collections.Generic.IList<global::System.Guid>? sourceStyles = default,
            global::Recraft.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Recraft.CreateStyleRequest
            {
                ImageWeights = imageWeights,
                Images = images,
                MixPolicy = mixPolicy,
                Model = model,
                Palette = palette,
                Private = @private,
                Prompt = prompt,
                SourceStyleWeights = sourceStyleWeights,
                SourceStyles = sourceStyles,
                Style = style,
            };

            return await CreateStyleAsync(
                billing: billing,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}