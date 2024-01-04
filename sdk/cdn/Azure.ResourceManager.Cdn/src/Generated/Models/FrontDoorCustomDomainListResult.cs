// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Cdn;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Result of the request to list domains. It contains a list of domain objects and a URL link to get the next set of results. </summary>
    internal partial class FrontDoorCustomDomainListResult
    {
        /// <summary> Initializes a new instance of <see cref="FrontDoorCustomDomainListResult"/>. </summary>
        internal FrontDoorCustomDomainListResult()
        {
            Value = new ChangeTrackingList<FrontDoorCustomDomainData>();
        }

        /// <summary> Initializes a new instance of <see cref="FrontDoorCustomDomainListResult"/>. </summary>
        /// <param name="value"> List of AzureFrontDoor domains within a profile. </param>
        /// <param name="nextLink"> URL to get the next set of domain objects if there are any. </param>
        internal FrontDoorCustomDomainListResult(IReadOnlyList<FrontDoorCustomDomainData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of AzureFrontDoor domains within a profile. </summary>
        public IReadOnlyList<FrontDoorCustomDomainData> Value { get; }
        /// <summary> URL to get the next set of domain objects if there are any. </summary>
        public string NextLink { get; }
    }
}
