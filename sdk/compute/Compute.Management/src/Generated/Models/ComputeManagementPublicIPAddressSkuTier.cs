// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Compute.Management.Models
{
    /// <summary> Specify public IP sku tier. </summary>
    public readonly partial struct ComputeManagementPublicIPAddressSkuTier : IEquatable<ComputeManagementPublicIPAddressSkuTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ComputeManagementPublicIPAddressSkuTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ComputeManagementPublicIPAddressSkuTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RegionalValue = "Regional";
        private const string GlobalValue = "Global";

        /// <summary> Regional. </summary>
        public static ComputeManagementPublicIPAddressSkuTier Regional { get; } = new ComputeManagementPublicIPAddressSkuTier(RegionalValue);
        /// <summary> Global. </summary>
        public static ComputeManagementPublicIPAddressSkuTier Global { get; } = new ComputeManagementPublicIPAddressSkuTier(GlobalValue);
        /// <summary> Determines if two <see cref="ComputeManagementPublicIPAddressSkuTier"/> values are the same. </summary>
        public static bool operator ==(ComputeManagementPublicIPAddressSkuTier left, ComputeManagementPublicIPAddressSkuTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ComputeManagementPublicIPAddressSkuTier"/> values are not the same. </summary>
        public static bool operator !=(ComputeManagementPublicIPAddressSkuTier left, ComputeManagementPublicIPAddressSkuTier right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ComputeManagementPublicIPAddressSkuTier"/>. </summary>
        public static implicit operator ComputeManagementPublicIPAddressSkuTier(string value) => new ComputeManagementPublicIPAddressSkuTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ComputeManagementPublicIPAddressSkuTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ComputeManagementPublicIPAddressSkuTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
