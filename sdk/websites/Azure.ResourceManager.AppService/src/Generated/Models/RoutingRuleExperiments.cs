// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Routing rules in production experiments. </summary>
    internal partial class RoutingRuleExperiments
    {
        /// <summary> Initializes a new instance of <see cref="RoutingRuleExperiments"/>. </summary>
        public RoutingRuleExperiments()
        {
            RampUpRules = new ChangeTrackingList<RampUpRule>();
        }

        /// <summary> Initializes a new instance of <see cref="RoutingRuleExperiments"/>. </summary>
        /// <param name="rampUpRules"> List of ramp-up rules. </param>
        internal RoutingRuleExperiments(IList<RampUpRule> rampUpRules)
        {
            RampUpRules = rampUpRules;
        }

        /// <summary> List of ramp-up rules. </summary>
        public IList<RampUpRule> RampUpRules { get; }
    }
}
