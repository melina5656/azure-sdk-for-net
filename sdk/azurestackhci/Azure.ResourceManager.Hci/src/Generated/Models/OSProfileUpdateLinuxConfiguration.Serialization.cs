// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class OSProfileUpdateLinuxConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ProvisionVmAgent))
            {
                writer.WritePropertyName("provisionVMAgent"u8);
                writer.WriteBooleanValue(ProvisionVmAgent.Value);
            }
            if (Optional.IsDefined(ProvisionVmConfigAgent))
            {
                writer.WritePropertyName("provisionVMConfigAgent"u8);
                writer.WriteBooleanValue(ProvisionVmConfigAgent.Value);
            }
            writer.WriteEndObject();
        }
    }
}
