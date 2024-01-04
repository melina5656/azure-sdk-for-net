// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.BillingBenefits;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    /// <summary> The SavingsPlanModelListResult. </summary>
    internal partial class SavingsPlanModelListResult
    {
        /// <summary> Initializes a new instance of <see cref="SavingsPlanModelListResult"/>. </summary>
        internal SavingsPlanModelListResult()
        {
            Value = new ChangeTrackingList<BillingBenefitsSavingsPlanData>();
            AdditionalProperties = new ChangeTrackingList<SavingsPlanSummary>();
        }

        /// <summary> Initializes a new instance of <see cref="SavingsPlanModelListResult"/>. </summary>
        /// <param name="value"> The list of savings plans. </param>
        /// <param name="nextLink"> Url to get the next page. </param>
        /// <param name="additionalProperties"> The roll out count summary of the savings plans. </param>
        internal SavingsPlanModelListResult(IReadOnlyList<BillingBenefitsSavingsPlanData> value, string nextLink, IReadOnlyList<SavingsPlanSummary> additionalProperties)
        {
            Value = value;
            NextLink = nextLink;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The list of savings plans. </summary>
        public IReadOnlyList<BillingBenefitsSavingsPlanData> Value { get; }
        /// <summary> Url to get the next page. </summary>
        public string NextLink { get; }
        /// <summary> The roll out count summary of the savings plans. </summary>
        public IReadOnlyList<SavingsPlanSummary> AdditionalProperties { get; }
    }
}
