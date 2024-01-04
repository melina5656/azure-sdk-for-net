// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The tracking event error info. </summary>
    public partial class IntegrationAccountTrackingEventErrorInfo
    {
        /// <summary> Initializes a new instance of <see cref="IntegrationAccountTrackingEventErrorInfo"/>. </summary>
        public IntegrationAccountTrackingEventErrorInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountTrackingEventErrorInfo"/>. </summary>
        /// <param name="message"> The message. </param>
        /// <param name="code"> The code. </param>
        internal IntegrationAccountTrackingEventErrorInfo(string message, string code)
        {
            Message = message;
            Code = code;
        }

        /// <summary> The message. </summary>
        public string Message { get; set; }
        /// <summary> The code. </summary>
        public string Code { get; set; }
    }
}
