using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace MyBestBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            var exchangeRate = BOBHelper.GetExchangeRate();
            NotificationHelper.PushNotification("TestApplication" , $"BOB exchange rate is {exchangeRate}");
            MailHelper.SendMail(ConfigurationManager.AppSettings["bobRateRecipients"],"Bank of Baroda rate checker", "BoB Exchange Rate", $"BOB exchange rate is {exchangeRate}");
        }
    }
}
