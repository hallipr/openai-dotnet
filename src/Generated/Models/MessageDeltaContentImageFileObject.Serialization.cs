// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Assistants
{
    internal partial class MessageDeltaContentImageFileObject : IJsonModel<MessageDeltaContentImageFileObject>
    {
        void IJsonModel<MessageDeltaContentImageFileObject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageDeltaContentImageFileObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MessageDeltaContentImageFileObject)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("index") != true)
            {
                writer.WritePropertyName("index"u8);
                writer.WriteNumberValue(Index);
            }
            if (SerializedAdditionalRawData?.ContainsKey("image_file") != true && Optional.IsDefined(ImageFile))
            {
                writer.WritePropertyName("image_file"u8);
                writer.WriteObjectValue(ImageFile, options);
            }
            if (SerializedAdditionalRawData?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type);
            }
            if (SerializedAdditionalRawData != null)
            {
                foreach (var item in SerializedAdditionalRawData)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
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

        MessageDeltaContentImageFileObject IJsonModel<MessageDeltaContentImageFileObject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageDeltaContentImageFileObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MessageDeltaContentImageFileObject)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMessageDeltaContentImageFileObject(document.RootElement, options);
        }

        internal static MessageDeltaContentImageFileObject DeserializeMessageDeltaContentImageFileObject(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int index = default;
            MessageDeltaContentImageFileObjectImageFile imageFile = default;
            string type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("index"u8))
                {
                    index = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("image_file"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageFile = MessageDeltaContentImageFileObjectImageFile.DeserializeMessageDeltaContentImageFileObjectImageFile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MessageDeltaContentImageFileObject(type, serializedAdditionalRawData, index, imageFile);
        }

        BinaryData IPersistableModel<MessageDeltaContentImageFileObject>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageDeltaContentImageFileObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MessageDeltaContentImageFileObject)} does not support writing '{options.Format}' format.");
            }
        }

        MessageDeltaContentImageFileObject IPersistableModel<MessageDeltaContentImageFileObject>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageDeltaContentImageFileObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMessageDeltaContentImageFileObject(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MessageDeltaContentImageFileObject)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MessageDeltaContentImageFileObject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static new MessageDeltaContentImageFileObject FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeMessageDeltaContentImageFileObject(document.RootElement);
        }

        internal override BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
