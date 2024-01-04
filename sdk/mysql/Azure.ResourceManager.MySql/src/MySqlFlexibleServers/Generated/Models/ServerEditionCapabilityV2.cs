// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Server edition capabilities. </summary>
    public partial class ServerEditionCapabilityV2
    {
        /// <summary> Initializes a new instance of <see cref="ServerEditionCapabilityV2"/>. </summary>
        internal ServerEditionCapabilityV2()
        {
            SupportedStorageEditions = new ChangeTrackingList<MySqlFlexibleServerStorageEditionCapability>();
            SupportedSkus = new ChangeTrackingList<SkuCapabilityV2>();
        }

        /// <summary> Initializes a new instance of <see cref="ServerEditionCapabilityV2"/>. </summary>
        /// <param name="name"> Server edition name. </param>
        /// <param name="defaultSku"> Default Sku name. </param>
        /// <param name="defaultStorageSize"> Default storage size. </param>
        /// <param name="supportedStorageEditions"> A list of supported storage editions. </param>
        /// <param name="supportedSkus"> A list of supported Skus. </param>
        internal ServerEditionCapabilityV2(string name, string defaultSku, int? defaultStorageSize, IReadOnlyList<MySqlFlexibleServerStorageEditionCapability> supportedStorageEditions, IReadOnlyList<SkuCapabilityV2> supportedSkus)
        {
            Name = name;
            DefaultSku = defaultSku;
            DefaultStorageSize = defaultStorageSize;
            SupportedStorageEditions = supportedStorageEditions;
            SupportedSkus = supportedSkus;
        }

        /// <summary> Server edition name. </summary>
        public string Name { get; }
        /// <summary> Default Sku name. </summary>
        public string DefaultSku { get; }
        /// <summary> Default storage size. </summary>
        public int? DefaultStorageSize { get; }
        /// <summary> A list of supported storage editions. </summary>
        public IReadOnlyList<MySqlFlexibleServerStorageEditionCapability> SupportedStorageEditions { get; }
        /// <summary> A list of supported Skus. </summary>
        public IReadOnlyList<SkuCapabilityV2> SupportedSkus { get; }
    }
}
