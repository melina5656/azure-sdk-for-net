// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Disk.Management.Models
{
    /// <summary> The private endpoint connection status. </summary>
    public readonly partial struct DiskManagementPrivateEndpointServiceConnectionStatus : IEquatable<DiskManagementPrivateEndpointServiceConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DiskManagementPrivateEndpointServiceConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DiskManagementPrivateEndpointServiceConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";

        /// <summary> Pending. </summary>
        public static DiskManagementPrivateEndpointServiceConnectionStatus Pending { get; } = new DiskManagementPrivateEndpointServiceConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static DiskManagementPrivateEndpointServiceConnectionStatus Approved { get; } = new DiskManagementPrivateEndpointServiceConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static DiskManagementPrivateEndpointServiceConnectionStatus Rejected { get; } = new DiskManagementPrivateEndpointServiceConnectionStatus(RejectedValue);
        /// <summary> Determines if two <see cref="DiskManagementPrivateEndpointServiceConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(DiskManagementPrivateEndpointServiceConnectionStatus left, DiskManagementPrivateEndpointServiceConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiskManagementPrivateEndpointServiceConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(DiskManagementPrivateEndpointServiceConnectionStatus left, DiskManagementPrivateEndpointServiceConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DiskManagementPrivateEndpointServiceConnectionStatus"/>. </summary>
        public static implicit operator DiskManagementPrivateEndpointServiceConnectionStatus(string value) => new DiskManagementPrivateEndpointServiceConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiskManagementPrivateEndpointServiceConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiskManagementPrivateEndpointServiceConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
