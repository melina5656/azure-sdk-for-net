// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Gets the request plans with indication on each plan whether is approved by the admin, has pending request or not requested yet. </summary>
    public partial class QueryApprovalRequestResult
    {
        /// <summary> Initializes a new instance of <see cref="QueryApprovalRequestResult"/>. </summary>
        internal QueryApprovalRequestResult()
        {
            PlansDetails = new ChangeTrackingDictionary<string, PrivateStorePlanDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="QueryApprovalRequestResult"/>. </summary>
        /// <param name="uniqueOfferId"> Gets or sets unique offer id. </param>
        /// <param name="plansDetails"> Gets or sets the plans details. </param>
        /// <param name="eTag"> Gets or sets e-tag field. </param>
        /// <param name="messageCode"> Gets or sets the notification message id. </param>
        internal QueryApprovalRequestResult(string uniqueOfferId, IReadOnlyDictionary<string, PrivateStorePlanDetails> plansDetails, ETag? eTag, long? messageCode)
        {
            UniqueOfferId = uniqueOfferId;
            PlansDetails = plansDetails;
            ETag = eTag;
            MessageCode = messageCode;
        }

        /// <summary> Gets or sets unique offer id. </summary>
        public string UniqueOfferId { get; }
        /// <summary> Gets or sets the plans details. </summary>
        public IReadOnlyDictionary<string, PrivateStorePlanDetails> PlansDetails { get; }
        /// <summary> Gets or sets e-tag field. </summary>
        public ETag? ETag { get; }
        /// <summary> Gets or sets the notification message id. </summary>
        public long? MessageCode { get; }
    }
}
