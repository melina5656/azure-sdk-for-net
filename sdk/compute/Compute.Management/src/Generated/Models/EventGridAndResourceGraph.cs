// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Compute.Management.Models
{
    /// <summary> Specifies eventGridAndResourceGraph related Scheduled Event related configurations. </summary>
    internal partial class EventGridAndResourceGraph
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

        /// <summary> Initializes a new instance of <see cref="EventGridAndResourceGraph"/>. </summary>
        public EventGridAndResourceGraph()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EventGridAndResourceGraph"/>. </summary>
        /// <param name="enable"> Specifies if event grid and resource graph is enabled for Scheduled event related configurations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EventGridAndResourceGraph(bool? enable, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Enable = enable;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies if event grid and resource graph is enabled for Scheduled event related configurations. </summary>
        public bool? Enable { get; set; }
    }
}
