using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Lab_10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string finalJson = File.ReadAllText("data.dat");
            StudentList finalStudentList = JsonSerializer.Deserialize<StudentList>(finalJson);

            Console.WriteLine("Danh sách sinh viên sau khi cập nhật:");
            foreach (Student student in finalStudentList.Students)
            {
                Console.WriteLine(student);
            }
            //Bai1();
            //Bai2();
            Console.ReadKey();
        }
        public static void Bai1()
        {
            StudentList studentList = new StudentList();
            studentList.Add(new Student { Id = 1, Name = "Nam", Age = 20 });
            studentList.Add(new Student { Id = 2, Name = "Binh", Age = 21 });
            studentList.Add(new Student { Id = 3, Name = "Minh", Age = 22 });

            //Serialize ra file data.dat
            string json = JsonSerializer.Serialize(studentList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("data.dat", json);
            Console.WriteLine("Dữ liệu đã được ghi ra file 'data.dat'.\n");

            //Đọc dữ liệu từ file vào biến newjson
            string newjson = File.ReadAllText("data.dat");

            //Deserialize xâu mới thành biến StudentList mới
            StudentList deserializedStudentList = JsonSerializer.Deserialize<StudentList>(json);

            Console.WriteLine("Danh sách sinh viên sau khi deserialization:");
            foreach (Student student in deserializedStudentList.Students)
            {
                Console.WriteLine(student);
            }

            //Bổ sung thêm sinh viên mới vào danh sách
            deserializedStudentList.Add(new Student { Id = 4, Name = "Hoang", Age = 23 });
            deserializedStudentList.Add(new Student { Id = 5, Name = "Phuong", Age = 24 });

            //Serialize và ghi danh sách cập nhật trở lại file
            string updatedJson = JsonSerializer.Serialize(deserializedStudentList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("data.dat", updatedJson);
            Console.WriteLine("\nDữ liệu đã được cập nhật và ghi lại vào file 'data.dat'.\n");

            //Đọc dữ liệu từ file mới và hiển thị kết quả
            string finalJson = File.ReadAllText("data.dat");
            StudentList finalStudentList = JsonSerializer.Deserialize<StudentList>(finalJson);

            Console.WriteLine("Danh sách sinh viên sau khi cập nhật:");
            foreach (Student student in finalStudentList.Students)
            {
                Console.WriteLine(student);
            }
        }

        public static void Bai2()
        {
            StudentList studentList = new StudentList();
            studentList.Add(new Student { Id = 1, Name = "Nam", Age = 20 });
            studentList.Add(new Student { Id = 2, Name = "Binh", Age = 21 });
            studentList.Add(new Student { Id = 3, Name = "Minh", Age = 22 });

            //Serialize ra file data.xml bằng XmlSerializer
            string filePath = "data.xml";
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(StudentList));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                xmlSerializer.Serialize(writer, studentList);
            }
            Console.WriteLine("Dữ liệu đã được ghi ra file 'data.xml'.\n");

            //Đọc dữ liệu từ file vào biến newxml
            string newxml = File.ReadAllText(filePath);

            //Deserialize xâu mới thành biến StudentList mới
            StudentList deserializedStudentList;
            using (StreamReader reader = new StreamReader(filePath))
            {
                deserializedStudentList = (StudentList)xmlSerializer.Deserialize(reader);
            }

            Console.WriteLine("Danh sách sinh viên sau khi deserialization:");
            foreach (Student student in deserializedStudentList.Students)
            {
                Console.WriteLine(student);
            }

            // Bổ sung thêm sinh viên mới vào danh sách
            deserializedStudentList.Add(new Student { Id = 4, Name = "Hoang", Age = 23 });
            deserializedStudentList.Add(new Student { Id = 5, Name = "Phuong", Age = 24 });

            //Serialize và ghi danh sách cập nhật trở lại file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                xmlSerializer.Serialize(writer, deserializedStudentList);
            }
            Console.WriteLine("\nDữ liệu đã được cập nhật và ghi lại vào file 'data.xml'.\n");

            // Đọc dữ liệu từ file mới và hiển thị kết quả
            using (StreamReader reader = new StreamReader(filePath))
            {
                deserializedStudentList = (StudentList)xmlSerializer.Deserialize(reader);
            }

            Console.WriteLine("Danh sách sinh viên sau khi cập nhật:");
            foreach (Student student in deserializedStudentList.Students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
