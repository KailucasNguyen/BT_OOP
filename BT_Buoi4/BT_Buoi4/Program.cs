using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Buoi4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPoint[] point = new IPoint[5]
            {
                new Point2D(3,5),
                new Point2D(0,1),
                new Point2D(1,2),
                new Point3D(2,1,4),
                new Point3D(3,9,5)
            };
            ICircle[] circle = new ICircle[5]
            {
                new Circle2D(new Point2D(3,4),5),
                new Circle2D(new Point2D(2,1),1),
                new Circle2D(new Point2D(3,9),6),
                new Circle3D(new Point3D(2,1,3),7),
                new Circle3D(new Point3D(3,9,5),6),
            };
            cauF(point);
            cauG(circle);
            //cauSao(point, circle);
            Console.ReadKey();
        }
        static void cauF(IPoint[] point)
        {
            Console.WriteLine("Cau f)");
            Console.WriteLine("Point 2D:");
            for (int i = 0; i < point.Length; i++)
                if (point[i].GetType() == typeof(Point2D))
                    Console.WriteLine($"Point {i}:{point[i].printPoint()}");
            Console.WriteLine("===============================");
            Console.WriteLine("Point 3D:");
            for (int i = 0; i < point.Length; i++)
                if (point[i].GetType() == typeof(Point3D))
                    Console.WriteLine($"Point {i}:{point[i].printPoint()}");
            Console.WriteLine("===============================");
            Console.WriteLine("Khoang cach giua cac diem 2D:");
            for(int i = 0;i < point.Length - 1; i++)
                for (int j = i + 1;j < point.Length; j++)
                    if (point[i].GetType() == point[j].GetType() && point[i].GetType() == typeof(Point2D))
                        Console.WriteLine($"Khoang cach giua point {i} va point {j} la: {point[i].cal_dist(point[j])}");
            Console.WriteLine("===============================");
            Console.WriteLine("Khoang cach giua cac diem 3D:");
            for (int i = 0; i < point.Length - 1; i++)
                for (int j = i + 1; j < point.Length; j++)
                    if (point[i].GetType() == point[j].GetType() && point[i].GetType() == typeof(Point3D))
                        Console.WriteLine($"Khoang cach giua point {i} va point {j} la: {point[i].cal_dist(point[j])}");
        }
        static void cauG(ICircle[] circle)
        {   
            Console.WriteLine("Cau g)");
            Console.WriteLine("Circle 2D:");
            for (int i = 0; i < circle.Length; i++)
                if (circle[i].GetType() == typeof(Circle2D))
                    Console.WriteLine($"Circle {i}:{circle[i].printCircle()}");
            Console.WriteLine("===============================");
            Console.WriteLine("Circle 3D:");
            for (int i = 0; i < circle.Length; i++)
                if (circle[i].GetType() == typeof(Circle3D))
                    Console.WriteLine($"Circle {i}:{circle[i].printCircle()}");
            Console.WriteLine("===============================");
            Console.WriteLine("Dien tich Cicle 2D:");
            for(int i = 0;i < circle.Length; i++)
                if (circle[i].GetType() == typeof(Circle2D))
                        Console.WriteLine($"Dien tich hinh tron la:{circle[i].cal_area()}");
            Console.WriteLine("===============================");
            Console.WriteLine("Dien tich Cicle 3D:");
            for (int i = 0; i < circle.Length; i++)
                if (circle[i].GetType() == typeof(Circle3D))
                    Console.WriteLine($"Dien tich be mat la: {circle[i].cal_area()}");
        }
        static void cauSao(IPoint[] point, ICircle[] circle)
        {   
            for (int i = 0; i < point.Length; i++)
                for (int j = 0; j < circle.Length; j++)
                {
                    if (point[i] is Point2D && circle[j] is Circle2D)
                    {
                        Point2D p = point[i] as Point2D;
                        Circle2D c = circle[j] as Circle2D;
                        Console.WriteLine(p.cal_dist(c.GetPoint()));
                    }
                        
                }
        }
    }
}
