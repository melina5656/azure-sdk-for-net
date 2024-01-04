// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Represents a collection of alert rule resources. </summary>
    internal partial class AlertRuleResourceCollection
    {
        /// <summary> Initializes a new instance of <see cref="AlertRuleResourceCollection"/>. </summary>
        internal AlertRuleResourceCollection()
        {
            Value = new ChangeTrackingList<AlertRuleData>();
        }

        /// <summary> Initializes a new instance of <see cref="AlertRuleResourceCollection"/>. </summary>
        /// <param name="value"> the values for the alert rule resources. </param>
        internal AlertRuleResourceCollection(IReadOnlyList<AlertRuleData> value)
        {
            Value = value;
        }

        /// <summary> the values for the alert rule resources. </summary>
        public IReadOnlyList<AlertRuleData> Value { get; }
    }
}
