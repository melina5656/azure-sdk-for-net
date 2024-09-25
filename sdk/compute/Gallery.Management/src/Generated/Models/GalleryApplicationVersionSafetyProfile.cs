// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace AzureResourceManagerGallery.Models
{
    /// <summary> The safety profile of the Gallery Application Version. </summary>
    internal partial class GalleryApplicationVersionSafetyProfile : GalleryArtifactSafetyProfileBase
    {
        /// <summary> Initializes a new instance of <see cref="GalleryApplicationVersionSafetyProfile"/>. </summary>
        public GalleryApplicationVersionSafetyProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GalleryApplicationVersionSafetyProfile"/>. </summary>
        /// <param name="allowDeletionOfReplicatedLocations"> Indicates whether or not removing this Gallery Image Version from replicated regions is allowed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GalleryApplicationVersionSafetyProfile(bool? allowDeletionOfReplicatedLocations, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(allowDeletionOfReplicatedLocations, serializedAdditionalRawData)
        {
        }
    }
}
