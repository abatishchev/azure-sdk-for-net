// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.LambdaTestHyperExecute
{
    public partial class LambdaTestHyperExecuteOrganizationResource : IJsonModel<LambdaTestHyperExecuteOrganizationData>
    {
        private static LambdaTestHyperExecuteOrganizationData s_dataDeserializationInstance;
        private static LambdaTestHyperExecuteOrganizationData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<LambdaTestHyperExecuteOrganizationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<LambdaTestHyperExecuteOrganizationData>)Data).Write(writer, options);

        LambdaTestHyperExecuteOrganizationData IJsonModel<LambdaTestHyperExecuteOrganizationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<LambdaTestHyperExecuteOrganizationData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<LambdaTestHyperExecuteOrganizationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<LambdaTestHyperExecuteOrganizationData>(Data, options, AzureResourceManagerLambdaTestHyperExecuteContext.Default);

        LambdaTestHyperExecuteOrganizationData IPersistableModel<LambdaTestHyperExecuteOrganizationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<LambdaTestHyperExecuteOrganizationData>(data, options, AzureResourceManagerLambdaTestHyperExecuteContext.Default);

        string IPersistableModel<LambdaTestHyperExecuteOrganizationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<LambdaTestHyperExecuteOrganizationData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
