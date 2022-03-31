// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.). </summary>
    public partial class ResponseError
    {
        /// <summary> Initializes a new instance of ResponseError. </summary>
        internal ResponseError()
        {
            Details = new ChangeTrackingList<ResponseError>();
            AdditionalInfo = new ChangeTrackingList<ErrorAdditionalInfo>();
        }

        /// <summary> Initializes a new instance of ResponseError. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="message"> The error message. </param>
        /// <param name="target"> The error target. </param>
        /// <param name="details"> The error details. </param>
        /// <param name="additionalInfo"> The error additional info. </param>
        internal ResponseError(string code, string message, string target, IReadOnlyList<ResponseError> details, IReadOnlyList<ErrorAdditionalInfo> additionalInfo)
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
            AdditionalInfo = additionalInfo;
        }

        /// <summary> The error code. </summary>
        public string Code { get; }
        /// <summary> The error message. </summary>
        public string Message { get; }
        /// <summary> The error target. </summary>
        public string Target { get; }
        /// <summary> The error details. </summary>
        public IReadOnlyList<ResponseError> Details { get; }
        /// <summary> The error additional info. </summary>
        public IReadOnlyList<ErrorAdditionalInfo> AdditionalInfo { get; }
    }
}
