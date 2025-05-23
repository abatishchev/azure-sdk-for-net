// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SensitivitySettingCreateOrUpdateContent : IUtf8JsonSerializable, IJsonModel<SensitivitySettingCreateOrUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SensitivitySettingCreateOrUpdateContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SensitivitySettingCreateOrUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SensitivitySettingCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SensitivitySettingCreateOrUpdateContent)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("sensitiveInfoTypesIds"u8);
            writer.WriteStartArray();
            foreach (var item in SensitiveInfoTypesIds)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(SensitivityThresholdLabelOrder))
            {
                writer.WritePropertyName("sensitivityThresholdLabelOrder"u8);
                writer.WriteNumberValue(SensitivityThresholdLabelOrder.Value);
            }
            if (Optional.IsDefined(SensitivityThresholdLabelId))
            {
                writer.WritePropertyName("sensitivityThresholdLabelId"u8);
                writer.WriteStringValue(SensitivityThresholdLabelId.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        SensitivitySettingCreateOrUpdateContent IJsonModel<SensitivitySettingCreateOrUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SensitivitySettingCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SensitivitySettingCreateOrUpdateContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSensitivitySettingCreateOrUpdateContent(document.RootElement, options);
        }

        internal static SensitivitySettingCreateOrUpdateContent DeserializeSensitivitySettingCreateOrUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<Guid> sensitiveInfoTypesIds = default;
            float? sensitivityThresholdLabelOrder = default;
            Guid? sensitivityThresholdLabelId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sensitiveInfoTypesIds"u8))
                {
                    List<Guid> array = new List<Guid>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetGuid());
                    }
                    sensitiveInfoTypesIds = array;
                    continue;
                }
                if (property.NameEquals("sensitivityThresholdLabelOrder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sensitivityThresholdLabelOrder = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("sensitivityThresholdLabelId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sensitivityThresholdLabelId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SensitivitySettingCreateOrUpdateContent(sensitiveInfoTypesIds, sensitivityThresholdLabelOrder, sensitivityThresholdLabelId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SensitivitySettingCreateOrUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SensitivitySettingCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSecurityCenterContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SensitivitySettingCreateOrUpdateContent)} does not support writing '{options.Format}' format.");
            }
        }

        SensitivitySettingCreateOrUpdateContent IPersistableModel<SensitivitySettingCreateOrUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SensitivitySettingCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSensitivitySettingCreateOrUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SensitivitySettingCreateOrUpdateContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SensitivitySettingCreateOrUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
