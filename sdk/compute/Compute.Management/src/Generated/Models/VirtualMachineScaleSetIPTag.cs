// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Compute.Management.Models
{
    /// <summary> Contains the IP tag associated with the public IP address. </summary>
    public partial class VirtualMachineScaleSetIPTag
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

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetIPTag"/>. </summary>
        public VirtualMachineScaleSetIPTag()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetIPTag"/>. </summary>
        /// <param name="ipTagType"> IP tag type. Example: FirstPartyUsage. </param>
        /// <param name="tag"> IP tag associated with the public IP. Example: SQL, Storage etc. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetIPTag(string ipTagType, string tag, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IPTagType = ipTagType;
            Tag = tag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> IP tag type. Example: FirstPartyUsage. </summary>
        public string IPTagType { get; set; }
        /// <summary> IP tag associated with the public IP. Example: SQL, Storage etc. </summary>
        public string Tag { get; set; }
    }
}
