using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Buoi2
{
    public class Student : Human
    {
        private string id;
        private float gpa;

        public string Id { get => id; set => id = value; }
        public float Gpa { get => gpa; set => gpa = value; }

        public Student( string id_="None" , string name_ = "none" ,string pob="none",DateTime birthday_ = default, float gpa_ = 0.0f) :base(name_ , pob,birthday_)
        {
            id = id_;
            gpa = gpa_;
           
        }
        public Student(Student st) : base(st)
        {
            id = st.Id;
            gpa = st.Gpa;
        }
        public void PrintInfo(Student[] st)
        {
            for (int i = 0; i < st.Length; i++)
                Console.WriteLine($"{st[i].Id,-8}|\t{st[i].Name,-10}\t|\t{st[i].Place_of_birth,-10}\t|\t{st[i].Birthday.ToString("dd/MM/yyyy")}\t|\t{st[i].Gpa,-10}");
        }
        public void SortAndPrint(Student[] st)
        {
            for (int i = 0; i < st.Length - 1; i++)
            {
                for (int j = 0; j < st.Length - 1 - i; j++)
                {
                    if (st[j].gpa < st[j + 1].gpa)
                    {
                        // Hoán đổi vị trí
                        Student temp = st[j];
                        st[j] = st[j + 1];
                        st[j + 1] = temp;
                    }
                }
            }
            foreach (var sv in st)
                Console.WriteLine($"{sv.Id,-8}|\t{sv.Name,-10}\t|\t{sv.Place_of_birth,-10}\t|\t{sv.Birthday.ToString("dd/MM/yyyy")}\t|\t{sv.Gpa,-10}");
        }
    }
}
