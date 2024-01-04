// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    /// <summary>
    /// A Class representing a BackupEngine along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="BackupEngineResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetBackupEngineResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource"/> using the GetBackupEngine method.
    /// </summary>
    public partial class BackupEngineResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BackupEngineResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="vaultName"> The vaultName. </param>
        /// <param name="backupEngineName"> The backupEngineName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vaultName, string backupEngineName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupEngines/{backupEngineName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _backupEngineClientDiagnostics;
        private readonly BackupEnginesRestOperations _backupEngineRestClient;
        private readonly BackupEngineData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.RecoveryServices/vaults/backupEngines";

        /// <summary> Initializes a new instance of the <see cref="BackupEngineResource"/> class for mocking. </summary>
        protected BackupEngineResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BackupEngineResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BackupEngineResource(ArmClient client, BackupEngineData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BackupEngineResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BackupEngineResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _backupEngineClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesBackup", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string backupEngineApiVersion);
            _backupEngineRestClient = new BackupEnginesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, backupEngineApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual BackupEngineData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Returns backup management server registered to Recovery Services Vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupEngines/{backupEngineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupEngines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="skipToken"> skipToken Filter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BackupEngineResource>> GetAsync(string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            using var scope = _backupEngineClientDiagnostics.CreateScope("BackupEngineResource.Get");
            scope.Start();
            try
            {
                var response = await _backupEngineRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, skipToken, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackupEngineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns backup management server registered to Recovery Services Vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupEngines/{backupEngineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupEngines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="skipToken"> skipToken Filter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BackupEngineResource> Get(string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            using var scope = _backupEngineClientDiagnostics.CreateScope("BackupEngineResource.Get");
            scope.Start();
            try
            {
                var response = _backupEngineRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, skipToken, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackupEngineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
