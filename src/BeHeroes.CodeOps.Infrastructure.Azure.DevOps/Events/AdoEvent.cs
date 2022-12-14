using BeHeroes.CodeOps.Abstractions.Events;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BeHeroes.CodeOps.Infrastructure.Azure.DevOps.Events
{
    public class AdoEvent : IIntegrationEvent
    {
        [JsonPropertyName("id")]
        public string Id { get; init; }

        [JsonPropertyName("publisherId")]
        public string PublisherId { get; init; }

        [JsonPropertyName("eventType")]
        public string EventType { get; init; }

        [JsonPropertyName("scope")]
        public string Scope { get; init; }

        [JsonPropertyName("message")]
        public JsonElement? Message { get; init; }

        [JsonPropertyName("resource")]
        public JsonElement? Resource { get; init; }

        [JsonPropertyName("resourceVersion")]
        public string ResourceVersion { get; init; }

        [JsonPropertyName("resourceContainers")]
        public JsonElement? ResourceContainers { get; init; }

        public string CorrelationId => Id;

        public DateTime CreationDate => DateTime.Now;

        public string SchemaVersion => "1";

        public string Type => EventType;

        public JsonElement? Payload => Resource;
    }
}
