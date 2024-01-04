// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Container App container environment variable. </summary>
    public partial class ContainerAppEnvironmentVariable
    {
        /// <summary> Initializes a new instance of <see cref="ContainerAppEnvironmentVariable"/>. </summary>
        public ContainerAppEnvironmentVariable()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppEnvironmentVariable"/>. </summary>
        /// <param name="name"> Environment variable name. </param>
        /// <param name="value"> Non-secret environment variable value. </param>
        /// <param name="secretRef"> Name of the Container App secret from which to pull the environment variable value. </param>
        internal ContainerAppEnvironmentVariable(string name, string value, string secretRef)
        {
            Name = name;
            Value = value;
            SecretRef = secretRef;
        }

        /// <summary> Environment variable name. </summary>
        public string Name { get; set; }
        /// <summary> Non-secret environment variable value. </summary>
        public string Value { get; set; }
        /// <summary> Name of the Container App secret from which to pull the environment variable value. </summary>
        public string SecretRef { get; set; }
    }
}
