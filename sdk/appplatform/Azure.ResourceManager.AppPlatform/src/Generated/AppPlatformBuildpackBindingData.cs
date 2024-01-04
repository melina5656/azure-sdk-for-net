// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppPlatform.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing the AppPlatformBuildpackBinding data model.
    /// Buildpack Binding Resource object
    /// </summary>
    public partial class AppPlatformBuildpackBindingData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="AppPlatformBuildpackBindingData"/>. </summary>
        public AppPlatformBuildpackBindingData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformBuildpackBindingData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of a buildpack binding. </param>
        internal AppPlatformBuildpackBindingData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AppPlatformBuildpackBindingProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Properties of a buildpack binding. </summary>
        public AppPlatformBuildpackBindingProperties Properties { get; set; }
    }
}
