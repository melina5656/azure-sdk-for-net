// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Compute.Management.Models
{
    /// <summary> The Domain name label scope.The concatenation of the hashed domain name label that generated according to the policy from domain name label scope and vm index will be the domain name labels of the PublicIPAddress resources that will be created. </summary>
    public readonly partial struct DomainNameLabelScopeType : IEquatable<DomainNameLabelScopeType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DomainNameLabelScopeType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DomainNameLabelScopeType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TenantReuseValue = "TenantReuse";
        private const string SubscriptionReuseValue = "SubscriptionReuse";
        private const string ResourceGroupReuseValue = "ResourceGroupReuse";
        private const string NoReuseValue = "NoReuse";

        /// <summary> TenantReuse. </summary>
        public static DomainNameLabelScopeType TenantReuse { get; } = new DomainNameLabelScopeType(TenantReuseValue);
        /// <summary> SubscriptionReuse. </summary>
        public static DomainNameLabelScopeType SubscriptionReuse { get; } = new DomainNameLabelScopeType(SubscriptionReuseValue);
        /// <summary> ResourceGroupReuse. </summary>
        public static DomainNameLabelScopeType ResourceGroupReuse { get; } = new DomainNameLabelScopeType(ResourceGroupReuseValue);
        /// <summary> NoReuse. </summary>
        public static DomainNameLabelScopeType NoReuse { get; } = new DomainNameLabelScopeType(NoReuseValue);
        /// <summary> Determines if two <see cref="DomainNameLabelScopeType"/> values are the same. </summary>
        public static bool operator ==(DomainNameLabelScopeType left, DomainNameLabelScopeType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DomainNameLabelScopeType"/> values are not the same. </summary>
        public static bool operator !=(DomainNameLabelScopeType left, DomainNameLabelScopeType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DomainNameLabelScopeType"/>. </summary>
        public static implicit operator DomainNameLabelScopeType(string value) => new DomainNameLabelScopeType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DomainNameLabelScopeType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DomainNameLabelScopeType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
