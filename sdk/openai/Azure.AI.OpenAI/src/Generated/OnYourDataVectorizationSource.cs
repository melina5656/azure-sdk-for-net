// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// An abstract representation of a vectorization source for Azure OpenAI On Your Data with vector search.
    /// Please note <see cref="OnYourDataVectorizationSource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="OnYourDataEndpointVectorizationSource"/>, <see cref="OnYourDataDeploymentNameVectorizationSource"/> and <see cref="OnYourDataModelIdVectorizationSource"/>.
    /// </summary>
    public abstract partial class OnYourDataVectorizationSource
    {
        /// <summary> Initializes a new instance of <see cref="OnYourDataVectorizationSource"/>. </summary>
        protected OnYourDataVectorizationSource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OnYourDataVectorizationSource"/>. </summary>
        /// <param name="type"> The type of vectorization source to use. </param>
        internal OnYourDataVectorizationSource(OnYourDataVectorizationSourceType type)
        {
            Type = type;
        }

        /// <summary> The type of vectorization source to use. </summary>
        internal OnYourDataVectorizationSourceType Type { get; set; }
    }
}
