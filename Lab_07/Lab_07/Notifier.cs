using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    public class Notifier
    {
        public void SendSMS(string phoneNumber, string message)
        {
            Console.WriteLine($"Đã gửi SMS đến {phoneNumber}: {message}");
        }
    }
}
