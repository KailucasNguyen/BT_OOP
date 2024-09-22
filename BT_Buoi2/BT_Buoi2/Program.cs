using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Buoi2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Bai_1();
            //Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Bai_2();
            Console.ReadKey();
        }
        static void Bai_1()
        {
            Student[] hocSinh = new Student[5]
            {
                new Student("01","Dat","Nam Dinh",new DateTime(2004,11,07),3.5f),
                new Student("02","Nhu", "Quang Nam", new DateTime(2006,10,27), 3.0f),
                new Student("03","Thy", "Ben Tre", new DateTime(2005,07,26), 3.2f),
                new Student("04","Vy", "Binh Duong", new DateTime(2006, 02, 05), 3.6f),
                new Student("05","Khoa", "Binh Duong", new DateTime(2005, 06, 11), 4.0f)
            };
            Student student = new Student();
            Console.WriteLine("Bai 1:");
            Console.WriteLine($"ID_ \t|\t Ho va Ten\t|\t Noi sinh\t|\t Ngay Sinh \t|\t GPA");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            student.PrintInfo(hocSinh);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"ID_ \t|\t Ho va Ten\t|\t Noi sinh\t|\t Ngay Sinh \t|\t GPA");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            student.SortAndPrint(hocSinh);
        }
        static void Bai_2()
        {
            Console.WriteLine("Bai 2:");
            Vector[] vectors = new Vector[10]
            {
                new Vector2D(0f,1f),
                new Vector3D(2f,3f,4f),
                new Vector2D(1f,0f),
                new Vector3D(-2f,0f,1f),
                new Vector2D(1f,1f),
                new Vector3D(1f,1f,1f),
                new Vector2D(2f,6f),
                new Vector3D(4f,-5f,8f),
                new Vector2D(3.4f,5f),
                new Vector3D(1.5f,3f,6f)
            };
            Console.WriteLine("Vector 2D:");
            for (int i = 0; i < vectors.Length; i++)
            {
                if (vectors[i].GetType() == typeof(Vector2D))
                    Console.WriteLine($"V{i}={vectors[i].ShowInfo()}");
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Vector 3D:");
            for(int i = 0;i < vectors.Length; i++)
            {
                if (vectors[i].GetType() == typeof(Vector3D))
                    Console.WriteLine($"V{i}={vectors[i].ShowInfo()}");
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Sum Vector:");
            for (int i = 0; i < vectors.Length - 1; i++)
            {
                for (int j = i+1; j < vectors.Length; j++)
                if (vectors[i].GetType() == vectors[j].GetType())
                {
                    Console.WriteLine($"V{i}+V{j}={vectors[i].Sum(vectors[j]).ShowInfo()}");
                }
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Orth Vector:");
            for (int i = 0; i < vectors.Length - 1; i++)
            {
                for (int j = i + 1; j < vectors.Length; j++)
                    if (vectors[i].GetType() == vectors[j].GetType())
                    {
                        if (vectors[i].Orth(vectors[j]))
                        Console.WriteLine($"V{i} {vectors[i].ShowInfo()} va V{j} {vectors[j].ShowInfo()}");
                    }
            }
        }
    }
}
