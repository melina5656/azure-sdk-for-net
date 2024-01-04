// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> VpnServerConfigurations list associated with VirtualWan Response. </summary>
    public partial class VpnServerConfigurationsResponse
    {
        /// <summary> Initializes a new instance of <see cref="VpnServerConfigurationsResponse"/>. </summary>
        internal VpnServerConfigurationsResponse()
        {
            VpnServerConfigurationResourceIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="VpnServerConfigurationsResponse"/>. </summary>
        /// <param name="vpnServerConfigurationResourceIds"> List of VpnServerConfigurations associated with VirtualWan. </param>
        internal VpnServerConfigurationsResponse(IReadOnlyList<string> vpnServerConfigurationResourceIds)
        {
            VpnServerConfigurationResourceIds = vpnServerConfigurationResourceIds;
        }

        /// <summary> List of VpnServerConfigurations associated with VirtualWan. </summary>
        public IReadOnlyList<string> VpnServerConfigurationResourceIds { get; }
    }
}
