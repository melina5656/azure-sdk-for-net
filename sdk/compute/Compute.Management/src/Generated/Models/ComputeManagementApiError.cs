// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Compute.Management.Models
{
    /// <summary> Api error. </summary>
    public partial class ComputeManagementApiError
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

        /// <summary> Initializes a new instance of <see cref="ComputeManagementApiError"/>. </summary>
        internal ComputeManagementApiError()
        {
            Details = new ChangeTrackingList<ComputeManagementApiErrorBase>();
        }

        /// <summary> Initializes a new instance of <see cref="ComputeManagementApiError"/>. </summary>
        /// <param name="details"> The Api error details. </param>
        /// <param name="innererror"> The Api inner error. </param>
        /// <param name="code"> The error code. </param>
        /// <param name="target"> The target of the particular error. </param>
        /// <param name="message"> The error message. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComputeManagementApiError(IReadOnlyList<ComputeManagementApiErrorBase> details, InnerError innererror, string code, string target, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Details = details;
            Innererror = innererror;
            Code = code;
            Target = target;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Api error details. </summary>
        public IReadOnlyList<ComputeManagementApiErrorBase> Details { get; }
        /// <summary> The Api inner error. </summary>
        public InnerError Innererror { get; }
        /// <summary> The error code. </summary>
        public string Code { get; }
        /// <summary> The target of the particular error. </summary>
        public string Target { get; }
        /// <summary> The error message. </summary>
        public string Message { get; }
    }
}
