// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Workspace patch details. </summary>
    public partial class SynapseWorkspacePatch
    {
        /// <summary> Initializes a new instance of <see cref="SynapseWorkspacePatch"/>. </summary>
        public SynapseWorkspacePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseWorkspacePatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="identity"> The identity of the workspace. Current supported identity types: None, SystemAssigned, SystemAssigned,UserAssigned. </param>
        /// <param name="sqlAdministratorLoginPassword"> SQL administrator login password. </param>
        /// <param name="managedVirtualNetworkSettings"> Managed Virtual Network Settings. </param>
        /// <param name="workspaceRepositoryConfiguration"> Git integration settings. </param>
        /// <param name="purviewConfiguration"> Purview Configuration. </param>
        /// <param name="provisioningState"> Resource provisioning state. </param>
        /// <param name="encryption"> The encryption details of the workspace. </param>
        /// <param name="publicNetworkAccess"> Enable or Disable public network access to workspace. </param>
        internal SynapseWorkspacePatch(IDictionary<string, string> tags, ManagedServiceIdentity identity, string sqlAdministratorLoginPassword, SynapseManagedVirtualNetworkSettings managedVirtualNetworkSettings, SynapseWorkspaceRepositoryConfiguration workspaceRepositoryConfiguration, PurviewConfiguration purviewConfiguration, string provisioningState, SynapseEncryptionDetails encryption, WorkspacePublicNetworkAccess? publicNetworkAccess)
        {
            Tags = tags;
            Identity = identity;
            SqlAdministratorLoginPassword = sqlAdministratorLoginPassword;
            ManagedVirtualNetworkSettings = managedVirtualNetworkSettings;
            WorkspaceRepositoryConfiguration = workspaceRepositoryConfiguration;
            PurviewConfiguration = purviewConfiguration;
            ProvisioningState = provisioningState;
            Encryption = encryption;
            PublicNetworkAccess = publicNetworkAccess;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The identity of the workspace. Current supported identity types: None, SystemAssigned, SystemAssigned,UserAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> SQL administrator login password. </summary>
        public string SqlAdministratorLoginPassword { get; set; }
        /// <summary> Managed Virtual Network Settings. </summary>
        public SynapseManagedVirtualNetworkSettings ManagedVirtualNetworkSettings { get; set; }
        /// <summary> Git integration settings. </summary>
        public SynapseWorkspaceRepositoryConfiguration WorkspaceRepositoryConfiguration { get; set; }
        /// <summary> Purview Configuration. </summary>
        internal PurviewConfiguration PurviewConfiguration { get; set; }
        /// <summary> Purview Resource ID. </summary>
        public ResourceIdentifier PurviewResourceId
        {
            get => PurviewConfiguration is null ? default : PurviewConfiguration.PurviewResourceId;
            set
            {
                if (PurviewConfiguration is null)
                    PurviewConfiguration = new PurviewConfiguration();
                PurviewConfiguration.PurviewResourceId = value;
            }
        }

        /// <summary> Resource provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> The encryption details of the workspace. </summary>
        public SynapseEncryptionDetails Encryption { get; set; }
        /// <summary> Enable or Disable public network access to workspace. </summary>
        public WorkspacePublicNetworkAccess? PublicNetworkAccess { get; set; }
    }
}
