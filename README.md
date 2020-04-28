# FCMSender
FCMSender is a tool for sending push notification to a device, or to all devices that subscribes a topic by using HTTP protocol.

## Setup
You have to add your FCM server key to serverKey parameter at app.config file:
```csharp
<add key="serverKey" value="....." />
```

## Sending Push Notification

**Send Push Notification to a Device**
* Select deviceToken from Target.
* Put deviceToken of target device to Device Token textbox.

**Send Push Notification To All Devices That Subscribe To a Token**
* Select topic from Target.
* Put topic name to Topic textbox.

## Authors

* **Ilker Yaman** - *Initial work* - [FCMSender](https://github.com/ilkeryaman/FCMSender)

## More

You can read more about Firebase Cloud Messaging by using HTTP protocol from following link: https://firebase.google.com/docs/cloud-messaging/http-server-ref?hl=tr
