// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Parameters for Operational-Tier DataStore. </summary>
    public partial class OperationalDataStoreSettings : DataStoreSettings
    {
        /// <summary> Initializes a new instance of <see cref="OperationalDataStoreSettings"/>. </summary>
        /// <param name="dataStoreType"> type of datastore; Operational/Vault/Archive. </param>
        public OperationalDataStoreSettings(DataStoreType dataStoreType) : base(dataStoreType)
        {
            ObjectType = "AzureOperationalStoreParameters";
        }

        /// <summary> Initializes a new instance of <see cref="OperationalDataStoreSettings"/>. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        /// <param name="dataStoreType"> type of datastore; Operational/Vault/Archive. </param>
        /// <param name="resourceGroupId"> Gets or sets the Snapshot Resource Group Uri. </param>
        internal OperationalDataStoreSettings(string objectType, DataStoreType dataStoreType, ResourceIdentifier resourceGroupId) : base(objectType, dataStoreType)
        {
            ResourceGroupId = resourceGroupId;
            ObjectType = objectType ?? "AzureOperationalStoreParameters";
        }

        /// <summary> Gets or sets the Snapshot Resource Group Uri. </summary>
        public ResourceIdentifier ResourceGroupId { get; set; }
    }
}
