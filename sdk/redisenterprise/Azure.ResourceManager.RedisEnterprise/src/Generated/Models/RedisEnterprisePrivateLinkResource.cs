// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    /// <summary> A private link resource. </summary>
    public partial class RedisEnterprisePrivateLinkResource : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="RedisEnterprisePrivateLinkResource"/>. </summary>
        public RedisEnterprisePrivateLinkResource()
        {
            RequiredMembers = new ChangeTrackingList<string>();
            RequiredZoneNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="RedisEnterprisePrivateLinkResource"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        /// <param name="requiredZoneNames"> The private link resource Private link DNS zone name. </param>
        internal RedisEnterprisePrivateLinkResource(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string groupId, IReadOnlyList<string> requiredMembers, IList<string> requiredZoneNames) : base(id, name, resourceType, systemData)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
        }

        /// <summary> The private link resource group id. </summary>
        public string GroupId { get; }
        /// <summary> The private link resource required member names. </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
        /// <summary> The private link resource Private link DNS zone name. </summary>
        public IList<string> RequiredZoneNames { get; }
    }
}
