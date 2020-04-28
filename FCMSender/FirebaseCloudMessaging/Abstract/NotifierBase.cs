namespace FCMSender.FirebaseCloudMessaging.Abstract
{
    public abstract class NotifierBase
    {
        protected NotificationProps Props;

        public NotifierBase(NotificationProps props)
        {
            Props = props;
        }

        public void SendPushNotificationForSpecificDevice()
        {
            string jsonMessage = CreateNotificationMessageForSpecificDevice();
            SendPushNotification(jsonMessage);
        }

        public void SendPushNotificationForTopic()
        {
            string jsonMessage = CreateNotificationMessageForTopic();
            SendPushNotification(jsonMessage);
        }

        public abstract string CreateNotificationMessageForSpecificDevice();
        public abstract string CreateNotificationMessageForTopic();
        protected abstract void SendPushNotification(string jsonMessage);
    }
}
