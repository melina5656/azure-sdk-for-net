// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A TDE certificate that can be uploaded into a server. </summary>
    public partial class TdeCertificate : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="TdeCertificate"/>. </summary>
        public TdeCertificate()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TdeCertificate"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateBlob"> The base64 encoded certificate private blob. </param>
        /// <param name="certPassword"> The certificate password. </param>
        internal TdeCertificate(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string privateBlob, string certPassword) : base(id, name, resourceType, systemData)
        {
            PrivateBlob = privateBlob;
            CertPassword = certPassword;
        }

        /// <summary> The base64 encoded certificate private blob. </summary>
        public string PrivateBlob { get; set; }
        /// <summary> The certificate password. </summary>
        public string CertPassword { get; set; }
    }
}
