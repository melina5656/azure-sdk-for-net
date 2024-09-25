// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Compute.Management.Models;

namespace Compute.Management
{
    internal class VirtualMachineAssessPatchesResultOperationSource : IOperationSource<VirtualMachineAssessPatchesResult>
    {
        VirtualMachineAssessPatchesResult IOperationSource<VirtualMachineAssessPatchesResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return VirtualMachineAssessPatchesResult.DeserializeVirtualMachineAssessPatchesResult(document.RootElement);
        }

        async ValueTask<VirtualMachineAssessPatchesResult> IOperationSource<VirtualMachineAssessPatchesResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return VirtualMachineAssessPatchesResult.DeserializeVirtualMachineAssessPatchesResult(document.RootElement);
        }
    }
}
