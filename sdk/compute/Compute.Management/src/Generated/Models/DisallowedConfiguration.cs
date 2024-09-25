// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Compute.Management.Models
{
    /// <summary> Specifies the disallowed configuration for a virtual machine image. </summary>
    internal partial class DisallowedConfiguration
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

        /// <summary> Initializes a new instance of <see cref="DisallowedConfiguration"/>. </summary>
        public DisallowedConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DisallowedConfiguration"/>. </summary>
        /// <param name="vmDiskType"> VM disk types which are disallowed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DisallowedConfiguration(VirtualMachineDiskType? vmDiskType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VmDiskType = vmDiskType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> VM disk types which are disallowed. </summary>
        public VirtualMachineDiskType? VmDiskType { get; set; }
    }
}
