// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Kubernetes.Models
{
    /// <summary> The ListClusterUserCredentialProperties. </summary>
    public partial class ListClusterUserCredentialProperties
    {
        /// <summary> Initializes a new instance of <see cref="ListClusterUserCredentialProperties"/>. </summary>
        /// <param name="authenticationMethod"> The mode of client authentication. </param>
        /// <param name="clientProxy"> Boolean value to indicate whether the request is for client side proxy or not. </param>
        public ListClusterUserCredentialProperties(AuthenticationMethod authenticationMethod, bool clientProxy)
        {
            AuthenticationMethod = authenticationMethod;
            ClientProxy = clientProxy;
        }

        /// <summary> The mode of client authentication. </summary>
        public AuthenticationMethod AuthenticationMethod { get; }
        /// <summary> Boolean value to indicate whether the request is for client side proxy or not. </summary>
        public bool ClientProxy { get; }
    }
}
