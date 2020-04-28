using FCMSender.FirebaseCloudMessaging;
using FCMSender.FirebaseCloudMessaging.Abstract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCMSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AfterInitialize();
        }

        private void AfterInitialize()
        {
            this.notActionCombobox.SelectedIndex = 0;
            this.routeCombobox.SelectedIndex = 0;
            this.subrouteCombobox.SelectedIndex = 0;
        }

        private void showJsonDataBtn_Click(object sender, EventArgs e)
        {
            ShowJsonData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void ShowJsonData()
        {
            NotifierFactory notifierFactory = new NotifierFactory();
            NotifierBase notifier = notifierFactory.GetNotifier(NotificationServerOption.LegacyHTTP, GetNotificationProps());
            string jsonData;
            if (devicetokenRadioBtn.Checked)
            {
                jsonData = notifier.CreateNotificationMessageForSpecificDevice();
            }
            else
            {
                jsonData = notifier.CreateNotificationMessageForTopic();
            }
            jsonDataTextBox.Text = BeautifyJsonData(jsonData);
        }

        private string BeautifyJsonData(string jsonData)
        {
            return jsonData.Replace(",", ",\r\n").Replace("{", "{\r\n").Replace("}", "\r\n}");
        }

        private void SendMessage()
        {
            NotifierFactory notifierFactory = new NotifierFactory();
            NotifierBase notifier = notifierFactory.GetNotifier(NotificationServerOption.LegacyHTTP, GetNotificationProps());

            if (devicetokenRadioBtn.Checked)
            {
                notifier.SendPushNotificationForSpecificDevice();
            }
            else
            {
                notifier.SendPushNotificationForTopic();
            }
        }

        private NotificationProps GetNotificationProps()
        {
            NotificationProps props = new NotificationProps();
            props.Title = titleTextBox.Text;
            props.Body = messageTextBox.Text;
            props.Recipient = devicetokenRadioBtn.Checked ? deviceTokenTextBox.Text : topicTextBox.Text;
            props.NotificationAction = Convert.ToString(notActionCombobox.SelectedItem) ?? "";
            if (props.NotificationAction.Equals("Redirect"))
            {
                props.RouteName = Convert.ToString(routeCombobox.SelectedItem);
                props.SubRouteName = Convert.ToString(subrouteCombobox.SelectedItem);
            }
            return props;
        }

        private void devicetokenRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            SetDisabled((RadioButton)sender);
        }

        private void topicRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            SetDisabled((RadioButton)sender);
        }

        private void SetDisabled(RadioButton sender)
        {
            if(sender.Name == "devicetokenRadioBtn")
            {
                topicTextBox.Enabled = false;
                deviceTokenTextBox.Enabled = true;
            }
            else
            {
                topicTextBox.Enabled = true;
                deviceTokenTextBox.Enabled = false;
            }
        }
    }
}
