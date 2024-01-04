// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Localizable string object containing the name and a localized value. </summary>
    public partial class LocalizableString
    {
        /// <summary> Initializes a new instance of <see cref="LocalizableString"/>. </summary>
        internal LocalizableString()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LocalizableString"/>. </summary>
        /// <param name="value"> Non-localized name. </param>
        /// <param name="localizedValue"> Localized name. </param>
        internal LocalizableString(string value, string localizedValue)
        {
            Value = value;
            LocalizedValue = localizedValue;
        }

        /// <summary> Non-localized name. </summary>
        public string Value { get; }
        /// <summary> Localized name. </summary>
        public string LocalizedValue { get; }
    }
}
