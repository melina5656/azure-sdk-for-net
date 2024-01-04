// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> An Azure Blob Storage data source/sink. </summary>
    public partial class AzureBlobDataTransferDataSourceSink : DataTransferDataSourceSink
    {
        /// <summary> Initializes a new instance of <see cref="AzureBlobDataTransferDataSourceSink"/>. </summary>
        /// <param name="containerName"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public AzureBlobDataTransferDataSourceSink(string containerName)
        {
            Argument.AssertNotNull(containerName, nameof(containerName));

            ContainerName = containerName;
            Component = DataTransferComponent.AzureBlobStorage;
        }

        /// <summary> Initializes a new instance of <see cref="AzureBlobDataTransferDataSourceSink"/>. </summary>
        /// <param name="component"></param>
        /// <param name="containerName"></param>
        /// <param name="endpointUri"></param>
        internal AzureBlobDataTransferDataSourceSink(DataTransferComponent component, string containerName, Uri endpointUri) : base(component)
        {
            ContainerName = containerName;
            EndpointUri = endpointUri;
            Component = component;
        }

        /// <summary> Gets or sets the container name. </summary>
        public string ContainerName { get; set; }
        /// <summary> Gets or sets the endpoint uri. </summary>
        public Uri EndpointUri { get; set; }
    }
}
