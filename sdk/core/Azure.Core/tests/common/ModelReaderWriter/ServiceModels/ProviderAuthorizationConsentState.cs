// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Core.Tests.Models.ResourceManager.Resources
{
    /// <summary> The provider authorization consent state. </summary>
    public readonly partial struct ProviderAuthorizationConsentState : IEquatable<ProviderAuthorizationConsentState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProviderAuthorizationConsentState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProviderAuthorizationConsentState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string RequiredValue = "Required";
        private const string NotRequiredValue = "NotRequired";
        private const string ConsentedValue = "Consented";

        /// <summary> NotSpecified. </summary>
        public static ProviderAuthorizationConsentState NotSpecified { get; } = new ProviderAuthorizationConsentState(NotSpecifiedValue);
        /// <summary> Required. </summary>
        public static ProviderAuthorizationConsentState Required { get; } = new ProviderAuthorizationConsentState(RequiredValue);
        /// <summary> NotRequired. </summary>
        public static ProviderAuthorizationConsentState NotRequired { get; } = new ProviderAuthorizationConsentState(NotRequiredValue);
        /// <summary> Consented. </summary>
        public static ProviderAuthorizationConsentState Consented { get; } = new ProviderAuthorizationConsentState(ConsentedValue);
        /// <summary> Determines if two <see cref="ProviderAuthorizationConsentState"/> values are the same. </summary>
        public static bool operator ==(ProviderAuthorizationConsentState left, ProviderAuthorizationConsentState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProviderAuthorizationConsentState"/> values are not the same. </summary>
        public static bool operator !=(ProviderAuthorizationConsentState left, ProviderAuthorizationConsentState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ProviderAuthorizationConsentState"/>. </summary>
        public static implicit operator ProviderAuthorizationConsentState(string value) => new ProviderAuthorizationConsentState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProviderAuthorizationConsentState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProviderAuthorizationConsentState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
