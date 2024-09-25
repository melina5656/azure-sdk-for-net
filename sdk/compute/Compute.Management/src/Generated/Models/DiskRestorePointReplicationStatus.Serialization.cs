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
    public partial class DiskRestorePointReplicationStatus : IUtf8JsonSerializable, IJsonModel<DiskRestorePointReplicationStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DiskRestorePointReplicationStatus>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DiskRestorePointReplicationStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskRestorePointReplicationStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiskRestorePointReplicationStatus)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteObjectValue(Status, options);
            }
            if (Optional.IsDefined(CompletionPercent))
            {
                writer.WritePropertyName("completionPercent"u8);
                writer.WriteNumberValue(CompletionPercent.Value);
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

        DiskRestorePointReplicationStatus IJsonModel<DiskRestorePointReplicationStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskRestorePointReplicationStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiskRestorePointReplicationStatus)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDiskRestorePointReplicationStatus(document.RootElement, options);
        }

        internal static DiskRestorePointReplicationStatus DeserializeDiskRestorePointReplicationStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InstanceViewStatus status = default;
            int? completionPercent = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = InstanceViewStatus.DeserializeInstanceViewStatus(property.Value, options);
                    continue;
                }
                if (property.NameEquals("completionPercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    completionPercent = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DiskRestorePointReplicationStatus(status, completionPercent, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DiskRestorePointReplicationStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskRestorePointReplicationStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DiskRestorePointReplicationStatus)} does not support writing '{options.Format}' format.");
            }
        }

        DiskRestorePointReplicationStatus IPersistableModel<DiskRestorePointReplicationStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskRestorePointReplicationStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDiskRestorePointReplicationStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DiskRestorePointReplicationStatus)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DiskRestorePointReplicationStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
