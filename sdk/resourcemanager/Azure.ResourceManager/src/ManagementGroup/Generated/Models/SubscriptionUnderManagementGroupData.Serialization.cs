// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ManagementGroups.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagementGroups
{
    public partial class SubscriptionUnderManagementGroupData : IUtf8JsonSerializable, IJsonModel<SubscriptionUnderManagementGroupData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SubscriptionUnderManagementGroupData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SubscriptionUnderManagementGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionUnderManagementGroupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubscriptionUnderManagementGroupData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Tenant))
            {
                writer.WritePropertyName("tenant"u8);
                writer.WriteStringValue(Tenant);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Parent))
            {
                if (Parent != null)
                {
                    writer.WritePropertyName("parent"u8);
                    writer.WriteObjectValue(Parent);
                }
                else
                {
                    writer.WriteNull("parent");
                }
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            writer.WriteEndObject();
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

        SubscriptionUnderManagementGroupData IJsonModel<SubscriptionUnderManagementGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionUnderManagementGroupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubscriptionUnderManagementGroupData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSubscriptionUnderManagementGroupData(document.RootElement, options);
        }

        internal static SubscriptionUnderManagementGroupData DeserializeSubscriptionUnderManagementGroupData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> tenant = default;
            Optional<string> displayName = default;
            Optional<DescendantParentGroupInfo> parent = default;
            Optional<string> state = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("tenant"u8))
                        {
                            tenant = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("parent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                parent = null;
                                continue;
                            }
                            parent = DescendantParentGroupInfo.DeserializeDescendantParentGroupInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            state = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SubscriptionUnderManagementGroupData(id, name, type, systemData.Value, tenant.Value, displayName.Value, parent.Value, state.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SubscriptionUnderManagementGroupData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionUnderManagementGroupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SubscriptionUnderManagementGroupData)} does not support '{options.Format}' format.");
            }
        }

        SubscriptionUnderManagementGroupData IPersistableModel<SubscriptionUnderManagementGroupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionUnderManagementGroupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSubscriptionUnderManagementGroupData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SubscriptionUnderManagementGroupData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SubscriptionUnderManagementGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
