using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    public class ATM
    {
        private User user;
        private Notifier notifier;
        public User User { get => user; set => user = value; }
        public ATM(User user)
        {
            this.User = user;
            this.notifier = new Notifier();
        }
        public void AddNoti()
        {
            user.OnTransaction += notifier.SendSMS;
        }
    }
}
