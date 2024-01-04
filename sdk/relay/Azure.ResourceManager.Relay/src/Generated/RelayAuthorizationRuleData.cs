// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Relay.Models;

namespace Azure.ResourceManager.Relay
{
    /// <summary>
    /// A class representing the RelayAuthorizationRule data model.
    /// Single item in a List or Get AuthorizationRule operation
    /// </summary>
    public partial class RelayAuthorizationRuleData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="RelayAuthorizationRuleData"/>. </summary>
        public RelayAuthorizationRuleData()
        {
            Rights = new ChangeTrackingList<RelayAccessRight>();
        }

        /// <summary> Initializes a new instance of <see cref="RelayAuthorizationRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="rights"> The rights associated with the rule. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        internal RelayAuthorizationRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<RelayAccessRight> rights, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            Rights = rights;
            Location = location;
        }

        /// <summary> The rights associated with the rule. </summary>
        public IList<RelayAccessRight> Rights { get; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; }
    }
}
