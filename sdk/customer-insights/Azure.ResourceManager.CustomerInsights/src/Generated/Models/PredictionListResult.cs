// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The response of list predictions operation. </summary>
    internal partial class PredictionListResult
    {
        /// <summary> Initializes a new instance of <see cref="PredictionListResult"/>. </summary>
        internal PredictionListResult()
        {
            Value = new ChangeTrackingList<PredictionResourceFormatData>();
        }

        /// <summary> Initializes a new instance of <see cref="PredictionListResult"/>. </summary>
        /// <param name="value"> Results of the list operation. </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        internal PredictionListResult(IReadOnlyList<PredictionResourceFormatData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Results of the list operation. </summary>
        public IReadOnlyList<PredictionResourceFormatData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}
