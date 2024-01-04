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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="ExpressRoutePortsLocationResource"/> and their operations.
    /// Each <see cref="ExpressRoutePortsLocationResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get an <see cref="ExpressRoutePortsLocationCollection"/> instance call the GetExpressRoutePortsLocations method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class ExpressRoutePortsLocationCollection : ArmCollection, IEnumerable<ExpressRoutePortsLocationResource>, IAsyncEnumerable<ExpressRoutePortsLocationResource>
    {
        private readonly ClientDiagnostics _expressRoutePortsLocationClientDiagnostics;
        private readonly ExpressRoutePortsLocationsRestOperations _expressRoutePortsLocationRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRoutePortsLocationCollection"/> class for mocking. </summary>
        protected ExpressRoutePortsLocationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRoutePortsLocationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExpressRoutePortsLocationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRoutePortsLocationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ExpressRoutePortsLocationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ExpressRoutePortsLocationResource.ResourceType, out string expressRoutePortsLocationApiVersion);
            _expressRoutePortsLocationRestClient = new ExpressRoutePortsLocationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, expressRoutePortsLocationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Retrieves a single ExpressRoutePort peering location, including the list of available bandwidths available at said peering location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/ExpressRoutePortsLocations/{locationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePortsLocations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> Name of the requested ExpressRoutePort peering location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        public virtual async Task<Response<ExpressRoutePortsLocationResource>> GetAsync(string locationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));

            using var scope = _expressRoutePortsLocationClientDiagnostics.CreateScope("ExpressRoutePortsLocationCollection.Get");
            scope.Start();
            try
            {
                var response = await _expressRoutePortsLocationRestClient.GetAsync(Id.SubscriptionId, locationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRoutePortsLocationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves a single ExpressRoutePort peering location, including the list of available bandwidths available at said peering location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/ExpressRoutePortsLocations/{locationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePortsLocations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> Name of the requested ExpressRoutePort peering location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        public virtual Response<ExpressRoutePortsLocationResource> Get(string locationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));

            using var scope = _expressRoutePortsLocationClientDiagnostics.CreateScope("ExpressRoutePortsLocationCollection.Get");
            scope.Start();
            try
            {
                var response = _expressRoutePortsLocationRestClient.Get(Id.SubscriptionId, locationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRoutePortsLocationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves all ExpressRoutePort peering locations. Does not return available bandwidths for each location. Available bandwidths can only be obtained when retrieving a specific peering location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/ExpressRoutePortsLocations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePortsLocations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRoutePortsLocationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExpressRoutePortsLocationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _expressRoutePortsLocationRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _expressRoutePortsLocationRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ExpressRoutePortsLocationResource(Client, ExpressRoutePortsLocationData.DeserializeExpressRoutePortsLocationData(e)), _expressRoutePortsLocationClientDiagnostics, Pipeline, "ExpressRoutePortsLocationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieves all ExpressRoutePort peering locations. Does not return available bandwidths for each location. Available bandwidths can only be obtained when retrieving a specific peering location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/ExpressRoutePortsLocations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePortsLocations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRoutePortsLocationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExpressRoutePortsLocationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _expressRoutePortsLocationRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _expressRoutePortsLocationRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ExpressRoutePortsLocationResource(Client, ExpressRoutePortsLocationData.DeserializeExpressRoutePortsLocationData(e)), _expressRoutePortsLocationClientDiagnostics, Pipeline, "ExpressRoutePortsLocationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/ExpressRoutePortsLocations/{locationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePortsLocations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> Name of the requested ExpressRoutePort peering location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string locationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));

            using var scope = _expressRoutePortsLocationClientDiagnostics.CreateScope("ExpressRoutePortsLocationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _expressRoutePortsLocationRestClient.GetAsync(Id.SubscriptionId, locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/ExpressRoutePortsLocations/{locationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePortsLocations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> Name of the requested ExpressRoutePort peering location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        public virtual Response<bool> Exists(string locationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));

            using var scope = _expressRoutePortsLocationClientDiagnostics.CreateScope("ExpressRoutePortsLocationCollection.Exists");
            scope.Start();
            try
            {
                var response = _expressRoutePortsLocationRestClient.Get(Id.SubscriptionId, locationName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/ExpressRoutePortsLocations/{locationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePortsLocations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> Name of the requested ExpressRoutePort peering location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        public virtual async Task<NullableResponse<ExpressRoutePortsLocationResource>> GetIfExistsAsync(string locationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));

            using var scope = _expressRoutePortsLocationClientDiagnostics.CreateScope("ExpressRoutePortsLocationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _expressRoutePortsLocationRestClient.GetAsync(Id.SubscriptionId, locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ExpressRoutePortsLocationResource>(response.GetRawResponse());
                return Response.FromValue(new ExpressRoutePortsLocationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/ExpressRoutePortsLocations/{locationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePortsLocations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> Name of the requested ExpressRoutePort peering location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        public virtual NullableResponse<ExpressRoutePortsLocationResource> GetIfExists(string locationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));

            using var scope = _expressRoutePortsLocationClientDiagnostics.CreateScope("ExpressRoutePortsLocationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _expressRoutePortsLocationRestClient.Get(Id.SubscriptionId, locationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ExpressRoutePortsLocationResource>(response.GetRawResponse());
                return Response.FromValue(new ExpressRoutePortsLocationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExpressRoutePortsLocationResource> IEnumerable<ExpressRoutePortsLocationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExpressRoutePortsLocationResource> IAsyncEnumerable<ExpressRoutePortsLocationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
