// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The HciClusterCertificateContent. </summary>
    public partial class HciClusterCertificateContent
    {
        /// <summary> Initializes a new instance of <see cref="HciClusterCertificateContent"/>. </summary>
        public HciClusterCertificateContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HciClusterCertificateContent"/>. </summary>
        /// <param name="properties"></param>
        internal HciClusterCertificateContent(HciClusterRawCertificate properties)
        {
            Properties = properties;
        }

        /// <summary> Gets or sets the properties. </summary>
        internal HciClusterRawCertificate Properties { get; set; }
        /// <summary> Gets the certificates. </summary>
        public IList<string> Certificates
        {
            get
            {
                if (Properties is null)
                    Properties = new HciClusterRawCertificate();
                return Properties.Certificates;
            }
        }
    }
}
