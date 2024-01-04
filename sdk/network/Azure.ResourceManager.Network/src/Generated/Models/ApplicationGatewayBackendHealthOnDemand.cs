// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Result of on demand test probe. </summary>
    public partial class ApplicationGatewayBackendHealthOnDemand
    {
        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayBackendHealthOnDemand"/>. </summary>
        internal ApplicationGatewayBackendHealthOnDemand()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayBackendHealthOnDemand"/>. </summary>
        /// <param name="backendAddressPool"> Reference to an ApplicationGatewayBackendAddressPool resource. </param>
        /// <param name="backendHealthHttpSettings"> Application gateway BackendHealthHttp settings. </param>
        internal ApplicationGatewayBackendHealthOnDemand(ApplicationGatewayBackendAddressPool backendAddressPool, ApplicationGatewayBackendHealthHttpSettings backendHealthHttpSettings)
        {
            BackendAddressPool = backendAddressPool;
            BackendHealthHttpSettings = backendHealthHttpSettings;
        }

        /// <summary> Reference to an ApplicationGatewayBackendAddressPool resource. </summary>
        public ApplicationGatewayBackendAddressPool BackendAddressPool { get; }
        /// <summary> Application gateway BackendHealthHttp settings. </summary>
        public ApplicationGatewayBackendHealthHttpSettings BackendHealthHttpSettings { get; }
    }
}
