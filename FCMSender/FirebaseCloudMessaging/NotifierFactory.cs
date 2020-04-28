using FCMSender.FirebaseCloudMessaging.Abstract;
using FCMSender.FirebaseCloudMessaging.LegacyHTTP;

namespace FCMSender.FirebaseCloudMessaging
{
    public class NotifierFactory
    {
        public NotifierBase GetNotifier(NotificationServerOption notificationServerOption, NotificationProps props)
        {
            NotifierBase notifier;
            switch (notificationServerOption)
            {
                case NotificationServerOption.LegacyHTTP:
                    notifier = new LegacyHttpNotifier(props);
                    break;
                default:
                    notifier = new LegacyHttpNotifier(props);
                    break;
            }
            return notifier;
        }
    }
}
