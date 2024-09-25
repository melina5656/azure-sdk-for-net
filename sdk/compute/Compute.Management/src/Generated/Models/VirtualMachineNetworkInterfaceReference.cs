// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Compute.Management.Models
{
    /// <summary> Describes a network interface reference. </summary>
    public partial class VirtualMachineNetworkInterfaceReference : ComputeWriteableSubResourceData
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachineNetworkInterfaceReference"/>. </summary>
        public VirtualMachineNetworkInterfaceReference()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineNetworkInterfaceReference"/>. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="primary"> Specifies the primary network interface in case the virtual machine has more than 1 network interface. </param>
        /// <param name="deleteOption"> Specify what happens to the network interface when the VM is deleted. </param>
        internal VirtualMachineNetworkInterfaceReference(ResourceIdentifier id, IDictionary<string, BinaryData> serializedAdditionalRawData, bool? primary, ComputeManagementDeleteOption? deleteOption) : base(id, serializedAdditionalRawData)
        {
            Primary = primary;
            DeleteOption = deleteOption;
        }

        /// <summary> Specifies the primary network interface in case the virtual machine has more than 1 network interface. </summary>
        public bool? Primary { get; set; }
        /// <summary> Specify what happens to the network interface when the VM is deleted. </summary>
        public ComputeManagementDeleteOption? DeleteOption { get; set; }
    }
}
