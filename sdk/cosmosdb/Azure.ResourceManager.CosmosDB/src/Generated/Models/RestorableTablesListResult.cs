// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The List operation response, that contains the Table events and their properties. </summary>
    internal partial class RestorableTablesListResult
    {
        /// <summary> Initializes a new instance of <see cref="RestorableTablesListResult"/>. </summary>
        internal RestorableTablesListResult()
        {
            Value = new ChangeTrackingList<RestorableTable>();
        }

        /// <summary> Initializes a new instance of <see cref="RestorableTablesListResult"/>. </summary>
        /// <param name="value"> List of Table events and their properties. </param>
        internal RestorableTablesListResult(IReadOnlyList<RestorableTable> value)
        {
            Value = value;
        }

        /// <summary> List of Table events and their properties. </summary>
        public IReadOnlyList<RestorableTable> Value { get; }
    }
}
