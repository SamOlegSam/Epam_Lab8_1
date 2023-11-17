using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, m1, m2; 
            //------------------первый массив---------------------------
            Console.Write("Введите длину первой матрицы: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Введите высоту первой матрицы: ");
            m1 = int.Parse(Console.ReadLine());
                        
            int[,] ara1 = new int[n1, m1];
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m1; j++)
                {
                    Console.Write("Введите элемент ["+ i+", "+j+"]: ");
                    ara1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //-----------------второй масссив------------------------
            Console.Write("Введите длину второй матрицы: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Введите высоту второй матрицы: ");
            m2 = int.Parse(Console.ReadLine());

            int[,] ara2 = new int[n2, m2];
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    Console.Write("Введите элемент [" + i + ", " + j + "]: ");
                    ara2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //----------------вывод матриц---------------
            Console.WriteLine("Первая матрица:");
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m1; j++)
                {
                    Console.Write(ara1[i, j] +"\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Вторая матрица:");
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    Console.Write(ara2[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
