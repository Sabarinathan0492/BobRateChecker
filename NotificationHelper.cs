using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace MyBestBuddy
{
    public static class NotificationHelper
    {
        public static void PushNotification(string applicationName, string text)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml($"<toast><visual><binding template=\"ToastImageAndText01\"><text id = \"1\" >{text}</text></binding></visual></toast>");
            var toast = new ToastNotification(doc);
            ToastNotificationManager.CreateToastNotifier(applicationName).Show(toast);
        }
    }
}
