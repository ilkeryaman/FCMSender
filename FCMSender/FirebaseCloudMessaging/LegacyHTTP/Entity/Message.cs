using Newtonsoft.Json;

namespace FCMSender.FirebaseCloudMessaging.LegacyHTTP.Entity
{
    public class Message
    {
        [JsonProperty("registration_ids")]
        public string[] Registration_ids { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("notification")]
        public Notification Notification { get; set; }

        [JsonProperty("data")]
        public object Data { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }
    }
}
