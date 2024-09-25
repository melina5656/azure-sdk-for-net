// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Disk.Management.Models
{
    /// <summary> Data used for requesting a SAS. </summary>
    public partial class GrantAccessData
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

        /// <summary> Initializes a new instance of <see cref="GrantAccessData"/>. </summary>
        /// <param name="access"> The Access Level, accepted values include None, Read, Write. </param>
        /// <param name="durationInSeconds"> Time duration in seconds until the SAS access expires. </param>
        public GrantAccessData(AccessLevel access, int durationInSeconds)
        {
            Access = access;
            DurationInSeconds = durationInSeconds;
        }

        /// <summary> Initializes a new instance of <see cref="GrantAccessData"/>. </summary>
        /// <param name="access"> The Access Level, accepted values include None, Read, Write. </param>
        /// <param name="durationInSeconds"> Time duration in seconds until the SAS access expires. </param>
        /// <param name="getSecureVmGuestStateSas"> Set this flag to true to get additional SAS for VM guest state. </param>
        /// <param name="fileFormat"> Used to specify the file format when making request for SAS on a VHDX file format snapshot. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GrantAccessData(AccessLevel access, int durationInSeconds, bool? getSecureVmGuestStateSas, DiskImageFileFormat? fileFormat, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Access = access;
            DurationInSeconds = durationInSeconds;
            GetSecureVmGuestStateSas = getSecureVmGuestStateSas;
            FileFormat = fileFormat;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GrantAccessData"/> for deserialization. </summary>
        internal GrantAccessData()
        {
        }

        /// <summary> The Access Level, accepted values include None, Read, Write. </summary>
        public AccessLevel Access { get; }
        /// <summary> Time duration in seconds until the SAS access expires. </summary>
        public int DurationInSeconds { get; }
        /// <summary> Set this flag to true to get additional SAS for VM guest state. </summary>
        public bool? GetSecureVmGuestStateSas { get; set; }
        /// <summary> Used to specify the file format when making request for SAS on a VHDX file format snapshot. </summary>
        public DiskImageFileFormat? FileFormat { get; set; }
    }
}
