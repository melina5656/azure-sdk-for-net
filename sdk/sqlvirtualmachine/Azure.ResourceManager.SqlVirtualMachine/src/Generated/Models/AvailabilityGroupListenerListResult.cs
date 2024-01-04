// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SqlVirtualMachine;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> A list of availability group listeners. </summary>
    internal partial class AvailabilityGroupListenerListResult
    {
        /// <summary> Initializes a new instance of <see cref="AvailabilityGroupListenerListResult"/>. </summary>
        internal AvailabilityGroupListenerListResult()
        {
            Value = new ChangeTrackingList<AvailabilityGroupListenerData>();
        }

        /// <summary> Initializes a new instance of <see cref="AvailabilityGroupListenerListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal AvailabilityGroupListenerListResult(IReadOnlyList<AvailabilityGroupListenerData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<AvailabilityGroupListenerData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
