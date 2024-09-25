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
    public partial class WindowsVmGuestPatchAutomaticByPlatformSettings : IUtf8JsonSerializable, IJsonModel<WindowsVmGuestPatchAutomaticByPlatformSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WindowsVmGuestPatchAutomaticByPlatformSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WindowsVmGuestPatchAutomaticByPlatformSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsVmGuestPatchAutomaticByPlatformSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WindowsVmGuestPatchAutomaticByPlatformSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RebootSetting))
            {
                writer.WritePropertyName("rebootSetting"u8);
                writer.WriteStringValue(RebootSetting.Value.ToString());
            }
            if (Optional.IsDefined(BypassPlatformSafetyChecksOnUserSchedule))
            {
                writer.WritePropertyName("bypassPlatformSafetyChecksOnUserSchedule"u8);
                writer.WriteBooleanValue(BypassPlatformSafetyChecksOnUserSchedule.Value);
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

        WindowsVmGuestPatchAutomaticByPlatformSettings IJsonModel<WindowsVmGuestPatchAutomaticByPlatformSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsVmGuestPatchAutomaticByPlatformSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WindowsVmGuestPatchAutomaticByPlatformSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWindowsVmGuestPatchAutomaticByPlatformSettings(document.RootElement, options);
        }

        internal static WindowsVmGuestPatchAutomaticByPlatformSettings DeserializeWindowsVmGuestPatchAutomaticByPlatformSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WindowsVmGuestPatchAutomaticByPlatformRebootSetting? rebootSetting = default;
            bool? bypassPlatformSafetyChecksOnUserSchedule = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rebootSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rebootSetting = new WindowsVmGuestPatchAutomaticByPlatformRebootSetting(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("bypassPlatformSafetyChecksOnUserSchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bypassPlatformSafetyChecksOnUserSchedule = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WindowsVmGuestPatchAutomaticByPlatformSettings(rebootSetting, bypassPlatformSafetyChecksOnUserSchedule, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WindowsVmGuestPatchAutomaticByPlatformSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsVmGuestPatchAutomaticByPlatformSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WindowsVmGuestPatchAutomaticByPlatformSettings)} does not support writing '{options.Format}' format.");
            }
        }

        WindowsVmGuestPatchAutomaticByPlatformSettings IPersistableModel<WindowsVmGuestPatchAutomaticByPlatformSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsVmGuestPatchAutomaticByPlatformSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWindowsVmGuestPatchAutomaticByPlatformSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WindowsVmGuestPatchAutomaticByPlatformSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WindowsVmGuestPatchAutomaticByPlatformSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
