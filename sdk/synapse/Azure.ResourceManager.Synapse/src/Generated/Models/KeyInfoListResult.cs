// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> List of keys. </summary>
    internal partial class KeyInfoListResult
    {
        /// <summary> Initializes a new instance of <see cref="KeyInfoListResult"/>. </summary>
        internal KeyInfoListResult()
        {
            Value = new ChangeTrackingList<SynapseKeyData>();
        }

        /// <summary> Initializes a new instance of <see cref="KeyInfoListResult"/>. </summary>
        /// <param name="nextLink"> Link to the next page of results. </param>
        /// <param name="value"> List of keys. </param>
        internal KeyInfoListResult(string nextLink, IReadOnlyList<SynapseKeyData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> Link to the next page of results. </summary>
        public string NextLink { get; }
        /// <summary> List of keys. </summary>
        public IReadOnlyList<SynapseKeyData> Value { get; }
    }
}
