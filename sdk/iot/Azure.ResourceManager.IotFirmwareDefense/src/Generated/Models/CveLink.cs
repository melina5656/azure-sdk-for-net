// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> Link for CVE. </summary>
    public partial class CveLink
    {
        /// <summary> Initializes a new instance of <see cref="CveLink"/>. </summary>
        internal CveLink()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CveLink"/>. </summary>
        /// <param name="href"> Href of CVE link. </param>
        /// <param name="label"> Label of CVE link. </param>
        internal CveLink(string href, string label)
        {
            Href = href;
            Label = label;
        }

        /// <summary> Href of CVE link. </summary>
        public string Href { get; }
        /// <summary> Label of CVE link. </summary>
        public string Label { get; }
    }
}
