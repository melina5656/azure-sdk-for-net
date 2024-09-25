// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Compute.Management.Models
{
    /// <summary> An enum describing the unit of usage measurement. </summary>
    public readonly partial struct ComputeManagementUsageUnit : IEquatable<ComputeManagementUsageUnit>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ComputeManagementUsageUnit"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ComputeManagementUsageUnit(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CountValue = "Count";

        /// <summary> Count. </summary>
        public static ComputeManagementUsageUnit Count { get; } = new ComputeManagementUsageUnit(CountValue);
        /// <summary> Determines if two <see cref="ComputeManagementUsageUnit"/> values are the same. </summary>
        public static bool operator ==(ComputeManagementUsageUnit left, ComputeManagementUsageUnit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ComputeManagementUsageUnit"/> values are not the same. </summary>
        public static bool operator !=(ComputeManagementUsageUnit left, ComputeManagementUsageUnit right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ComputeManagementUsageUnit"/>. </summary>
        public static implicit operator ComputeManagementUsageUnit(string value) => new ComputeManagementUsageUnit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ComputeManagementUsageUnit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ComputeManagementUsageUnit other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
