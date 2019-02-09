using Newtonsoft.Json;

namespace streamdeck_client_csharp.Events
{
    class PropertyInspectorDidDisappearEvent : BaseEvent
    {
        [JsonProperty("action")]
        public string Action { get; private set; }

        [JsonProperty("context")]
        public string Context { get; private set; }

        [JsonProperty("device")]
        public string Device { get; private set; }
    }
}
