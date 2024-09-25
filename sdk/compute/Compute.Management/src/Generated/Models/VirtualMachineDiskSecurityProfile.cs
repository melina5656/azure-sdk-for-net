// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Compute.Management.Models
{
    /// <summary> Specifies the security profile settings for the managed disk. **Note:** It can only be set for Confidential VMs. </summary>
    public partial class VirtualMachineDiskSecurityProfile
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineDiskSecurityProfile"/>. </summary>
        public VirtualMachineDiskSecurityProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineDiskSecurityProfile"/>. </summary>
        /// <param name="securityEncryptionType"> Specifies the EncryptionType of the managed disk. It is set to DiskWithVMGuestState for encryption of the managed disk along with VMGuestState blob, VMGuestStateOnly for encryption of just the VMGuestState blob, and NonPersistedTPM for not persisting firmware state in the VMGuestState blob.. **Note:** It can be set for only Confidential VMs. </param>
        /// <param name="diskEncryptionSet"> Specifies the customer managed disk encryption set resource id for the managed disk that is used for Customer Managed Key encrypted ConfidentialVM OS Disk and VMGuest blob. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineDiskSecurityProfile(SecurityEncryptionType? securityEncryptionType, WritableSubResource diskEncryptionSet, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SecurityEncryptionType = securityEncryptionType;
            DiskEncryptionSet = diskEncryptionSet;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies the EncryptionType of the managed disk. It is set to DiskWithVMGuestState for encryption of the managed disk along with VMGuestState blob, VMGuestStateOnly for encryption of just the VMGuestState blob, and NonPersistedTPM for not persisting firmware state in the VMGuestState blob.. **Note:** It can be set for only Confidential VMs. </summary>
        public SecurityEncryptionType? SecurityEncryptionType { get; set; }
        /// <summary> Specifies the customer managed disk encryption set resource id for the managed disk that is used for Customer Managed Key encrypted ConfidentialVM OS Disk and VMGuest blob. </summary>
        internal WritableSubResource DiskEncryptionSet { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier DiskEncryptionSetId
        {
            get => DiskEncryptionSet is null ? default : DiskEncryptionSet.Id;
            set
            {
                if (DiskEncryptionSet is null)
                    DiskEncryptionSet = new WritableSubResource();
                DiskEncryptionSet.Id = value;
            }
        }
    }
}
