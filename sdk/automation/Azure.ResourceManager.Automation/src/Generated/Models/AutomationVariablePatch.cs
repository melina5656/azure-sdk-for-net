// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the update variable operation. </summary>
    public partial class AutomationVariablePatch
    {
        /// <summary> Initializes a new instance of <see cref="AutomationVariablePatch"/>. </summary>
        public AutomationVariablePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutomationVariablePatch"/>. </summary>
        /// <param name="name"> Gets or sets the name of the variable. </param>
        /// <param name="value"> Gets or sets the value of the variable. </param>
        /// <param name="description"> Gets or sets the description of the variable. </param>
        internal AutomationVariablePatch(string name, string value, string description)
        {
            Name = name;
            Value = value;
            Description = description;
        }

        /// <summary> Gets or sets the name of the variable. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the value of the variable. </summary>
        public string Value { get; set; }
        /// <summary> Gets or sets the description of the variable. </summary>
        public string Description { get; set; }
    }
}
