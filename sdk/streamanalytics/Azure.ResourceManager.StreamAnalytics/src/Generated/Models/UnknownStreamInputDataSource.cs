// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The UnknownStreamInputDataSource. </summary>
    internal partial class UnknownStreamInputDataSource : StreamInputDataSource
    {
        /// <summary> Initializes a new instance of <see cref="UnknownStreamInputDataSource"/>. </summary>
        /// <param name="streamInputDataSourceType"> Indicates the type of input data source containing stream data. Required on PUT (CreateOrReplace) requests. </param>
        internal UnknownStreamInputDataSource(string streamInputDataSourceType) : base(streamInputDataSourceType)
        {
            StreamInputDataSourceType = streamInputDataSourceType ?? "Unknown";
        }
    }
}
