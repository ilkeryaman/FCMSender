using Newtonsoft.Json;

namespace FCMSender.FirebaseCloudMessaging.LegacyHTTP.Entity
{
    public class Data
    {
        [JsonProperty("notificationAction")]
        public string NotificationAction { get; set; }

        [JsonProperty("routeName")]
        public string RouteName { get; set; }

        [JsonProperty("subRouteName")]
        public string SubRouteName { get; set; }
    }
}
