// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Quantum.Jobs.Models
{
    /// <summary> Get SAS URL operation response. </summary>
    public partial class SasUriResponse
    {
        /// <summary> Initializes a new instance of <see cref="SasUriResponse"/>. </summary>
        internal SasUriResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SasUriResponse"/>. </summary>
        /// <param name="sasUri"> A URL with a SAS token to upload a blob for execution in the given workspace. </param>
        internal SasUriResponse(string sasUri)
        {
            SasUri = sasUri;
        }

        /// <summary> A URL with a SAS token to upload a blob for execution in the given workspace. </summary>
        public string SasUri { get; }
    }
}
