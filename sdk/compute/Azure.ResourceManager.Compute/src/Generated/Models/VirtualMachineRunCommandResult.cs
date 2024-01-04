// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The VirtualMachineRunCommandResult. </summary>
    public partial class VirtualMachineRunCommandResult
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachineRunCommandResult"/>. </summary>
        internal VirtualMachineRunCommandResult()
        {
            Value = new ChangeTrackingList<InstanceViewStatus>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineRunCommandResult"/>. </summary>
        /// <param name="value"> Run command operation response. </param>
        internal VirtualMachineRunCommandResult(IReadOnlyList<InstanceViewStatus> value)
        {
            Value = value;
        }

        /// <summary> Run command operation response. </summary>
        public IReadOnlyList<InstanceViewStatus> Value { get; }
    }
}
