using FCMSender.FirebaseCloudMessaging.Abstract;
using FCMSender.FirebaseCloudMessaging.LegacyHTTP.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FCMSender.FirebaseCloudMessaging.LegacyHTTP
{
    public class LegacyHttpNotifier : NotifierBase
    {
        public LegacyHttpNotifier(NotificationProps props) : base(props)
        {
        }

        private Message GetMessage()
        {
            var messageInformation = new Message()
            {
                Notification = new Notification()
                {
                    Title = Props.Title,
                    Body = Props.Body
                },
                Priority = NotificationPriority.high.ToString(),
                Data = new Data() {
                    NotificationAction = Props.NotificationAction,
                    RouteName = Props.RouteName,
                    SubRouteName = Props.SubRouteName
                }
            };

            return messageInformation;
        }

        public override string CreateNotificationMessageForSpecificDevice()
        {
            string deviceToken = Props.Recipient;
            Message message = GetMessage();
            message.Registration_ids = new string[] { deviceToken };
            return JsonConvert.SerializeObject(message);
        }

        public override string CreateNotificationMessageForTopic()
        {
            string topic = Props.Recipient;
            Message message = GetMessage();
            message.To = string.Format("/topics/{0}", topic);
            return JsonConvert.SerializeObject(message);
        }

        protected async override void SendPushNotification(string jsonMessage)
        {
            bool sent = false;
            string firebasePushNotificationUrl = System.Configuration.ConfigurationManager.AppSettings["firebasePushNotificationUrl"];
            string serverKey = System.Configuration.ConfigurationManager.AppSettings["serverKey"];
            // Create request to Firebase API
            var request = new HttpRequestMessage(HttpMethod.Post, firebasePushNotificationUrl);

            request.Headers.TryAddWithoutValidation("Authorization", "key=" + serverKey);
            request.Content = new StringContent(jsonMessage, Encoding.UTF8, "application/json");

            HttpResponseMessage result;
            using (var client = new HttpClient())
            {
                result = await client.SendAsync(request);
                sent = sent && result.IsSuccessStatusCode;
            }
        }
    }
}
