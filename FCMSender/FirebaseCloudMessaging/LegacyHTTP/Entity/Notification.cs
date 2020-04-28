using Newtonsoft.Json;

namespace FCMSender.FirebaseCloudMessaging.LegacyHTTP.Entity
{
    public class Notification
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }
}
