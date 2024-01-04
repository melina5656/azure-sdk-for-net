// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> DataProtection type volumes include an object containing details of the replication. </summary>
    public partial class NetAppVolumeDataProtection
    {
        /// <summary> Initializes a new instance of <see cref="NetAppVolumeDataProtection"/>. </summary>
        public NetAppVolumeDataProtection()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeDataProtection"/>. </summary>
        /// <param name="replication"> Replication properties. </param>
        /// <param name="snapshot"> Snapshot properties. </param>
        /// <param name="volumeRelocation"> VolumeRelocation properties. </param>
        internal NetAppVolumeDataProtection(NetAppReplicationObject replication, VolumeSnapshotProperties snapshot, NetAppVolumeRelocationProperties volumeRelocation)
        {
            Replication = replication;
            Snapshot = snapshot;
            VolumeRelocation = volumeRelocation;
        }

        /// <summary> Replication properties. </summary>
        public NetAppReplicationObject Replication { get; set; }
        /// <summary> Snapshot properties. </summary>
        internal VolumeSnapshotProperties Snapshot { get; set; }
        /// <summary> Snapshot Policy ResourceId. </summary>
        public ResourceIdentifier SnapshotPolicyId
        {
            get => Snapshot is null ? default : Snapshot.SnapshotPolicyId;
            set
            {
                if (Snapshot is null)
                    Snapshot = new VolumeSnapshotProperties();
                Snapshot.SnapshotPolicyId = value;
            }
        }

        /// <summary> VolumeRelocation properties. </summary>
        public NetAppVolumeRelocationProperties VolumeRelocation { get; set; }
    }
}
