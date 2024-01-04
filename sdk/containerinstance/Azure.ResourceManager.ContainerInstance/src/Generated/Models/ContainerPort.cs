// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The port exposed on the container instance. </summary>
    public partial class ContainerPort
    {
        /// <summary> Initializes a new instance of <see cref="ContainerPort"/>. </summary>
        /// <param name="port"> The port number exposed within the container group. </param>
        public ContainerPort(int port)
        {
            Port = port;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerPort"/>. </summary>
        /// <param name="protocol"> The protocol associated with the port. </param>
        /// <param name="port"> The port number exposed within the container group. </param>
        internal ContainerPort(ContainerNetworkProtocol? protocol, int port)
        {
            Protocol = protocol;
            Port = port;
        }

        /// <summary> The protocol associated with the port. </summary>
        public ContainerNetworkProtocol? Protocol { get; set; }
        /// <summary> The port number exposed within the container group. </summary>
        public int Port { get; set; }
    }
}
