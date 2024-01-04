// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Nginx;

namespace Azure.ResourceManager.Nginx.Models
{
    /// <summary> Response of a list operation. </summary>
    internal partial class NginxConfigurationListResponse
    {
        /// <summary> Initializes a new instance of <see cref="NginxConfigurationListResponse"/>. </summary>
        internal NginxConfigurationListResponse()
        {
            Value = new ChangeTrackingList<NginxConfigurationData>();
        }

        /// <summary> Initializes a new instance of <see cref="NginxConfigurationListResponse"/>. </summary>
        /// <param name="value"> Results of a list operation. </param>
        /// <param name="nextLink"> Link to the next set of results, if any. </param>
        internal NginxConfigurationListResponse(IReadOnlyList<NginxConfigurationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Results of a list operation. </summary>
        public IReadOnlyList<NginxConfigurationData> Value { get; }
        /// <summary> Link to the next set of results, if any. </summary>
        public string NextLink { get; }
    }
}
