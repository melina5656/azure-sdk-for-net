// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Disk.Management.Models
{
    /// <summary> The type of key used to encrypt the data of the disk. </summary>
    public readonly partial struct DiskManagementEncryptionType : IEquatable<DiskManagementEncryptionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DiskManagementEncryptionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DiskManagementEncryptionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EncryptionAtRestWithPlatformKeyValue = "EncryptionAtRestWithPlatformKey";
        private const string EncryptionAtRestWithCustomerKeyValue = "EncryptionAtRestWithCustomerKey";
        private const string EncryptionAtRestWithPlatformAndCustomerKeysValue = "EncryptionAtRestWithPlatformAndCustomerKeys";

        /// <summary> Disk is encrypted at rest with Platform managed key. It is the default encryption type. This is not a valid encryption type for disk encryption sets. </summary>
        public static DiskManagementEncryptionType EncryptionAtRestWithPlatformKey { get; } = new DiskManagementEncryptionType(EncryptionAtRestWithPlatformKeyValue);
        /// <summary> Disk is encrypted at rest with Customer managed key that can be changed and revoked by a customer. </summary>
        public static DiskManagementEncryptionType EncryptionAtRestWithCustomerKey { get; } = new DiskManagementEncryptionType(EncryptionAtRestWithCustomerKeyValue);
        /// <summary> Disk is encrypted at rest with 2 layers of encryption. One of the keys is Customer managed and the other key is Platform managed. </summary>
        public static DiskManagementEncryptionType EncryptionAtRestWithPlatformAndCustomerKeys { get; } = new DiskManagementEncryptionType(EncryptionAtRestWithPlatformAndCustomerKeysValue);
        /// <summary> Determines if two <see cref="DiskManagementEncryptionType"/> values are the same. </summary>
        public static bool operator ==(DiskManagementEncryptionType left, DiskManagementEncryptionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiskManagementEncryptionType"/> values are not the same. </summary>
        public static bool operator !=(DiskManagementEncryptionType left, DiskManagementEncryptionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DiskManagementEncryptionType"/>. </summary>
        public static implicit operator DiskManagementEncryptionType(string value) => new DiskManagementEncryptionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiskManagementEncryptionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiskManagementEncryptionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
