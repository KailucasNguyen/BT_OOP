using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Buoi2
{
    public class Human
    {
        protected string name;
        private string place_of_birth;
        private DateTime birthday;

        public string Name { get => name; set => name = value; }
        public string Place_of_birth { get => place_of_birth; set => place_of_birth = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public Human(string name_, string place_of_birth_, DateTime birthday_)
        {
            name = name_;
            place_of_birth = place_of_birth_;
            birthday = birthday_;
        }
        public Human(Human humans)
        {
            name = humans.name;
            place_of_birth = humans.place_of_birth;
            birthday = humans.birthday;
        }
    }
}
