using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_B2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bai1();
            Bai2();
            Console.ReadKey();
        }
        static void Bai1()
        {
            Student[] hocSinh = new Student[10]
            {
                new Student("Anh", 3.4f),
                new Student("Bao", 3.0f),
                new Student("Khoa", 3.6f),
                new Student("Dat", 3.2f),
                new Student("Nhut", 3.3f),
                new Student("Dong", 4.0f),
                new Student("Vy", 3.5f),
                new Student("Nhu", 2.8f),
                new Student("Thu", 3.1f),
                new Student("Thao", 2.9f),
            };

            Student student = new Student();
            Console.WriteLine($"STT \t|\t Ho va Ten\t\t|\t GPA");
            Console.WriteLine("----------------------------------------------------------");
            student.InThongTin(hocSinh);
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"STT \t|\t Ho va Ten\t\t|\t GPA");
            Console.WriteLine("----------------------------------------------------------");
            student.SortAndPrint(hocSinh);
        }
        static void Bai2()
        {
            List<Vector> vectors = new List<Vector>(10)
            {
                new Vector(-1,0), // 1 orth 2
                new Vector(0,-1),
                new Vector(1,5),
                new Vector(5,-12),
                new Vector(2,3),
                new Vector(-1,-1), // 6 orth 7
                new Vector(1,-1),
                new Vector(-4,1),
                new Vector(1,3),
                new Vector(0,1)
            };
            Console.WriteLine("V0 + V1 = {0}", vectors[0].Add(vectors[1]).printVector());
            Console.WriteLine("V0 - V1 = {0}", vectors[0].Subtract(vectors[1]).printVector());
            Console.WriteLine("V0 * V1 = {0}", vectors[0].Multiply(vectors[1]));
            for (int i = 0; i < vectors.Count; i++)
            {
                for (int j = 0; j < vectors.Count; j++)
                {
                    if (vectors[i].orth(vectors[j]))
                        Console.WriteLine($"{vectors[i].printVector()} va {vectors[j].printVector()}");
                }
            }
        }
    }
}
