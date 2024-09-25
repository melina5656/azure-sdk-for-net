// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Sku.Management.Models
{
    /// <summary> The type of the extended location. </summary>
    public readonly partial struct ExtendedLocationType : IEquatable<ExtendedLocationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ExtendedLocationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExtendedLocationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EdgeZoneValue = "EdgeZone";

        /// <summary> EdgeZone. </summary>
        public static ExtendedLocationType EdgeZone { get; } = new ExtendedLocationType(EdgeZoneValue);
        /// <summary> Determines if two <see cref="ExtendedLocationType"/> values are the same. </summary>
        public static bool operator ==(ExtendedLocationType left, ExtendedLocationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExtendedLocationType"/> values are not the same. </summary>
        public static bool operator !=(ExtendedLocationType left, ExtendedLocationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ExtendedLocationType"/>. </summary>
        public static implicit operator ExtendedLocationType(string value) => new ExtendedLocationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExtendedLocationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExtendedLocationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
