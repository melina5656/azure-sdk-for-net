// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Compute.Management.Models
{
    /// <summary> Describes a virtual machines scale set IP Configuration's PublicIPAddress configuration. </summary>
    public partial class VirtualMachineScaleSetPublicIPAddressConfiguration
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

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetPublicIPAddressConfiguration"/>. </summary>
        /// <param name="name"> The publicIP address configuration name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public VirtualMachineScaleSetPublicIPAddressConfiguration(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            IPTags = new ChangeTrackingList<VirtualMachineScaleSetIPTag>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetPublicIPAddressConfiguration"/>. </summary>
        /// <param name="name"> The publicIP address configuration name. </param>
        /// <param name="sku"> Describes the public IP Sku. It can only be set with OrchestrationMode as Flexible. </param>
        /// <param name="idleTimeoutInMinutes"> The idle timeout of the public IP address. </param>
        /// <param name="dnsSettings"> The dns settings to be applied on the publicIP addresses . </param>
        /// <param name="ipTags"> The list of IP tags associated with the public IP address. </param>
        /// <param name="publicIPPrefix"> The PublicIPPrefix from which to allocate publicIP addresses. </param>
        /// <param name="publicIPAddressVersion"> Available from Api-Version 2019-07-01 onwards, it represents whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible values are: 'IPv4' and 'IPv6'. </param>
        /// <param name="deleteOption"> Specify what happens to the public IP when the VM is deleted. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetPublicIPAddressConfiguration(string name, ComputeManagementPublicIPAddressSku sku, int? idleTimeoutInMinutes, VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings dnsSettings, IList<VirtualMachineScaleSetIPTag> ipTags, WritableSubResource publicIPPrefix, IPVersion? publicIPAddressVersion, ComputeManagementDeleteOption? deleteOption, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Sku = sku;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            DnsSettings = dnsSettings;
            IPTags = ipTags;
            PublicIPPrefix = publicIPPrefix;
            PublicIPAddressVersion = publicIPAddressVersion;
            DeleteOption = deleteOption;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetPublicIPAddressConfiguration"/> for deserialization. </summary>
        internal VirtualMachineScaleSetPublicIPAddressConfiguration()
        {
        }

        /// <summary> The publicIP address configuration name. </summary>
        public string Name { get; set; }
        /// <summary> Describes the public IP Sku. It can only be set with OrchestrationMode as Flexible. </summary>
        public ComputeManagementPublicIPAddressSku Sku { get; set; }
        /// <summary> The idle timeout of the public IP address. </summary>
        public int? IdleTimeoutInMinutes { get; set; }
        /// <summary> The dns settings to be applied on the publicIP addresses . </summary>
        public VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings DnsSettings { get; set; }
        /// <summary> The list of IP tags associated with the public IP address. </summary>
        public IList<VirtualMachineScaleSetIPTag> IPTags { get; }
        /// <summary> The PublicIPPrefix from which to allocate publicIP addresses. </summary>
        internal WritableSubResource PublicIPPrefix { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PublicIPPrefixId
        {
            get => PublicIPPrefix is null ? default : PublicIPPrefix.Id;
            set
            {
                if (PublicIPPrefix is null)
                    PublicIPPrefix = new WritableSubResource();
                PublicIPPrefix.Id = value;
            }
        }

        /// <summary> Available from Api-Version 2019-07-01 onwards, it represents whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible values are: 'IPv4' and 'IPv6'. </summary>
        public IPVersion? PublicIPAddressVersion { get; set; }
        /// <summary> Specify what happens to the public IP when the VM is deleted. </summary>
        public ComputeManagementDeleteOption? DeleteOption { get; set; }
    }
}
