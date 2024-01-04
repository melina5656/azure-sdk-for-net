// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> The current status of an async operation. </summary>
    public partial class DevCenterOperationStatus : OperationStatusResult
    {
        /// <summary> Initializes a new instance of <see cref="DevCenterOperationStatus"/>. </summary>
        /// <param name="status"> Operation status. </param>
        internal DevCenterOperationStatus(string status) : base(status)
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterOperationStatus"/>. </summary>
        /// <param name="id"> Fully qualified ID for the async operation. </param>
        /// <param name="name"> Name of the async operation. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="percentComplete"> Percent of the operation that is complete. </param>
        /// <param name="startOn"> The start time of the operation. </param>
        /// <param name="endOn"> The end time of the operation. </param>
        /// <param name="operations"> The operations list. </param>
        /// <param name="error"> If present, details of the operation error. </param>
        /// <param name="resourceId"> The id of the resource. </param>
        /// <param name="properties"> Custom operation properties, populated only for a successful operation. </param>
        internal DevCenterOperationStatus(ResourceIdentifier id, string name, string status, float? percentComplete, DateTimeOffset? startOn, DateTimeOffset? endOn, IReadOnlyList<OperationStatusResult> operations, ResponseError error, ResourceIdentifier resourceId, BinaryData properties) : base(id, name, status, percentComplete, startOn, endOn, operations, error)
        {
            ResourceId = resourceId;
            Properties = properties;
        }

        /// <summary> The id of the resource. </summary>
        public ResourceIdentifier ResourceId { get; }
        /// <summary>
        /// Custom operation properties, populated only for a successful operation.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData Properties { get; }
    }
}
