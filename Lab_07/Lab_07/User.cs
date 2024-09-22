using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    public delegate void NotificationHandler(string phoneNumber,string message);
    public class User
    {
        
        private string stk;
        private decimal balance;
        private string phonenumber;
        public string Stk { get => stk; set => stk = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public User(string stk, decimal balance, string phonenumber)
        {
            Stk = stk;
            Balance = balance;
            Phonenumber = phonenumber;
        }
        public event NotificationHandler OnTransaction;
        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                OnTransaction?.Invoke(this.Phonenumber,$"Bạn đã rút {amount:C} \t Số dư còn lại là: {balance:C}");
            }
            else
            {
                Console.WriteLine("Số dư không đủ");
            }
        }
        public void Transfer(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                OnTransaction?.Invoke(this.phonenumber, $"Bạn đã chuyển {amount:C}\t Số dư còn lại là: {balance:C}");
            }
            else
            {
                Console.WriteLine("Số dư không đủ");
            }
        }
    }
}
