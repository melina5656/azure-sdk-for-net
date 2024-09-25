// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Disk.Management.Models
{
    /// <summary> Encryption settings for disk or snapshot. </summary>
    public partial class EncryptionSettingsGroup
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

        /// <summary> Initializes a new instance of <see cref="EncryptionSettingsGroup"/>. </summary>
        /// <param name="enabled"> Set this flag to true and provide DiskEncryptionKey and optional KeyEncryptionKey to enable encryption. Set this flag to false and remove DiskEncryptionKey and KeyEncryptionKey to disable encryption. If EncryptionSettings is null in the request object, the existing settings remain unchanged. </param>
        public EncryptionSettingsGroup(bool enabled)
        {
            Enabled = enabled;
            EncryptionSettings = new ChangeTrackingList<EncryptionSettingsElement>();
        }

        /// <summary> Initializes a new instance of <see cref="EncryptionSettingsGroup"/>. </summary>
        /// <param name="enabled"> Set this flag to true and provide DiskEncryptionKey and optional KeyEncryptionKey to enable encryption. Set this flag to false and remove DiskEncryptionKey and KeyEncryptionKey to disable encryption. If EncryptionSettings is null in the request object, the existing settings remain unchanged. </param>
        /// <param name="encryptionSettings"> A collection of encryption settings, one for each disk volume. </param>
        /// <param name="encryptionSettingsVersion"> Describes what type of encryption is used for the disks. Once this field is set, it cannot be overwritten. '1.0' corresponds to Azure Disk Encryption with AAD app.'1.1' corresponds to Azure Disk Encryption. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EncryptionSettingsGroup(bool enabled, IList<EncryptionSettingsElement> encryptionSettings, string encryptionSettingsVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Enabled = enabled;
            EncryptionSettings = encryptionSettings;
            EncryptionSettingsVersion = encryptionSettingsVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EncryptionSettingsGroup"/> for deserialization. </summary>
        internal EncryptionSettingsGroup()
        {
        }

        /// <summary> Set this flag to true and provide DiskEncryptionKey and optional KeyEncryptionKey to enable encryption. Set this flag to false and remove DiskEncryptionKey and KeyEncryptionKey to disable encryption. If EncryptionSettings is null in the request object, the existing settings remain unchanged. </summary>
        public bool Enabled { get; set; }
        /// <summary> A collection of encryption settings, one for each disk volume. </summary>
        public IList<EncryptionSettingsElement> EncryptionSettings { get; }
        /// <summary> Describes what type of encryption is used for the disks. Once this field is set, it cannot be overwritten. '1.0' corresponds to Azure Disk Encryption with AAD app.'1.1' corresponds to Azure Disk Encryption. </summary>
        public string EncryptionSettingsVersion { get; set; }
    }
}
