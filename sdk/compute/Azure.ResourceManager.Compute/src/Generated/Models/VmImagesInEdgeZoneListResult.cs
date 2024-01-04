// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The List VmImages in EdgeZone operation response. </summary>
    internal partial class VmImagesInEdgeZoneListResult
    {
        /// <summary> Initializes a new instance of <see cref="VmImagesInEdgeZoneListResult"/>. </summary>
        internal VmImagesInEdgeZoneListResult()
        {
            Value = new ChangeTrackingList<VirtualMachineImageBase>();
        }

        /// <summary> Initializes a new instance of <see cref="VmImagesInEdgeZoneListResult"/>. </summary>
        /// <param name="value"> The list of VMImages in EdgeZone. </param>
        /// <param name="nextLink"> The URI to fetch the next page of VMImages in EdgeZone. Call ListNext() with this URI to fetch the next page of VmImages. </param>
        internal VmImagesInEdgeZoneListResult(IReadOnlyList<VirtualMachineImageBase> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of VMImages in EdgeZone. </summary>
        public IReadOnlyList<VirtualMachineImageBase> Value { get; }
        /// <summary> The URI to fetch the next page of VMImages in EdgeZone. Call ListNext() with this URI to fetch the next page of VmImages. </summary>
        public string NextLink { get; }
    }
}
