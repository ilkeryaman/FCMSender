using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCMSender.FirebaseCloudMessaging
{
    public class NotificationProps
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Recipient { get; set; }
        public string NotificationAction { get; set; }
        public string RouteName { get; set; }
        public string SubRouteName { get; set; }
    }
}
