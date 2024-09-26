// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Disk.Models
{
    /// <summary> The current provisioning state. </summary>
    public readonly partial struct DiskPrivateEndpointConnectionProvisioningState : IEquatable<DiskPrivateEndpointConnectionProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DiskPrivateEndpointConnectionProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DiskPrivateEndpointConnectionProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string FailedValue = "Failed";

        /// <summary> Succeeded. </summary>
        public static DiskPrivateEndpointConnectionProvisioningState Succeeded { get; } = new DiskPrivateEndpointConnectionProvisioningState(SucceededValue);
        /// <summary> Creating. </summary>
        public static DiskPrivateEndpointConnectionProvisioningState Creating { get; } = new DiskPrivateEndpointConnectionProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static DiskPrivateEndpointConnectionProvisioningState Deleting { get; } = new DiskPrivateEndpointConnectionProvisioningState(DeletingValue);
        /// <summary> Failed. </summary>
        public static DiskPrivateEndpointConnectionProvisioningState Failed { get; } = new DiskPrivateEndpointConnectionProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="DiskPrivateEndpointConnectionProvisioningState"/> values are the same. </summary>
        public static bool operator ==(DiskPrivateEndpointConnectionProvisioningState left, DiskPrivateEndpointConnectionProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiskPrivateEndpointConnectionProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(DiskPrivateEndpointConnectionProvisioningState left, DiskPrivateEndpointConnectionProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DiskPrivateEndpointConnectionProvisioningState"/>. </summary>
        public static implicit operator DiskPrivateEndpointConnectionProvisioningState(string value) => new DiskPrivateEndpointConnectionProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiskPrivateEndpointConnectionProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiskPrivateEndpointConnectionProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
