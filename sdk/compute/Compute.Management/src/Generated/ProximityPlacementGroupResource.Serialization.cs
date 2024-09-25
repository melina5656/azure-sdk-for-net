// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Compute.Management
{
    public partial class ProximityPlacementGroupResource : IJsonModel<ProximityPlacementGroupData>
    {
        void IJsonModel<ProximityPlacementGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ProximityPlacementGroupData>)Data).Write(writer, options);

        ProximityPlacementGroupData IJsonModel<ProximityPlacementGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ProximityPlacementGroupData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ProximityPlacementGroupData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ProximityPlacementGroupData IPersistableModel<ProximityPlacementGroupData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ProximityPlacementGroupData>(data, options);

        string IPersistableModel<ProximityPlacementGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ProximityPlacementGroupData>)Data).GetFormatFromOptions(options);
    }
}
