// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Vpn Client Connection configuration PolicyGroup member. </summary>
    public partial class VirtualNetworkGatewayPolicyGroupMember
    {
        /// <summary> Initializes a new instance of <see cref="VirtualNetworkGatewayPolicyGroupMember"/>. </summary>
        public VirtualNetworkGatewayPolicyGroupMember()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkGatewayPolicyGroupMember"/>. </summary>
        /// <param name="name"> Name of the VirtualNetworkGatewayPolicyGroupMember. </param>
        /// <param name="attributeType"> The Vpn Policy member attribute type. </param>
        /// <param name="attributeValue"> The value of Attribute used for this VirtualNetworkGatewayPolicyGroupMember. </param>
        internal VirtualNetworkGatewayPolicyGroupMember(string name, VpnPolicyMemberAttributeType? attributeType, string attributeValue)
        {
            Name = name;
            AttributeType = attributeType;
            AttributeValue = attributeValue;
        }

        /// <summary> Name of the VirtualNetworkGatewayPolicyGroupMember. </summary>
        public string Name { get; set; }
        /// <summary> The Vpn Policy member attribute type. </summary>
        public VpnPolicyMemberAttributeType? AttributeType { get; set; }
        /// <summary> The value of Attribute used for this VirtualNetworkGatewayPolicyGroupMember. </summary>
        public string AttributeValue { get; set; }
    }
}
