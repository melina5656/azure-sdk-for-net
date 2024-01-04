// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Firewall Policy Filter Rule Collection. </summary>
    public partial class FirewallPolicyFilterRuleCollectionInfo : FirewallPolicyRuleCollectionInfo
    {
        /// <summary> Initializes a new instance of <see cref="FirewallPolicyFilterRuleCollectionInfo"/>. </summary>
        public FirewallPolicyFilterRuleCollectionInfo()
        {
            Rules = new ChangeTrackingList<FirewallPolicyRule>();
            RuleCollectionType = FirewallPolicyRuleCollectionType.FirewallPolicyFilterRuleCollection;
        }

        /// <summary> Initializes a new instance of <see cref="FirewallPolicyFilterRuleCollectionInfo"/>. </summary>
        /// <param name="ruleCollectionType"> The type of the rule collection. </param>
        /// <param name="name"> The name of the rule collection. </param>
        /// <param name="priority"> Priority of the Firewall Policy Rule Collection resource. </param>
        /// <param name="action"> The action type of a Filter rule collection. </param>
        /// <param name="rules">
        /// List of rules included in a rule collection.
        /// Please note <see cref="FirewallPolicyRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ApplicationRule"/>, <see cref="NatRule"/> and <see cref="NetworkRule"/>.
        /// </param>
        internal FirewallPolicyFilterRuleCollectionInfo(FirewallPolicyRuleCollectionType ruleCollectionType, string name, int? priority, FirewallPolicyFilterRuleCollectionAction action, IList<FirewallPolicyRule> rules) : base(ruleCollectionType, name, priority)
        {
            Action = action;
            Rules = rules;
            RuleCollectionType = ruleCollectionType;
        }

        /// <summary> The action type of a Filter rule collection. </summary>
        internal FirewallPolicyFilterRuleCollectionAction Action { get; set; }
        /// <summary> The type of action. </summary>
        public FirewallPolicyFilterRuleCollectionActionType? ActionType
        {
            get => Action is null ? default : Action.ActionType;
            set
            {
                if (Action is null)
                    Action = new FirewallPolicyFilterRuleCollectionAction();
                Action.ActionType = value;
            }
        }

        /// <summary>
        /// List of rules included in a rule collection.
        /// Please note <see cref="FirewallPolicyRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ApplicationRule"/>, <see cref="NatRule"/> and <see cref="NetworkRule"/>.
        /// </summary>
        public IList<FirewallPolicyRule> Rules { get; }
    }
}
