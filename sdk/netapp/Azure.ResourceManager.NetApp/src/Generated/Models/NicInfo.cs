// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> NIC information and list of volumes for which the NIC has the primary mount ip address. </summary>
    public partial class NicInfo
    {
        /// <summary> Initializes a new instance of <see cref="NicInfo"/>. </summary>
        internal NicInfo()
        {
            VolumeResourceIds = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of <see cref="NicInfo"/>. </summary>
        /// <param name="ipAddress"> ipAddress. </param>
        /// <param name="volumeResourceIds"> Volume resource Ids. </param>
        internal NicInfo(string ipAddress, IReadOnlyList<ResourceIdentifier> volumeResourceIds)
        {
            IPAddress = ipAddress;
            VolumeResourceIds = volumeResourceIds;
        }

        /// <summary> ipAddress. </summary>
        public string IPAddress { get; }
        /// <summary> Volume resource Ids. </summary>
        public IReadOnlyList<ResourceIdentifier> VolumeResourceIds { get; }
    }
}
