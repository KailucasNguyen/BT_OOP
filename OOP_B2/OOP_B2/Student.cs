using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_B2
{
    internal class Student
    {
        private string hoTen;
        private float gpa;
        // có thể khai báo biến như này
        public string HoTen { get => hoTen; set => hoTen = value; }
        public float Gpa { get => gpa; set => gpa = value; }
        // Hoặc khai báo như này
        public Student(string hoTen_ = "None", float gpa_ = 0.0f)
        {
            hoTen = hoTen_;
            gpa = gpa_;
        }
        public Student(Student student)
        {
            hoTen = student.HoTen;
            gpa = student.Gpa;
        }
        public void InThongTin(Student[] student)
        {
            for (int i = 0; i< student.Length; i++)
                Console.WriteLine($"{i + 1} \t|\t {student[i].HoTen,-20} \t|\t {student[i].Gpa,-10}");
        }
        public void SortAndPrint(Student[] hocSinh)
        {
            List<Student> danhSachSinhVien = hocSinh.ToList();

            // Sắp xếp và in ra
            danhSachSinhVien.Sort((s1, s2) => s1.Gpa.CompareTo(s2.Gpa));
            int i = 1;
            foreach (var sinhVien in danhSachSinhVien)
            {
                Console.WriteLine($"{i} \t|\t {sinhVien.HoTen,-20} \t|\t {sinhVien.Gpa,-10}");
                i++;
            }
        }
    }
}
