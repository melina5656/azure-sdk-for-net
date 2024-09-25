// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Disk.Management.Models;

namespace Disk.Management
{
    internal class AccessUriOperationSource : IOperationSource<AccessUri>
    {
        AccessUri IOperationSource<AccessUri>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return AccessUri.DeserializeAccessUri(document.RootElement);
        }

        async ValueTask<AccessUri> IOperationSource<AccessUri>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return AccessUri.DeserializeAccessUri(document.RootElement);
        }
    }
}
