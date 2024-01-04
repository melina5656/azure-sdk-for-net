// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Scope of Network Manager. </summary>
    public partial class NetworkManagerPropertiesNetworkManagerScopes
    {
        /// <summary> Initializes a new instance of <see cref="NetworkManagerPropertiesNetworkManagerScopes"/>. </summary>
        public NetworkManagerPropertiesNetworkManagerScopes()
        {
            ManagementGroups = new ChangeTrackingList<string>();
            Subscriptions = new ChangeTrackingList<string>();
            CrossTenantScopes = new ChangeTrackingList<CrossTenantScopes>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkManagerPropertiesNetworkManagerScopes"/>. </summary>
        /// <param name="managementGroups"> List of management groups. </param>
        /// <param name="subscriptions"> List of subscriptions. </param>
        /// <param name="crossTenantScopes"> List of cross tenant scopes. </param>
        internal NetworkManagerPropertiesNetworkManagerScopes(IList<string> managementGroups, IList<string> subscriptions, IReadOnlyList<CrossTenantScopes> crossTenantScopes)
        {
            ManagementGroups = managementGroups;
            Subscriptions = subscriptions;
            CrossTenantScopes = crossTenantScopes;
        }

        /// <summary> List of management groups. </summary>
        public IList<string> ManagementGroups { get; }
        /// <summary> List of subscriptions. </summary>
        public IList<string> Subscriptions { get; }
        /// <summary> List of cross tenant scopes. </summary>
        public IReadOnlyList<CrossTenantScopes> CrossTenantScopes { get; }
    }
}
