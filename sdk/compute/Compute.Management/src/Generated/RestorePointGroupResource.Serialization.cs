// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Compute.Management
{
    public partial class RestorePointGroupResource : IJsonModel<RestorePointGroupData>
    {
        void IJsonModel<RestorePointGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<RestorePointGroupData>)Data).Write(writer, options);

        RestorePointGroupData IJsonModel<RestorePointGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<RestorePointGroupData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<RestorePointGroupData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        RestorePointGroupData IPersistableModel<RestorePointGroupData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<RestorePointGroupData>(data, options);

        string IPersistableModel<RestorePointGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<RestorePointGroupData>)Data).GetFormatFromOptions(options);
    }
}
