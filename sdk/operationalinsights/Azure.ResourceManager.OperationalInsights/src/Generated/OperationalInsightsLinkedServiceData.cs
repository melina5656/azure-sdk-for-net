// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.OperationalInsights.Models;

namespace Azure.ResourceManager.OperationalInsights
{
    /// <summary>
    /// A class representing the OperationalInsightsLinkedService data model.
    /// The top level Linked service resource container.
    /// </summary>
    public partial class OperationalInsightsLinkedServiceData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="OperationalInsightsLinkedServiceData"/>. </summary>
        public OperationalInsightsLinkedServiceData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsLinkedServiceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="resourceId"> The resource id of the resource that will be linked to the workspace. This should be used for linking resources which require read access. </param>
        /// <param name="writeAccessResourceId"> The resource id of the resource that will be linked to the workspace. This should be used for linking resources which require write access. </param>
        /// <param name="provisioningState"> The provisioning state of the linked service. </param>
        internal OperationalInsightsLinkedServiceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, ResourceIdentifier resourceId, ResourceIdentifier writeAccessResourceId, OperationalInsightsLinkedServiceEntityStatus? provisioningState) : base(id, name, resourceType, systemData)
        {
            Tags = tags;
            ResourceId = resourceId;
            WriteAccessResourceId = writeAccessResourceId;
            ProvisioningState = provisioningState;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The resource id of the resource that will be linked to the workspace. This should be used for linking resources which require read access. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> The resource id of the resource that will be linked to the workspace. This should be used for linking resources which require write access. </summary>
        public ResourceIdentifier WriteAccessResourceId { get; set; }
        /// <summary> The provisioning state of the linked service. </summary>
        public OperationalInsightsLinkedServiceEntityStatus? ProvisioningState { get; set; }
    }
}
