// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Compute.Management.Models
{
    /// <summary> Describes a virtual machine scale set extension profile. </summary>
    public partial class VirtualMachineScaleSetExtensionProfile
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

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetExtensionProfile"/>. </summary>
        public VirtualMachineScaleSetExtensionProfile()
        {
            Extensions = new ChangeTrackingList<VirtualMachineScaleSetExtensionData>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetExtensionProfile"/>. </summary>
        /// <param name="extensions"> The virtual machine scale set child extension resources. </param>
        /// <param name="extensionsTimeBudget"> Specifies the time alloted for all extensions to start. The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. The default value is 90 minutes (PT1H30M). Minimum api-version: 2020-06-01. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetExtensionProfile(IList<VirtualMachineScaleSetExtensionData> extensions, string extensionsTimeBudget, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Extensions = extensions;
            ExtensionsTimeBudget = extensionsTimeBudget;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The virtual machine scale set child extension resources. </summary>
        public IList<VirtualMachineScaleSetExtensionData> Extensions { get; }
        /// <summary> Specifies the time alloted for all extensions to start. The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. The default value is 90 minutes (PT1H30M). Minimum api-version: 2020-06-01. </summary>
        public string ExtensionsTimeBudget { get; set; }
    }
}
