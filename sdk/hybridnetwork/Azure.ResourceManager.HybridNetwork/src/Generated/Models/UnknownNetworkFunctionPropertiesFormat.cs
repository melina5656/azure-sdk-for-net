// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The UnknownNetworkFunctionPropertiesFormat. </summary>
    internal partial class UnknownNetworkFunctionPropertiesFormat : NetworkFunctionPropertiesFormat
    {
        /// <summary> Initializes a new instance of <see cref="UnknownNetworkFunctionPropertiesFormat"/>. </summary>
        /// <param name="provisioningState"> The provisioning state of the network function resource. </param>
        /// <param name="publisherName"> The publisher name for the network function. </param>
        /// <param name="publisherScope"> The scope of the publisher. </param>
        /// <param name="networkFunctionDefinitionGroupName"> The network function definition group name for the network function. </param>
        /// <param name="networkFunctionDefinitionVersion"> The network function definition version for the network function. </param>
        /// <param name="networkFunctionDefinitionOfferingLocation"> The location of the network function definition offering. </param>
        /// <param name="networkFunctionDefinitionVersionResourceReference">
        /// The network function definition version resource reference.
        /// Please note <see cref="DeploymentResourceIdReference"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="OpenDeploymentResourceReference"/> and <see cref="SecretDeploymentResourceReference"/>.
        /// </param>
        /// <param name="nfviType"> The nfvi type for the network function. </param>
        /// <param name="nfviId"> The nfviId for the network function. </param>
        /// <param name="allowSoftwareUpdate"> Indicates if software updates are allowed during deployment. </param>
        /// <param name="configurationType"> The value which indicates if NF  values are secrets. </param>
        /// <param name="roleOverrideValues"> The role configuration override values from the user. </param>
        internal UnknownNetworkFunctionPropertiesFormat(ProvisioningState? provisioningState, string publisherName, PublisherScope? publisherScope, string networkFunctionDefinitionGroupName, string networkFunctionDefinitionVersion, string networkFunctionDefinitionOfferingLocation, DeploymentResourceIdReference networkFunctionDefinitionVersionResourceReference, NfviType? nfviType, ResourceIdentifier nfviId, bool? allowSoftwareUpdate, NetworkFunctionConfigurationType configurationType, IList<string> roleOverrideValues) : base(provisioningState, publisherName, publisherScope, networkFunctionDefinitionGroupName, networkFunctionDefinitionVersion, networkFunctionDefinitionOfferingLocation, networkFunctionDefinitionVersionResourceReference, nfviType, nfviId, allowSoftwareUpdate, configurationType, roleOverrideValues)
        {
            ConfigurationType = configurationType;
        }
    }
}
