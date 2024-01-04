// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> The scope and whether it is valid. </summary>
    public partial class ScopeProperties
    {
        /// <summary> Initializes a new instance of <see cref="ScopeProperties"/>. </summary>
        internal ScopeProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ScopeProperties"/>. </summary>
        /// <param name="scope"></param>
        /// <param name="isValid"></param>
        internal ScopeProperties(string scope, bool? isValid)
        {
            Scope = scope;
            IsValid = isValid;
        }

        /// <summary> Gets the scope. </summary>
        public string Scope { get; }
        /// <summary> Gets the is valid. </summary>
        public bool? IsValid { get; }
    }
}
