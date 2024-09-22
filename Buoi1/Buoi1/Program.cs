using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    /*static double Max(double x, double y, double z = 0){
      return (x>y)?(x>z?x:z):(y>z?y:z);
    }
    static double MaxAll(**arg){

    }
    static double Sum(double x, double y){
      return x+y;
    }
    static double Sum(double[] arr){
      double sum = 0;
      foreach(double x in arr)
        sum += x;
      //for(int i=0; i<arr.Length; i++)
        //sum += arr[i];
      return sum;
    }
    static string Sum(string x, string y){
      return x+y;
    }*/
    static int[,] img = {
                       {2,  3,  0, 1, 4},
                       {2,  2,  1, 0, 4},
                       {2,  2,  3, 9, 14},
                       {21, 16, 8, 0, 1}
                      };
    static void printmatrix(int[,] input)
    {
        for (int i = 0; i < input.GetLength(0); i++)
        {
            for (int j = 0; j < input.GetLength(1); j++)
                Console.Write("{0, 3}", input[i, j]);
            Console.WriteLine();
        }
    }
    static int[,] padding(int[,] input)
    {
        int[,] maxtrix = new int[input.GetLength(0) + 2, input.GetLength(1) + 2];
        for (int i = 1; i < maxtrix.GetLength(0) - 1; i++)
            for (int j = 1; j < maxtrix.GetLength(1) - 1; j++)
                maxtrix[i, j] = input[i - 1, j - 1];
        for (int i = 0; i < maxtrix.GetLength(1); i++)
        {
            maxtrix[0, i] = maxtrix[1, i];
            maxtrix[maxtrix.GetLength(0) - 1, i] = maxtrix[maxtrix.GetLength(0) - 2, i];
        }
        for (int j = 0; j < maxtrix.GetLength(0); j++)
        {
            maxtrix[j, 0] = maxtrix[j, 1];
            maxtrix[j, maxtrix.GetLength(1) - 1] = maxtrix[j, maxtrix.GetLength(1) - 2];
        }
        return maxtrix;
    }

    static List<int> localwindow(int i, int j, int[,] input)
    {
        List<int> temp = new List<int>();
        for (int m = i - 1; m <= i + 1; m++)
            for (int n = j - 1; n <= j + 1; n++)
                if (m != i || n != j)
                    if (input[m, n] != 0)
                        temp.Add(input[m, n]);

        return temp;
    }
    static int meanfilter(int[,] input)
    {
        int[,] newmatrix = padding(input);
        for (int i = 1; i < newmatrix.GetLength(0) - 1; i++)
            for (int j = 1; j < newmatrix.GetLength(1) - 1; j++)
                if (newmatrix[i, j] == 0)
                {
                    List<int> l = localwindow(i, j, newmatrix);
                    newmatrix[i, j] = mean(l);
                    img[i - 1, j - 1] = mean(l);
                }
        return 0;
    }
    static int mean(List<int> l)
    {
        int sum = 0;
        foreach (int i in l)
            sum += i;
        return sum / l.Count;
    }
    static void Main(string[] args)
    {
        //Console.WriteLine(img[0, 0]);
        /*Console.WriteLine("Nhap x, y:");
        double x = 3, y = 5, z = 1;
        Console.WriteLine(Max(x, y, z));
        Console.WriteLine(Max(x, y));*/

        printmatrix(img);
        Console.WriteLine("\n----\n");
        printmatrix(padding(img));
        console.WriteLine();


        meanfilter(img);
        printmatrix(img);

        Console.ReadKey();
    }
}