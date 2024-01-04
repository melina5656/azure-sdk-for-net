// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Inbound NAT pool of the load balancer. </summary>
    public partial class LoadBalancerInboundNatPool : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="LoadBalancerInboundNatPool"/>. </summary>
        public LoadBalancerInboundNatPool()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LoadBalancerInboundNatPool"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="frontendIPConfiguration"> A reference to frontend IP addresses. </param>
        /// <param name="protocol"> The reference to the transport protocol used by the inbound NAT pool. </param>
        /// <param name="frontendPortRangeStart"> The first port number in the range of external ports that will be used to provide Inbound Nat to NICs associated with a load balancer. Acceptable values range between 1 and 65534. </param>
        /// <param name="frontendPortRangeEnd"> The last port number in the range of external ports that will be used to provide Inbound Nat to NICs associated with a load balancer. Acceptable values range between 1 and 65535. </param>
        /// <param name="backendPort"> The port used for internal connections on the endpoint. Acceptable values are between 1 and 65535. </param>
        /// <param name="idleTimeoutInMinutes"> The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP. </param>
        /// <param name="enableFloatingIP"> Configures a virtual machine's endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can't be changed after you create the endpoint. </param>
        /// <param name="enableTcpReset"> Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP. </param>
        /// <param name="provisioningState"> The provisioning state of the inbound NAT pool resource. </param>
        internal LoadBalancerInboundNatPool(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, WritableSubResource frontendIPConfiguration, LoadBalancingTransportProtocol? protocol, int? frontendPortRangeStart, int? frontendPortRangeEnd, int? backendPort, int? idleTimeoutInMinutes, bool? enableFloatingIP, bool? enableTcpReset, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            ETag = etag;
            FrontendIPConfiguration = frontendIPConfiguration;
            Protocol = protocol;
            FrontendPortRangeStart = frontendPortRangeStart;
            FrontendPortRangeEnd = frontendPortRangeEnd;
            BackendPort = backendPort;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            EnableFloatingIP = enableFloatingIP;
            EnableTcpReset = enableTcpReset;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> A reference to frontend IP addresses. </summary>
        internal WritableSubResource FrontendIPConfiguration { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier FrontendIPConfigurationId
        {
            get => FrontendIPConfiguration is null ? default : FrontendIPConfiguration.Id;
            set
            {
                if (FrontendIPConfiguration is null)
                    FrontendIPConfiguration = new WritableSubResource();
                FrontendIPConfiguration.Id = value;
            }
        }

        /// <summary> The reference to the transport protocol used by the inbound NAT pool. </summary>
        public LoadBalancingTransportProtocol? Protocol { get; set; }
        /// <summary> The first port number in the range of external ports that will be used to provide Inbound Nat to NICs associated with a load balancer. Acceptable values range between 1 and 65534. </summary>
        public int? FrontendPortRangeStart { get; set; }
        /// <summary> The last port number in the range of external ports that will be used to provide Inbound Nat to NICs associated with a load balancer. Acceptable values range between 1 and 65535. </summary>
        public int? FrontendPortRangeEnd { get; set; }
        /// <summary> The port used for internal connections on the endpoint. Acceptable values are between 1 and 65535. </summary>
        public int? BackendPort { get; set; }
        /// <summary> The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP. </summary>
        public int? IdleTimeoutInMinutes { get; set; }
        /// <summary> Configures a virtual machine's endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can't be changed after you create the endpoint. </summary>
        public bool? EnableFloatingIP { get; set; }
        /// <summary> Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP. </summary>
        public bool? EnableTcpReset { get; set; }
        /// <summary> The provisioning state of the inbound NAT pool resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
