// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Compute.Management.Models
{
    /// <summary> Specify the public IP allocation type. </summary>
    public readonly partial struct PublicIPAllocationMethod : IEquatable<PublicIPAllocationMethod>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PublicIPAllocationMethod"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PublicIPAllocationMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DynamicValue = "Dynamic";
        private const string StaticValue = "Static";

        /// <summary> Dynamic. </summary>
        public static PublicIPAllocationMethod Dynamic { get; } = new PublicIPAllocationMethod(DynamicValue);
        /// <summary> Static. </summary>
        public static PublicIPAllocationMethod Static { get; } = new PublicIPAllocationMethod(StaticValue);
        /// <summary> Determines if two <see cref="PublicIPAllocationMethod"/> values are the same. </summary>
        public static bool operator ==(PublicIPAllocationMethod left, PublicIPAllocationMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PublicIPAllocationMethod"/> values are not the same. </summary>
        public static bool operator !=(PublicIPAllocationMethod left, PublicIPAllocationMethod right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PublicIPAllocationMethod"/>. </summary>
        public static implicit operator PublicIPAllocationMethod(string value) => new PublicIPAllocationMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PublicIPAllocationMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PublicIPAllocationMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
