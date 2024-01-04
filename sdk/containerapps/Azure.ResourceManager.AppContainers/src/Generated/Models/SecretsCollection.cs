// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Container App Secrets Collection ARM resource. </summary>
    internal partial class SecretsCollection
    {
        /// <summary> Initializes a new instance of <see cref="SecretsCollection"/>. </summary>
        /// <param name="value"> Collection of resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SecretsCollection(IEnumerable<ContainerAppSecret> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SecretsCollection"/>. </summary>
        /// <param name="value"> Collection of resources. </param>
        internal SecretsCollection(IReadOnlyList<ContainerAppSecret> value)
        {
            Value = value;
        }

        /// <summary> Collection of resources. </summary>
        public IReadOnlyList<ContainerAppSecret> Value { get; }
    }
}
