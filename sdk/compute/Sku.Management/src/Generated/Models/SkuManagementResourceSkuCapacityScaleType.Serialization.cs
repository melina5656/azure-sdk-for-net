// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Sku.Management.Models
{
    internal static partial class SkuManagementResourceSkuCapacityScaleTypeExtensions
    {
        public static string ToSerialString(this SkuManagementResourceSkuCapacityScaleType value) => value switch
        {
            SkuManagementResourceSkuCapacityScaleType.None => "None",
            SkuManagementResourceSkuCapacityScaleType.Automatic => "Automatic",
            SkuManagementResourceSkuCapacityScaleType.Manual => "Manual",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SkuManagementResourceSkuCapacityScaleType value.")
        };

        public static SkuManagementResourceSkuCapacityScaleType ToSkuManagementResourceSkuCapacityScaleType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "None")) return SkuManagementResourceSkuCapacityScaleType.None;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Automatic")) return SkuManagementResourceSkuCapacityScaleType.Automatic;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Manual")) return SkuManagementResourceSkuCapacityScaleType.Manual;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SkuManagementResourceSkuCapacityScaleType value.");
        }
    }
}
