// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Compute.Management.Models
{
    /// <summary> Describes a virtual machines scale sets network configuration's DNS settings. </summary>
    public partial class VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings"/>. </summary>
        /// <param name="domainNameLabel"> The Domain name label.The concatenation of the domain name label and vm index will be the domain name labels of the PublicIPAddress resources that will be created. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainNameLabel"/> is null. </exception>
        public VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings(string domainNameLabel)
        {
            Argument.AssertNotNull(domainNameLabel, nameof(domainNameLabel));

            DomainNameLabel = domainNameLabel;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings"/>. </summary>
        /// <param name="domainNameLabel"> The Domain name label.The concatenation of the domain name label and vm index will be the domain name labels of the PublicIPAddress resources that will be created. </param>
        /// <param name="domainNameLabelScope"> The Domain name label scope.The concatenation of the hashed domain name label that generated according to the policy from domain name label scope and vm index will be the domain name labels of the PublicIPAddress resources that will be created. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings(string domainNameLabel, DomainNameLabelScopeType? domainNameLabelScope, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DomainNameLabel = domainNameLabel;
            DomainNameLabelScope = domainNameLabelScope;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings"/> for deserialization. </summary>
        internal VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings()
        {
        }

        /// <summary> The Domain name label.The concatenation of the domain name label and vm index will be the domain name labels of the PublicIPAddress resources that will be created. </summary>
        public string DomainNameLabel { get; set; }
        /// <summary> The Domain name label scope.The concatenation of the hashed domain name label that generated according to the policy from domain name label scope and vm index will be the domain name labels of the PublicIPAddress resources that will be created. </summary>
        public DomainNameLabelScopeType? DomainNameLabelScope { get; set; }
    }
}
