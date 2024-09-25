// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Compute.Management.Models
{
    /// <summary> Describes Compute Resource Usage. </summary>
    public partial class ComputeManagementUsage
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

        /// <summary> Initializes a new instance of <see cref="ComputeManagementUsage"/>. </summary>
        /// <param name="currentValue"> The current usage of the resource. </param>
        /// <param name="limit"> The maximum permitted usage of the resource. </param>
        /// <param name="name"> The name of the type of usage. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal ComputeManagementUsage(int currentValue, long limit, ComputeManagementUsageName name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Unit = ComputeManagementUsageUnit.Count;
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="ComputeManagementUsage"/>. </summary>
        /// <param name="unit"> An enum describing the unit of usage measurement. </param>
        /// <param name="currentValue"> The current usage of the resource. </param>
        /// <param name="limit"> The maximum permitted usage of the resource. </param>
        /// <param name="name"> The name of the type of usage. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComputeManagementUsage(ComputeManagementUsageUnit unit, int currentValue, long limit, ComputeManagementUsageName name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ComputeManagementUsage"/> for deserialization. </summary>
        internal ComputeManagementUsage()
        {
        }

        /// <summary> An enum describing the unit of usage measurement. </summary>
        public ComputeManagementUsageUnit Unit { get; }
        /// <summary> The current usage of the resource. </summary>
        public int CurrentValue { get; }
        /// <summary> The maximum permitted usage of the resource. </summary>
        public long Limit { get; }
        /// <summary> The name of the type of usage. </summary>
        public ComputeManagementUsageName Name { get; }
    }
}
