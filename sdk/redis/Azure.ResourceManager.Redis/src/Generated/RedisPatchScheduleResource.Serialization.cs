// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Redis
{
    public partial class RedisPatchScheduleResource : IJsonModel<RedisPatchScheduleData>
    {
        private static RedisPatchScheduleData s_dataDeserializationInstance;
        private static RedisPatchScheduleData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<RedisPatchScheduleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<RedisPatchScheduleData>)Data).Write(writer, options);

        RedisPatchScheduleData IJsonModel<RedisPatchScheduleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<RedisPatchScheduleData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<RedisPatchScheduleData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<RedisPatchScheduleData>(Data, options, AzureResourceManagerRedisContext.Default);

        RedisPatchScheduleData IPersistableModel<RedisPatchScheduleData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<RedisPatchScheduleData>(data, options, AzureResourceManagerRedisContext.Default);

        string IPersistableModel<RedisPatchScheduleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<RedisPatchScheduleData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
