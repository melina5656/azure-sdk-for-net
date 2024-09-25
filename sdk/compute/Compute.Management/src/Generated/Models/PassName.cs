// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Compute.Management.Models
{
    /// <summary> The pass name. Currently, the only allowable value is OobeSystem. </summary>
    public readonly partial struct PassName : IEquatable<PassName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PassName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PassName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OobeSystemValue = "OobeSystem";

        /// <summary> OobeSystem. </summary>
        public static PassName OobeSystem { get; } = new PassName(OobeSystemValue);
        /// <summary> Determines if two <see cref="PassName"/> values are the same. </summary>
        public static bool operator ==(PassName left, PassName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PassName"/> values are not the same. </summary>
        public static bool operator !=(PassName left, PassName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PassName"/>. </summary>
        public static implicit operator PassName(string value) => new PassName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PassName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PassName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
