using Newtonsoft.Json;

namespace streamdeck_client_csharp.Events
{
    class DidReceiveGlobalSettingsEvent : BaseEvent
    {
        [JsonProperty("payload")]
        public GlobalSettingsPayload Payload { get; private set; }
    }
}
