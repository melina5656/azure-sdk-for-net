// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="PeerExpressRouteCircuitConnectionResource"/> and their operations.
    /// Each <see cref="PeerExpressRouteCircuitConnectionResource"/> in the collection will belong to the same instance of <see cref="ExpressRouteCircuitPeeringResource"/>.
    /// To get a <see cref="PeerExpressRouteCircuitConnectionCollection"/> instance call the GetPeerExpressRouteCircuitConnections method from an instance of <see cref="ExpressRouteCircuitPeeringResource"/>.
    /// </summary>
    public partial class PeerExpressRouteCircuitConnectionCollection : ArmCollection, IEnumerable<PeerExpressRouteCircuitConnectionResource>, IAsyncEnumerable<PeerExpressRouteCircuitConnectionResource>
    {
        private readonly ClientDiagnostics _peerExpressRouteCircuitConnectionClientDiagnostics;
        private readonly PeerExpressRouteCircuitConnectionsRestOperations _peerExpressRouteCircuitConnectionRestClient;

        /// <summary> Initializes a new instance of the <see cref="PeerExpressRouteCircuitConnectionCollection"/> class for mocking. </summary>
        protected PeerExpressRouteCircuitConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PeerExpressRouteCircuitConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PeerExpressRouteCircuitConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _peerExpressRouteCircuitConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", PeerExpressRouteCircuitConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PeerExpressRouteCircuitConnectionResource.ResourceType, out string peerExpressRouteCircuitConnectionApiVersion);
            _peerExpressRouteCircuitConnectionRestClient = new PeerExpressRouteCircuitConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, peerExpressRouteCircuitConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ExpressRouteCircuitPeeringResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ExpressRouteCircuitPeeringResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the specified Peer Express Route Circuit Connection from the specified express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/peerConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeerExpressRouteCircuitConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the peer express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<PeerExpressRouteCircuitConnectionResource>> GetAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _peerExpressRouteCircuitConnectionClientDiagnostics.CreateScope("PeerExpressRouteCircuitConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _peerExpressRouteCircuitConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PeerExpressRouteCircuitConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Peer Express Route Circuit Connection from the specified express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/peerConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeerExpressRouteCircuitConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the peer express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<PeerExpressRouteCircuitConnectionResource> Get(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _peerExpressRouteCircuitConnectionClientDiagnostics.CreateScope("PeerExpressRouteCircuitConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _peerExpressRouteCircuitConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PeerExpressRouteCircuitConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all global reach peer connections associated with a private peering in an express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/peerConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeerExpressRouteCircuitConnections_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PeerExpressRouteCircuitConnectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PeerExpressRouteCircuitConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _peerExpressRouteCircuitConnectionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _peerExpressRouteCircuitConnectionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PeerExpressRouteCircuitConnectionResource(Client, PeerExpressRouteCircuitConnectionData.DeserializePeerExpressRouteCircuitConnectionData(e)), _peerExpressRouteCircuitConnectionClientDiagnostics, Pipeline, "PeerExpressRouteCircuitConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all global reach peer connections associated with a private peering in an express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/peerConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeerExpressRouteCircuitConnections_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PeerExpressRouteCircuitConnectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PeerExpressRouteCircuitConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _peerExpressRouteCircuitConnectionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _peerExpressRouteCircuitConnectionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PeerExpressRouteCircuitConnectionResource(Client, PeerExpressRouteCircuitConnectionData.DeserializePeerExpressRouteCircuitConnectionData(e)), _peerExpressRouteCircuitConnectionClientDiagnostics, Pipeline, "PeerExpressRouteCircuitConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/peerConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeerExpressRouteCircuitConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the peer express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _peerExpressRouteCircuitConnectionClientDiagnostics.CreateScope("PeerExpressRouteCircuitConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _peerExpressRouteCircuitConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/peerConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeerExpressRouteCircuitConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the peer express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _peerExpressRouteCircuitConnectionClientDiagnostics.CreateScope("PeerExpressRouteCircuitConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _peerExpressRouteCircuitConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/peerConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeerExpressRouteCircuitConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the peer express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<NullableResponse<PeerExpressRouteCircuitConnectionResource>> GetIfExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _peerExpressRouteCircuitConnectionClientDiagnostics.CreateScope("PeerExpressRouteCircuitConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _peerExpressRouteCircuitConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PeerExpressRouteCircuitConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new PeerExpressRouteCircuitConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/peerConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeerExpressRouteCircuitConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the peer express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual NullableResponse<PeerExpressRouteCircuitConnectionResource> GetIfExists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _peerExpressRouteCircuitConnectionClientDiagnostics.CreateScope("PeerExpressRouteCircuitConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _peerExpressRouteCircuitConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PeerExpressRouteCircuitConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new PeerExpressRouteCircuitConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PeerExpressRouteCircuitConnectionResource> IEnumerable<PeerExpressRouteCircuitConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PeerExpressRouteCircuitConnectionResource> IAsyncEnumerable<PeerExpressRouteCircuitConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
