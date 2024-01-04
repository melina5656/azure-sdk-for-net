// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.MixedReality.ObjectAnchors.Conversion
{
    internal partial class BlobUploadEndpointRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of BlobUploadEndpointRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public BlobUploadEndpointRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string apiVersion = "0.3-preview.2")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateGetRequest(Guid accountId, string xMrcCv)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/accounts/", false);
            uri.AppendPath(accountId, true);
            uri.AppendPath("/blobUploadEndpoint", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (xMrcCv != null)
            {
                request.Headers.Add("x-mrc-cv", xMrcCv);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets a blob upload uri. </summary>
        /// <param name="accountId"> Identifier for the Azure Object Anchors account. </param>
        /// <param name="xMrcCv"> The client request correlation vector, which should be set to a new value for each request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<AssetUploadUriResult, BlobUploadEndpointGetHeaders>> GetAsync(Guid accountId, string xMrcCv = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequest(accountId, xMrcCv);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new BlobUploadEndpointGetHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssetUploadUriResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AssetUploadUriResult.DeserializeAssetUploadUriResult(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a blob upload uri. </summary>
        /// <param name="accountId"> Identifier for the Azure Object Anchors account. </param>
        /// <param name="xMrcCv"> The client request correlation vector, which should be set to a new value for each request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<AssetUploadUriResult, BlobUploadEndpointGetHeaders> Get(Guid accountId, string xMrcCv = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequest(accountId, xMrcCv);
            _pipeline.Send(message, cancellationToken);
            var headers = new BlobUploadEndpointGetHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssetUploadUriResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AssetUploadUriResult.DeserializeAssetUploadUriResult(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
