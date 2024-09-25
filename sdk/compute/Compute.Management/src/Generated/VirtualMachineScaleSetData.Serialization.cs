// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Compute.Management.Models;

namespace Compute.Management
{
    public partial class VirtualMachineScaleSetData : IUtf8JsonSerializable, IJsonModel<VirtualMachineScaleSetData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineScaleSetData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VirtualMachineScaleSetData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku, options);
            }
            if (Optional.IsDefined(Plan))
            {
                writer.WritePropertyName("plan"u8);
                writer.WriteObjectValue(Plan, options);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation"u8);
                JsonSerializer.Serialize(writer, ExtendedLocation);
            }
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
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
            if (Optional.IsDefined(UpgradePolicy))
            {
                writer.WritePropertyName("upgradePolicy"u8);
                writer.WriteObjectValue(UpgradePolicy, options);
            }
            if (Optional.IsDefined(ScheduledEventsPolicy))
            {
                writer.WritePropertyName("scheduledEventsPolicy"u8);
                writer.WriteObjectValue(ScheduledEventsPolicy, options);
            }
            if (Optional.IsDefined(AutomaticRepairsPolicy))
            {
                writer.WritePropertyName("automaticRepairsPolicy"u8);
                writer.WriteObjectValue(AutomaticRepairsPolicy, options);
            }
            if (Optional.IsDefined(VirtualMachineProfile))
            {
                writer.WritePropertyName("virtualMachineProfile"u8);
                writer.WriteObjectValue(VirtualMachineProfile, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(Overprovision))
            {
                writer.WritePropertyName("overprovision"u8);
                writer.WriteBooleanValue(Overprovision.Value);
            }
            if (Optional.IsDefined(DoNotRunExtensionsOnOverprovisionedVms))
            {
                writer.WritePropertyName("doNotRunExtensionsOnOverprovisionedVMs"u8);
                writer.WriteBooleanValue(DoNotRunExtensionsOnOverprovisionedVms.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(UniqueId))
            {
                writer.WritePropertyName("uniqueId"u8);
                writer.WriteStringValue(UniqueId);
            }
            if (Optional.IsDefined(SinglePlacementGroup))
            {
                writer.WritePropertyName("singlePlacementGroup"u8);
                writer.WriteBooleanValue(SinglePlacementGroup.Value);
            }
            if (Optional.IsDefined(ZoneBalance))
            {
                writer.WritePropertyName("zoneBalance"u8);
                writer.WriteBooleanValue(ZoneBalance.Value);
            }
            if (Optional.IsDefined(PlatformFaultDomainCount))
            {
                writer.WritePropertyName("platformFaultDomainCount"u8);
                writer.WriteNumberValue(PlatformFaultDomainCount.Value);
            }
            if (Optional.IsDefined(ProximityPlacementGroup))
            {
                writer.WritePropertyName("proximityPlacementGroup"u8);
                JsonSerializer.Serialize(writer, ProximityPlacementGroup);
            }
            if (Optional.IsDefined(HostGroup))
            {
                writer.WritePropertyName("hostGroup"u8);
                JsonSerializer.Serialize(writer, HostGroup);
            }
            if (Optional.IsDefined(AdditionalCapabilities))
            {
                writer.WritePropertyName("additionalCapabilities"u8);
                writer.WriteObjectValue(AdditionalCapabilities, options);
            }
            if (Optional.IsDefined(ScaleInPolicy))
            {
                writer.WritePropertyName("scaleInPolicy"u8);
                writer.WriteObjectValue(ScaleInPolicy, options);
            }
            if (Optional.IsDefined(OrchestrationMode))
            {
                writer.WritePropertyName("orchestrationMode"u8);
                writer.WriteStringValue(OrchestrationMode.Value.ToString());
            }
            if (Optional.IsDefined(SpotRestorePolicy))
            {
                writer.WritePropertyName("spotRestorePolicy"u8);
                writer.WriteObjectValue(SpotRestorePolicy, options);
            }
            if (Optional.IsDefined(PriorityMixPolicy))
            {
                writer.WritePropertyName("priorityMixPolicy"u8);
                writer.WriteObjectValue(PriorityMixPolicy, options);
            }
            if (options.Format != "W" && Optional.IsDefined(TimeCreated))
            {
                writer.WritePropertyName("timeCreated"u8);
                writer.WriteStringValue(TimeCreated.Value, "O");
            }
            if (Optional.IsDefined(IsMaximumCapacityConstrained))
            {
                writer.WritePropertyName("constrainedMaximumCapacity"u8);
                writer.WriteBooleanValue(IsMaximumCapacityConstrained.Value);
            }
            if (Optional.IsDefined(ResiliencyPolicy))
            {
                writer.WritePropertyName("resiliencyPolicy"u8);
                writer.WriteObjectValue(ResiliencyPolicy, options);
            }
            if (Optional.IsDefined(ZonalPlatformFaultDomainAlignMode))
            {
                writer.WritePropertyName("zonalPlatformFaultDomainAlignMode"u8);
                writer.WriteStringValue(ZonalPlatformFaultDomainAlignMode.Value.ToString());
            }
            if (Optional.IsDefined(SkuProfile))
            {
                writer.WritePropertyName("skuProfile"u8);
                writer.WriteObjectValue(SkuProfile, options);
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

        VirtualMachineScaleSetData IJsonModel<VirtualMachineScaleSetData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineScaleSetData(document.RootElement, options);
        }

        internal static VirtualMachineScaleSetData DeserializeVirtualMachineScaleSetData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ComputeManagementSku sku = default;
            ComputeManagementPlan plan = default;
            ManagedServiceIdentity identity = default;
            IList<string> zones = default;
            ExtendedLocation extendedLocation = default;
            string etag = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            VirtualMachineScaleSetUpgradePolicy upgradePolicy = default;
            ScheduledEventsPolicy scheduledEventsPolicy = default;
            AutomaticRepairsPolicy automaticRepairsPolicy = default;
            VirtualMachineScaleSetVmProfile virtualMachineProfile = default;
            string provisioningState = default;
            bool? overprovision = default;
            bool? doNotRunExtensionsOnOverprovisionedVms = default;
            string uniqueId = default;
            bool? singlePlacementGroup = default;
            bool? zoneBalance = default;
            int? platformFaultDomainCount = default;
            WritableSubResource proximityPlacementGroup = default;
            WritableSubResource hostGroup = default;
            AdditionalCapabilities additionalCapabilities = default;
            ScaleInPolicy scaleInPolicy = default;
            OrchestrationMode? orchestrationMode = default;
            SpotRestorePolicy spotRestorePolicy = default;
            VirtualMachineScaleSetPriorityMixPolicy priorityMixPolicy = default;
            DateTimeOffset? timeCreated = default;
            bool? constrainedMaximumCapacity = default;
            ResiliencyPolicy resiliencyPolicy = default;
            ZonalPlatformFaultDomainAlignMode? zonalPlatformFaultDomainAlignMode = default;
            ComputeSkuProfile skuProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = ComputeManagementSku.DeserializeComputeManagementSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("plan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    plan = ComputeManagementPlan.DeserializeComputeManagementPlan(property.Value, options);
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("zones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
                    continue;
                }
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = JsonSerializer.Deserialize<ExtendedLocation>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("upgradePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradePolicy = VirtualMachineScaleSetUpgradePolicy.DeserializeVirtualMachineScaleSetUpgradePolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("scheduledEventsPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scheduledEventsPolicy = ScheduledEventsPolicy.DeserializeScheduledEventsPolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("automaticRepairsPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            automaticRepairsPolicy = AutomaticRepairsPolicy.DeserializeAutomaticRepairsPolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("virtualMachineProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualMachineProfile = VirtualMachineScaleSetVmProfile.DeserializeVirtualMachineScaleSetVmProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("overprovision"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            overprovision = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("doNotRunExtensionsOnOverprovisionedVMs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            doNotRunExtensionsOnOverprovisionedVms = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("uniqueId"u8))
                        {
                            uniqueId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("singlePlacementGroup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            singlePlacementGroup = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("zoneBalance"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            zoneBalance = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("platformFaultDomainCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            platformFaultDomainCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("proximityPlacementGroup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            proximityPlacementGroup = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("hostGroup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostGroup = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("additionalCapabilities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            additionalCapabilities = AdditionalCapabilities.DeserializeAdditionalCapabilities(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("scaleInPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scaleInPolicy = ScaleInPolicy.DeserializeScaleInPolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("orchestrationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            orchestrationMode = new OrchestrationMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("spotRestorePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            spotRestorePolicy = SpotRestorePolicy.DeserializeSpotRestorePolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("priorityMixPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            priorityMixPolicy = VirtualMachineScaleSetPriorityMixPolicy.DeserializeVirtualMachineScaleSetPriorityMixPolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("timeCreated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeCreated = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("constrainedMaximumCapacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            constrainedMaximumCapacity = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("resiliencyPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resiliencyPolicy = ResiliencyPolicy.DeserializeResiliencyPolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("zonalPlatformFaultDomainAlignMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            zonalPlatformFaultDomainAlignMode = new ZonalPlatformFaultDomainAlignMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("skuProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            skuProfile = ComputeSkuProfile.DeserializeComputeSkuProfile(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VirtualMachineScaleSetData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                sku,
                plan,
                identity,
                zones ?? new ChangeTrackingList<string>(),
                extendedLocation,
                etag,
                upgradePolicy,
                scheduledEventsPolicy,
                automaticRepairsPolicy,
                virtualMachineProfile,
                provisioningState,
                overprovision,
                doNotRunExtensionsOnOverprovisionedVms,
                uniqueId,
                singlePlacementGroup,
                zoneBalance,
                platformFaultDomainCount,
                proximityPlacementGroup,
                hostGroup,
                additionalCapabilities,
                scaleInPolicy,
                orchestrationMode,
                spotRestorePolicy,
                priorityMixPolicy,
                timeCreated,
                constrainedMaximumCapacity,
                resiliencyPolicy,
                zonalPlatformFaultDomainAlignMode,
                skuProfile,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineScaleSetData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetData)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualMachineScaleSetData IPersistableModel<VirtualMachineScaleSetData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineScaleSetData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineScaleSetData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
