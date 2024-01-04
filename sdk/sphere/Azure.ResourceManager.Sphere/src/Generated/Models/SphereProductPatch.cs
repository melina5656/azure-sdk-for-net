// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary> The type used for update operations of the Product. </summary>
    public partial class SphereProductPatch
    {
        /// <summary> Initializes a new instance of <see cref="SphereProductPatch"/>. </summary>
        public SphereProductPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SphereProductPatch"/>. </summary>
        /// <param name="description"> Description of the product. </param>
        internal SphereProductPatch(string description)
        {
            Description = description;
        }

        /// <summary> Description of the product. </summary>
        public string Description { get; set; }
    }
}
