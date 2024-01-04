// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Parameters to be used during configuration of backup of blobs. </summary>
    public partial class BlobBackupDataSourceSettings : BackupDataSourceSettings
    {
        /// <summary> Initializes a new instance of <see cref="BlobBackupDataSourceSettings"/>. </summary>
        /// <param name="containersList"> List of containers to be backed up during configuration of backup of blobs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containersList"/> is null. </exception>
        public BlobBackupDataSourceSettings(IEnumerable<string> containersList)
        {
            Argument.AssertNotNull(containersList, nameof(containersList));

            ContainersList = containersList.ToList();
            ObjectType = "BlobBackupDatasourceParameters";
        }

        /// <summary> Initializes a new instance of <see cref="BlobBackupDataSourceSettings"/>. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        /// <param name="containersList"> List of containers to be backed up during configuration of backup of blobs. </param>
        internal BlobBackupDataSourceSettings(string objectType, IList<string> containersList) : base(objectType)
        {
            ContainersList = containersList;
            ObjectType = objectType ?? "BlobBackupDatasourceParameters";
        }

        /// <summary> List of containers to be backed up during configuration of backup of blobs. </summary>
        public IList<string> ContainersList { get; }
    }
}
