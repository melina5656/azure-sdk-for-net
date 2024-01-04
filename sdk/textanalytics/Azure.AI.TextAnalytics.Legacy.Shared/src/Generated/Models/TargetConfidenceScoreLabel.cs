// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> Represents the confidence scores across all sentiment classes: positive, neutral, negative. </summary>
    internal partial class TargetConfidenceScoreLabel
    {
        /// <summary> Initializes a new instance of <see cref="TargetConfidenceScoreLabel"/>. </summary>
        /// <param name="positive"></param>
        /// <param name="negative"></param>
        internal TargetConfidenceScoreLabel(double positive, double negative)
        {
            Positive = positive;
            Negative = negative;
        }

        /// <summary> Gets the positive. </summary>
        public double Positive { get; }
        /// <summary> Gets the negative. </summary>
        public double Negative { get; }
    }
}
