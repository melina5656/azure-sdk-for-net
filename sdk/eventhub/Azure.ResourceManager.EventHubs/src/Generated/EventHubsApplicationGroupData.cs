// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary>
    /// A class representing the EventHubsApplicationGroup data model.
    /// The Application Group object
    /// </summary>
    public partial class EventHubsApplicationGroupData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="EventHubsApplicationGroupData"/>. </summary>
        public EventHubsApplicationGroupData()
        {
            Policies = new ChangeTrackingList<EventHubsApplicationGroupPolicy>();
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsApplicationGroupData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="isEnabled"> Determines if Application Group is allowed to create connection with namespace or not. Once the isEnabled is set to false, all the existing connections of application group gets dropped and no new connections will be allowed. </param>
        /// <param name="clientAppGroupIdentifier"> The Unique identifier for application group.Supports SAS(SASKeyName=KeyName) or AAD(AADAppID=Guid). </param>
        /// <param name="policies">
        /// List of group policies that define the behavior of application group. The policies can support resource governance scenarios such as limiting ingress or egress traffic.
        /// Please note <see cref="EventHubsApplicationGroupPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="EventHubsThrottlingPolicy"/>.
        /// </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        internal EventHubsApplicationGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? isEnabled, string clientAppGroupIdentifier, IList<EventHubsApplicationGroupPolicy> policies, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            IsEnabled = isEnabled;
            ClientAppGroupIdentifier = clientAppGroupIdentifier;
            Policies = policies;
            Location = location;
        }

        /// <summary> Determines if Application Group is allowed to create connection with namespace or not. Once the isEnabled is set to false, all the existing connections of application group gets dropped and no new connections will be allowed. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The Unique identifier for application group.Supports SAS(SASKeyName=KeyName) or AAD(AADAppID=Guid). </summary>
        public string ClientAppGroupIdentifier { get; set; }
        /// <summary>
        /// List of group policies that define the behavior of application group. The policies can support resource governance scenarios such as limiting ingress or egress traffic.
        /// Please note <see cref="EventHubsApplicationGroupPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="EventHubsThrottlingPolicy"/>.
        /// </summary>
        public IList<EventHubsApplicationGroupPolicy> Policies { get; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; }
    }
}
