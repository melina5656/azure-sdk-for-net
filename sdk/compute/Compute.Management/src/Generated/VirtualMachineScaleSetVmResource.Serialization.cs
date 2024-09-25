// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Compute.Management
{
    public partial class VirtualMachineScaleSetVmResource : IJsonModel<VirtualMachineScaleSetVmData>
    {
        void IJsonModel<VirtualMachineScaleSetVmData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<VirtualMachineScaleSetVmData>)Data).Write(writer, options);

        VirtualMachineScaleSetVmData IJsonModel<VirtualMachineScaleSetVmData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<VirtualMachineScaleSetVmData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<VirtualMachineScaleSetVmData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        VirtualMachineScaleSetVmData IPersistableModel<VirtualMachineScaleSetVmData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<VirtualMachineScaleSetVmData>(data, options);

        string IPersistableModel<VirtualMachineScaleSetVmData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<VirtualMachineScaleSetVmData>)Data).GetFormatFromOptions(options);
    }
}
