// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Disk.Management
{
    internal class DiskEncryptionSetOperationSource : IOperationSource<DiskEncryptionSetResource>
    {
        private readonly ArmClient _client;

        internal DiskEncryptionSetOperationSource(ArmClient client)
        {
            _client = client;
        }

        DiskEncryptionSetResource IOperationSource<DiskEncryptionSetResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DiskEncryptionSetData.DeserializeDiskEncryptionSetData(document.RootElement);
            return new DiskEncryptionSetResource(_client, data);
        }

        async ValueTask<DiskEncryptionSetResource> IOperationSource<DiskEncryptionSetResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DiskEncryptionSetData.DeserializeDiskEncryptionSetData(document.RootElement);
            return new DiskEncryptionSetResource(_client, data);
        }
    }
}
