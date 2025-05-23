// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    public partial class NewRelicPlanDetails : IUtf8JsonSerializable, IJsonModel<NewRelicPlanDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NewRelicPlanDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NewRelicPlanDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicPlanDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRelicPlanDetails)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(UsageType))
            {
                writer.WritePropertyName("usageType"u8);
                writer.WriteStringValue(UsageType.Value.ToString());
            }
            if (Optional.IsDefined(NewRelicPlanBillingCycle))
            {
                writer.WritePropertyName("billingCycle"u8);
                writer.WriteStringValue(NewRelicPlanBillingCycle);
            }
            if (Optional.IsDefined(PlanDetails))
            {
                writer.WritePropertyName("planDetails"u8);
                writer.WriteStringValue(PlanDetails);
            }
            if (Optional.IsDefined(EffectiveOn))
            {
                writer.WritePropertyName("effectiveDate"u8);
                writer.WriteStringValue(EffectiveOn.Value, "O");
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

        NewRelicPlanDetails IJsonModel<NewRelicPlanDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicPlanDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRelicPlanDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNewRelicPlanDetails(document.RootElement, options);
        }

        internal static NewRelicPlanDetails DeserializeNewRelicPlanDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NewRelicObservabilityUsageType? usageType = default;
            string billingCycle = default;
            string planDetails = default;
            DateTimeOffset? effectiveDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("usageType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usageType = new NewRelicObservabilityUsageType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("billingCycle"u8))
                {
                    billingCycle = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("planDetails"u8))
                {
                    planDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("effectiveDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    effectiveDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NewRelicPlanDetails(usageType, billingCycle, planDetails, effectiveDate, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UsageType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  usageType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UsageType))
                {
                    builder.Append("  usageType: ");
                    builder.AppendLine($"'{UsageType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NewRelicPlanBillingCycle), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  billingCycle: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NewRelicPlanBillingCycle))
                {
                    builder.Append("  billingCycle: ");
                    if (NewRelicPlanBillingCycle.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{NewRelicPlanBillingCycle}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{NewRelicPlanBillingCycle}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PlanDetails), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  planDetails: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PlanDetails))
                {
                    builder.Append("  planDetails: ");
                    if (PlanDetails.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PlanDetails}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PlanDetails}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EffectiveOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  effectiveDate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EffectiveOn))
                {
                    builder.Append("  effectiveDate: ");
                    var formattedDateTimeString = TypeFormatters.ToString(EffectiveOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<NewRelicPlanDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicPlanDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNewRelicObservabilityContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(NewRelicPlanDetails)} does not support writing '{options.Format}' format.");
            }
        }

        NewRelicPlanDetails IPersistableModel<NewRelicPlanDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicPlanDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNewRelicPlanDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NewRelicPlanDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NewRelicPlanDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
