// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Routing Configuration indicating the associated and propagated route tables for this connection. </summary>
    public partial class RoutingConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="RoutingConfiguration"/>. </summary>
        public RoutingConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RoutingConfiguration"/>. </summary>
        /// <param name="associatedRouteTable"> The resource id RouteTable associated with this RoutingConfiguration. </param>
        /// <param name="propagatedRouteTables"> The list of RouteTables to advertise the routes to. </param>
        /// <param name="vnetRoutes"> List of routes that control routing from VirtualHub into a virtual network connection. </param>
        /// <param name="inboundRouteMap"> The resource id of the RouteMap associated with this RoutingConfiguration for inbound learned routes. </param>
        /// <param name="outboundRouteMap"> The resource id of theRouteMap associated with this RoutingConfiguration for outbound advertised routes. </param>
        internal RoutingConfiguration(WritableSubResource associatedRouteTable, PropagatedRouteTable propagatedRouteTables, VnetRoute vnetRoutes, WritableSubResource inboundRouteMap, WritableSubResource outboundRouteMap)
        {
            AssociatedRouteTable = associatedRouteTable;
            PropagatedRouteTables = propagatedRouteTables;
            VnetRoutes = vnetRoutes;
            InboundRouteMap = inboundRouteMap;
            OutboundRouteMap = outboundRouteMap;
        }

        /// <summary> The resource id RouteTable associated with this RoutingConfiguration. </summary>
        internal WritableSubResource AssociatedRouteTable { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier AssociatedRouteTableId
        {
            get => AssociatedRouteTable is null ? default : AssociatedRouteTable.Id;
            set
            {
                if (AssociatedRouteTable is null)
                    AssociatedRouteTable = new WritableSubResource();
                AssociatedRouteTable.Id = value;
            }
        }

        /// <summary> The list of RouteTables to advertise the routes to. </summary>
        public PropagatedRouteTable PropagatedRouteTables { get; set; }
        /// <summary> List of routes that control routing from VirtualHub into a virtual network connection. </summary>
        public VnetRoute VnetRoutes { get; set; }
        /// <summary> The resource id of the RouteMap associated with this RoutingConfiguration for inbound learned routes. </summary>
        internal WritableSubResource InboundRouteMap { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier InboundRouteMapId
        {
            get => InboundRouteMap is null ? default : InboundRouteMap.Id;
            set
            {
                if (InboundRouteMap is null)
                    InboundRouteMap = new WritableSubResource();
                InboundRouteMap.Id = value;
            }
        }

        /// <summary> The resource id of theRouteMap associated with this RoutingConfiguration for outbound advertised routes. </summary>
        internal WritableSubResource OutboundRouteMap { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier OutboundRouteMapId
        {
            get => OutboundRouteMap is null ? default : OutboundRouteMap.Id;
            set
            {
                if (OutboundRouteMap is null)
                    OutboundRouteMap = new WritableSubResource();
                OutboundRouteMap.Id = value;
            }
        }
    }
}
