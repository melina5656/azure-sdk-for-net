// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Authorization;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Role definition list operation result. </summary>
    internal partial class RoleDefinitionListResult
    {
        /// <summary> Initializes a new instance of <see cref="RoleDefinitionListResult"/>. </summary>
        internal RoleDefinitionListResult()
        {
            Value = new ChangeTrackingList<AuthorizationRoleDefinitionData>();
        }

        /// <summary> Initializes a new instance of <see cref="RoleDefinitionListResult"/>. </summary>
        /// <param name="value"> Role definition list. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal RoleDefinitionListResult(IReadOnlyList<AuthorizationRoleDefinitionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Role definition list. </summary>
        public IReadOnlyList<AuthorizationRoleDefinitionData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
