// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the SqlAgentConfiguration data model.
    /// A recoverable managed database resource.
    /// </summary>
    public partial class SqlAgentConfigurationData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="SqlAgentConfigurationData"/>. </summary>
        public SqlAgentConfigurationData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlAgentConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="state"> The state of Sql Agent. </param>
        internal SqlAgentConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SqlAgentConfigurationPropertiesState? state) : base(id, name, resourceType, systemData)
        {
            State = state;
        }

        /// <summary> The state of Sql Agent. </summary>
        public SqlAgentConfigurationPropertiesState? State { get; set; }
    }
}
