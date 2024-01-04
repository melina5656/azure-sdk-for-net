// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Quota.Mocking;
using Azure.ResourceManager.Quota.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Quota
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Quota. </summary>
    public static partial class QuotaExtensions
    {
        private static MockableQuotaArmClient GetMockableQuotaArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableQuotaArmClient(client0));
        }

        private static MockableQuotaTenantResource GetMockableQuotaTenantResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableQuotaTenantResource(client, resource.Id));
        }

        /// <summary>
        /// Gets a collection of CurrentUsagesBaseResources in the ArmClient.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableQuotaArmClient.GetCurrentUsagesBases(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> An object representing collection of CurrentUsagesBaseResources and their operations over a CurrentUsagesBaseResource. </returns>
        public static CurrentUsagesBaseCollection GetCurrentUsagesBases(this ArmClient client, ResourceIdentifier scope)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableQuotaArmClient(client).GetCurrentUsagesBases(scope);
        }

        /// <summary>
        /// Get the current usage of a resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/usages/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableQuotaArmClient.GetCurrentUsagesBaseAsync(ResourceIdentifier,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<CurrentUsagesBaseResource>> GetCurrentUsagesBaseAsync(this ArmClient client, ResourceIdentifier scope, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));

            return await GetMockableQuotaArmClient(client).GetCurrentUsagesBaseAsync(scope, resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the current usage of a resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/usages/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableQuotaArmClient.GetCurrentUsagesBase(ResourceIdentifier,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<CurrentUsagesBaseResource> GetCurrentUsagesBase(this ArmClient client, ResourceIdentifier scope, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableQuotaArmClient(client).GetCurrentUsagesBase(scope, resourceName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of CurrentQuotaLimitBaseResources in the ArmClient.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableQuotaArmClient.GetCurrentQuotaLimitBases(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> An object representing collection of CurrentQuotaLimitBaseResources and their operations over a CurrentQuotaLimitBaseResource. </returns>
        public static CurrentQuotaLimitBaseCollection GetCurrentQuotaLimitBases(this ArmClient client, ResourceIdentifier scope)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableQuotaArmClient(client).GetCurrentQuotaLimitBases(scope);
        }

        /// <summary>
        /// Get the quota limit of a resource. The response can be used to determine the remaining quota to calculate a new quota limit that can be submitted with a PUT request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/quotas/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableQuotaArmClient.GetCurrentQuotaLimitBaseAsync(ResourceIdentifier,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<CurrentQuotaLimitBaseResource>> GetCurrentQuotaLimitBaseAsync(this ArmClient client, ResourceIdentifier scope, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));

            return await GetMockableQuotaArmClient(client).GetCurrentQuotaLimitBaseAsync(scope, resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the quota limit of a resource. The response can be used to determine the remaining quota to calculate a new quota limit that can be submitted with a PUT request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/quotas/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableQuotaArmClient.GetCurrentQuotaLimitBase(ResourceIdentifier,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<CurrentQuotaLimitBaseResource> GetCurrentQuotaLimitBase(this ArmClient client, ResourceIdentifier scope, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableQuotaArmClient(client).GetCurrentQuotaLimitBase(scope, resourceName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of QuotaRequestDetailResources in the ArmClient.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableQuotaArmClient.GetQuotaRequestDetails(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> An object representing collection of QuotaRequestDetailResources and their operations over a QuotaRequestDetailResource. </returns>
        public static QuotaRequestDetailCollection GetQuotaRequestDetails(this ArmClient client, ResourceIdentifier scope)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableQuotaArmClient(client).GetQuotaRequestDetails(scope);
        }

        /// <summary>
        /// Get the quota request details and status by quota request ID for the resources of the resource provider at a specific location. The quota request ID **id** is returned in the response of the PUT operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/quotaRequests/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaRequestStatus_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableQuotaArmClient.GetQuotaRequestDetailAsync(ResourceIdentifier,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="id"> Quota request ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> or <paramref name="id"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<QuotaRequestDetailResource>> GetQuotaRequestDetailAsync(this ArmClient client, ResourceIdentifier scope, string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));

            return await GetMockableQuotaArmClient(client).GetQuotaRequestDetailAsync(scope, id, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the quota request details and status by quota request ID for the resources of the resource provider at a specific location. The quota request ID **id** is returned in the response of the PUT operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/quotaRequests/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaRequestStatus_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableQuotaArmClient.GetQuotaRequestDetail(ResourceIdentifier,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="id"> Quota request ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> or <paramref name="id"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<QuotaRequestDetailResource> GetQuotaRequestDetail(this ArmClient client, ResourceIdentifier scope, string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableQuotaArmClient(client).GetQuotaRequestDetail(scope, id, cancellationToken);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CurrentUsagesBaseResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CurrentUsagesBaseResource.CreateResourceIdentifier" /> to create a <see cref="CurrentUsagesBaseResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableQuotaArmClient.GetCurrentUsagesBaseResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="CurrentUsagesBaseResource"/> object. </returns>
        public static CurrentUsagesBaseResource GetCurrentUsagesBaseResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableQuotaArmClient(client).GetCurrentUsagesBaseResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CurrentQuotaLimitBaseResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CurrentQuotaLimitBaseResource.CreateResourceIdentifier" /> to create a <see cref="CurrentQuotaLimitBaseResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableQuotaArmClient.GetCurrentQuotaLimitBaseResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="CurrentQuotaLimitBaseResource"/> object. </returns>
        public static CurrentQuotaLimitBaseResource GetCurrentQuotaLimitBaseResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableQuotaArmClient(client).GetCurrentQuotaLimitBaseResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="QuotaRequestDetailResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="QuotaRequestDetailResource.CreateResourceIdentifier" /> to create a <see cref="QuotaRequestDetailResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableQuotaArmClient.GetQuotaRequestDetailResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="QuotaRequestDetailResource"/> object. </returns>
        public static QuotaRequestDetailResource GetQuotaRequestDetailResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableQuotaArmClient(client).GetQuotaRequestDetailResource(id);
        }

        /// <summary>
        /// List all the operations supported by the Microsoft.Quota resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Quota/operations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaOperation_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableQuotaTenantResource.GetQuotaOperations(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="QuotaOperationResult"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<QuotaOperationResult> GetQuotaOperationsAsync(this TenantResource tenantResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return GetMockableQuotaTenantResource(tenantResource).GetQuotaOperationsAsync(cancellationToken);
        }

        /// <summary>
        /// List all the operations supported by the Microsoft.Quota resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Quota/operations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaOperation_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableQuotaTenantResource.GetQuotaOperations(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> is null. </exception>
        /// <returns> A collection of <see cref="QuotaOperationResult"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<QuotaOperationResult> GetQuotaOperations(this TenantResource tenantResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return GetMockableQuotaTenantResource(tenantResource).GetQuotaOperations(cancellationToken);
        }
    }
}
