// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of the database's security alert policies. </summary>
    internal partial class DatabaseSecurityAlertListResult
    {
        /// <summary> Initializes a new instance of <see cref="DatabaseSecurityAlertListResult"/>. </summary>
        internal DatabaseSecurityAlertListResult()
        {
            Value = new ChangeTrackingList<SqlDatabaseSecurityAlertPolicyData>();
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseSecurityAlertListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal DatabaseSecurityAlertListResult(IReadOnlyList<SqlDatabaseSecurityAlertPolicyData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SqlDatabaseSecurityAlertPolicyData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
