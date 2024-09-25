// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Compute.Management.Models
{
    public partial class VirtualMachineInstallPatchesContent : IUtf8JsonSerializable, IJsonModel<VirtualMachineInstallPatchesContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineInstallPatchesContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VirtualMachineInstallPatchesContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstallPatchesContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineInstallPatchesContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MaximumDuration))
            {
                writer.WritePropertyName("maximumDuration"u8);
                writer.WriteStringValue(MaximumDuration.Value, "c");
            }
            writer.WritePropertyName("rebootSetting"u8);
            writer.WriteStringValue(RebootSetting.ToString());
            if (Optional.IsDefined(WindowsParameters))
            {
                writer.WritePropertyName("windowsParameters"u8);
                writer.WriteObjectValue(WindowsParameters, options);
            }
            if (Optional.IsDefined(LinuxParameters))
            {
                writer.WritePropertyName("linuxParameters"u8);
                writer.WriteObjectValue(LinuxParameters, options);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        VirtualMachineInstallPatchesContent IJsonModel<VirtualMachineInstallPatchesContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstallPatchesContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineInstallPatchesContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineInstallPatchesContent(document.RootElement, options);
        }

        internal static VirtualMachineInstallPatchesContent DeserializeVirtualMachineInstallPatchesContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TimeSpan? maximumDuration = default;
            VmGuestPatchRebootSetting rebootSetting = default;
            WindowsParameters windowsParameters = default;
            LinuxParameters linuxParameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maximumDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximumDuration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("rebootSetting"u8))
                {
                    rebootSetting = new VmGuestPatchRebootSetting(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("windowsParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    windowsParameters = WindowsParameters.DeserializeWindowsParameters(property.Value, options);
                    continue;
                }
                if (property.NameEquals("linuxParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linuxParameters = LinuxParameters.DeserializeLinuxParameters(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VirtualMachineInstallPatchesContent(maximumDuration, rebootSetting, windowsParameters, linuxParameters, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineInstallPatchesContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstallPatchesContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineInstallPatchesContent)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualMachineInstallPatchesContent IPersistableModel<VirtualMachineInstallPatchesContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstallPatchesContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineInstallPatchesContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineInstallPatchesContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineInstallPatchesContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
