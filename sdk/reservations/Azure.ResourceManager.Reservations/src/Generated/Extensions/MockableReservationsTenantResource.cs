// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Reservations;
using Azure.ResourceManager.Reservations.Models;

namespace Azure.ResourceManager.Reservations.Mocking
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    public partial class MockableReservationsTenantResource : ArmResource
    {
        private ClientDiagnostics _reservationDetailReservationClientDiagnostics;
        private ReservationRestOperations _reservationDetailReservationRestClient;
        private ClientDiagnostics _reservationOrderClientDiagnostics;
        private ReservationOrderRestOperations _reservationOrderRestClient;
        private ClientDiagnostics _calculateExchangeClientDiagnostics;
        private CalculateExchangeRestOperations _calculateExchangeRestClient;
        private ClientDiagnostics _exchangeClientDiagnostics;
        private ExchangeRestOperations _exchangeRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableReservationsTenantResource"/> class for mocking. </summary>
        protected MockableReservationsTenantResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableReservationsTenantResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableReservationsTenantResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ReservationDetailReservationClientDiagnostics => _reservationDetailReservationClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Reservations", ReservationDetailResource.ResourceType.Namespace, Diagnostics);
        private ReservationRestOperations ReservationDetailReservationRestClient => _reservationDetailReservationRestClient ??= new ReservationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ReservationDetailResource.ResourceType));
        private ClientDiagnostics ReservationOrderClientDiagnostics => _reservationOrderClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Reservations", ReservationOrderResource.ResourceType.Namespace, Diagnostics);
        private ReservationOrderRestOperations ReservationOrderRestClient => _reservationOrderRestClient ??= new ReservationOrderRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ReservationOrderResource.ResourceType));
        private ClientDiagnostics CalculateExchangeClientDiagnostics => _calculateExchangeClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Reservations", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private CalculateExchangeRestOperations CalculateExchangeRestClient => _calculateExchangeRestClient ??= new CalculateExchangeRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics ExchangeClientDiagnostics => _exchangeClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Reservations", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ExchangeRestOperations ExchangeRestClient => _exchangeRestClient ??= new ExchangeRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ReservationOrderResources in the TenantResource. </summary>
        /// <returns> An object representing collection of ReservationOrderResources and their operations over a ReservationOrderResource. </returns>
        public virtual ReservationOrderCollection GetReservationOrders()
        {
            return GetCachedClient(client => new ReservationOrderCollection(client, Id));
        }

        /// <summary>
        /// Get the details of the `ReservationOrder`.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationOrder_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="expand"> May be used to expand the planInformation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<ReservationOrderResource>> GetReservationOrderAsync(Guid reservationOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            return await GetReservationOrders().GetAsync(reservationOrderId, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the details of the `ReservationOrder`.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationOrder_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="expand"> May be used to expand the planInformation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<ReservationOrderResource> GetReservationOrder(Guid reservationOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetReservationOrders().Get(reservationOrderId, expand, cancellationToken);
        }

        /// <summary>
        /// List the reservations and the roll up counts of reservations group by provisioning states that the user has access to in the current tenant.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_ListAll</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ReservationDetailResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ReservationDetailResource> GetReservationDetailsAsync(TenantResourceGetReservationDetailsOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new TenantResourceGetReservationDetailsOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => ReservationDetailReservationRestClient.CreateListAllRequest(options.Filter, options.Orderby, options.RefreshSummary, options.Skiptoken, options.SelectedState, options.Take);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ReservationDetailReservationRestClient.CreateListAllNextPageRequest(nextLink, options.Filter, options.Orderby, options.RefreshSummary, options.Skiptoken, options.SelectedState, options.Take);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ReservationDetailResource(Client, ReservationDetailData.DeserializeReservationDetailData(e)), ReservationDetailReservationClientDiagnostics, Pipeline, "MockableReservationsTenantResource.GetReservationDetails", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List the reservations and the roll up counts of reservations group by provisioning states that the user has access to in the current tenant.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_ListAll</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ReservationDetailResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ReservationDetailResource> GetReservationDetails(TenantResourceGetReservationDetailsOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new TenantResourceGetReservationDetailsOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => ReservationDetailReservationRestClient.CreateListAllRequest(options.Filter, options.Orderby, options.RefreshSummary, options.Skiptoken, options.SelectedState, options.Take);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ReservationDetailReservationRestClient.CreateListAllNextPageRequest(nextLink, options.Filter, options.Orderby, options.RefreshSummary, options.Skiptoken, options.SelectedState, options.Take);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ReservationDetailResource(Client, ReservationDetailData.DeserializeReservationDetailData(e)), ReservationDetailReservationClientDiagnostics, Pipeline, "MockableReservationsTenantResource.GetReservationDetails", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Calculate price for placing a `ReservationOrder`.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/calculatePrice</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationOrder_Calculate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Information needed for calculate or purchase reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<CalculatePriceResult>> CalculateReservationOrderAsync(ReservationPurchaseContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ReservationOrderClientDiagnostics.CreateScope("MockableReservationsTenantResource.CalculateReservationOrder");
            scope.Start();
            try
            {
                var response = await ReservationOrderRestClient.CalculateAsync(content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Calculate price for placing a `ReservationOrder`.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/calculatePrice</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationOrder_Calculate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Information needed for calculate or purchase reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<CalculatePriceResult> CalculateReservationOrder(ReservationPurchaseContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ReservationOrderClientDiagnostics.CreateScope("MockableReservationsTenantResource.CalculateReservationOrder");
            scope.Start();
            try
            {
                var response = ReservationOrderRestClient.Calculate(content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Calculates price for exchanging `Reservations` if there are no policy errors.
        ///
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/calculateExchange</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CalculateExchange_Post</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Request containing purchases and refunds that need to be executed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<CalculateExchangeResult>> CalculateReservationExchangeAsync(WaitUntil waitUntil, CalculateExchangeContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = CalculateExchangeClientDiagnostics.CreateScope("MockableReservationsTenantResource.CalculateReservationExchange");
            scope.Start();
            try
            {
                var response = await CalculateExchangeRestClient.PostAsync(content, cancellationToken).ConfigureAwait(false);
                var operation = new ReservationsArmOperation<CalculateExchangeResult>(new CalculateExchangeResultOperationSource(), CalculateExchangeClientDiagnostics, Pipeline, CalculateExchangeRestClient.CreatePostRequest(content).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Calculates price for exchanging `Reservations` if there are no policy errors.
        ///
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/calculateExchange</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CalculateExchange_Post</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Request containing purchases and refunds that need to be executed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<CalculateExchangeResult> CalculateReservationExchange(WaitUntil waitUntil, CalculateExchangeContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = CalculateExchangeClientDiagnostics.CreateScope("MockableReservationsTenantResource.CalculateReservationExchange");
            scope.Start();
            try
            {
                var response = CalculateExchangeRestClient.Post(content, cancellationToken);
                var operation = new ReservationsArmOperation<CalculateExchangeResult>(new CalculateExchangeResultOperationSource(), CalculateExchangeClientDiagnostics, Pipeline, CalculateExchangeRestClient.CreatePostRequest(content).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns one or more `Reservations` in exchange for one or more `Reservation` purchases.
        ///
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/exchange</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Exchange_Post</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Request containing the refunds and purchases that need to be executed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<ExchangeResult>> ExchangeAsync(WaitUntil waitUntil, ExchangeContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ExchangeClientDiagnostics.CreateScope("MockableReservationsTenantResource.Exchange");
            scope.Start();
            try
            {
                var response = await ExchangeRestClient.PostAsync(content, cancellationToken).ConfigureAwait(false);
                var operation = new ReservationsArmOperation<ExchangeResult>(new ExchangeResultOperationSource(), ExchangeClientDiagnostics, Pipeline, ExchangeRestClient.CreatePostRequest(content).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns one or more `Reservations` in exchange for one or more `Reservation` purchases.
        ///
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/exchange</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Exchange_Post</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Request containing the refunds and purchases that need to be executed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<ExchangeResult> Exchange(WaitUntil waitUntil, ExchangeContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ExchangeClientDiagnostics.CreateScope("MockableReservationsTenantResource.Exchange");
            scope.Start();
            try
            {
                var response = ExchangeRestClient.Post(content, cancellationToken);
                var operation = new ReservationsArmOperation<ExchangeResult>(new ExchangeResultOperationSource(), ExchangeClientDiagnostics, Pipeline, ExchangeRestClient.CreatePostRequest(content).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
