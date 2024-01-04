// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the ApiManagementDeletedService data model.
    /// Deleted API Management Service information.
    /// </summary>
    public partial class ApiManagementDeletedServiceData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ApiManagementDeletedServiceData"/>. </summary>
        public ApiManagementDeletedServiceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementDeletedServiceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> API Management Service Master Location. </param>
        /// <param name="serviceId"> Fully-qualified API Management Service Resource ID. </param>
        /// <param name="scheduledPurgeOn"> UTC Date and Time when the service will be automatically purged. The date conforms to the following format: yyyy-MM-ddTHH:mm:ssZ as specified by the ISO 8601 standard. </param>
        /// <param name="deletedOn"> UTC Timestamp when the service was soft-deleted. The date conforms to the following format: yyyy-MM-ddTHH:mm:ssZ as specified by the ISO 8601 standard. </param>
        internal ApiManagementDeletedServiceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, ResourceIdentifier serviceId, DateTimeOffset? scheduledPurgeOn, DateTimeOffset? deletedOn) : base(id, name, resourceType, systemData)
        {
            Location = location;
            ServiceId = serviceId;
            ScheduledPurgeOn = scheduledPurgeOn;
            DeletedOn = deletedOn;
        }

        /// <summary> API Management Service Master Location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Fully-qualified API Management Service Resource ID. </summary>
        public ResourceIdentifier ServiceId { get; set; }
        /// <summary> UTC Date and Time when the service will be automatically purged. The date conforms to the following format: yyyy-MM-ddTHH:mm:ssZ as specified by the ISO 8601 standard. </summary>
        public DateTimeOffset? ScheduledPurgeOn { get; set; }
        /// <summary> UTC Timestamp when the service was soft-deleted. The date conforms to the following format: yyyy-MM-ddTHH:mm:ssZ as specified by the ISO 8601 standard. </summary>
        public DateTimeOffset? DeletedOn { get; set; }
    }
}
