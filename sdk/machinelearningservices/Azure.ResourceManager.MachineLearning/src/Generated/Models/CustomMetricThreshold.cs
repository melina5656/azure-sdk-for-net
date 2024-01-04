// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The CustomMetricThreshold. </summary>
    public partial class CustomMetricThreshold
    {
        /// <summary> Initializes a new instance of <see cref="CustomMetricThreshold"/>. </summary>
        /// <param name="metric"> [Required] The user-defined metric to calculate. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metric"/> is null. </exception>
        public CustomMetricThreshold(string metric)
        {
            Argument.AssertNotNull(metric, nameof(metric));

            Metric = metric;
        }

        /// <summary> Initializes a new instance of <see cref="CustomMetricThreshold"/>. </summary>
        /// <param name="metric"> [Required] The user-defined metric to calculate. </param>
        /// <param name="threshold"> The threshold value. If null, a default value will be set depending on the selected metric. </param>
        internal CustomMetricThreshold(string metric, MonitoringThreshold threshold)
        {
            Metric = metric;
            Threshold = threshold;
        }

        /// <summary> [Required] The user-defined metric to calculate. </summary>
        public string Metric { get; set; }
        /// <summary> The threshold value. If null, a default value will be set depending on the selected metric. </summary>
        internal MonitoringThreshold Threshold { get; set; }
        /// <summary> The threshold value. If null, the set default is dependent on the metric type. </summary>
        public double? ThresholdValue
        {
            get => Threshold is null ? default : Threshold.Value;
            set
            {
                if (Threshold is null)
                    Threshold = new MonitoringThreshold();
                Threshold.Value = value;
            }
        }
    }
}
