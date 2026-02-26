using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PAW_seminare
{
    class seminar1
    {
        public static void Main()
        {
            Console.WriteLine("Hello, World!");
            Console.Write("introduceti numele: ");
            //string Nume = Console.ReadLine();
            string Nume = "ana";
            //Console.WriteLine(Nume);
            Console.Write("varsta: ");
            //int Varsta = Convert.ToInt32(Console.ReadLine());
            int Varsta = 2;
            //Console.WriteLine(Varsta);
            Console.WriteLine(Nume + " " + Varsta);
            Console.WriteLine("ati introdus {0} cu varsta {1}", Nume, Varsta);
            Console.WriteLine($"ati introdus {Nume} cu varsta {Varsta}, afisare cu $");
            Console.WriteLine();

            int[] vector = new int[3] { 1, 2, 3 };
            foreach (int i in vector)
                Console.Write(i + " ");
            Console.WriteLine();
            for (int i = 0; i < vector.Length; i++)
                Console.Write(vector[i] + " ");
            Console.WriteLine();
            Console.WriteLine();

            //mutabilitate
            int[] vector1 = new int[4] { 11, 22, 33, 44 };
            int[] vector2 = vector1;
            vector1[2] = 99;
            Console.WriteLine("v1\t|v2\n--------|--------");
            for (int i = 0; i < vector1.Length; i++)
                Console.WriteLine("{0}\t|{1}", vector1[i], vector2[i]);
            Console.WriteLine();

            //imutabilitate
            int[] vector3 = new int[vector1.Length];
            for (int i = 0; i < vector3.Length; i++)
                vector3[i] = vector1[i];
            vector1[1] = 77;
            Console.WriteLine("v1\t|v2\n--------|--------");
            for (int i = 0; i < vector1.Length; i++)
                Console.WriteLine("{0}\t|{1}", vector1[i], vector3[i]);
            Console.WriteLine();

            //clonare
            int[] vector4 = (int[])vector1.Clone();
            vector1[0] = 0;
            Console.WriteLine("v1\t|v2\n--------|--------");
            for (int i = 0; i < vector1.Length; i++)
                Console.WriteLine("{0}\t|{1}", vector1[i], vector4[i]);
            Console.WriteLine();

            int[,] matrice = new int[3, 2] { { 1, 2 }, { 2, 3 }, { 1, 3 } };
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                    Console.Write(matrice[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();

            int[][] matricez = new int[3][];
            matricez[0] = new int[2] { 1, 2 };
            matricez[1] = new int[5] { 1, 2, 3, 4, 5 };
            matricez[2] = new int[3] { 1, 2, 3 };
            for(int i = 0; i < matricez.Length; i++)
            {
                for (int j = 0; j < matricez[i].Length; j++)
                    Console.Write(matricez[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();

            List<int> lista = new List<int>();
            lista.Add(32);
            lista.Add(12);
            lista.Add(11);
            lista.Add(19);
            foreach (int i in lista)
                Console.WriteLine(i);
            Console.WriteLine();
            lista.Reverse();
            foreach (int i in lista)
                Console.WriteLine(i);
            Console.WriteLine();
            lista.Sort();
            foreach (int i in lista)
                Console.WriteLine(i);
            Console.WriteLine();

            int a = 1;
            int b = 2;
            Console.WriteLine(a + " " + b);
            seminar1 s1 = new seminar1();
            s1.swap(ref a, ref b);
            Console.WriteLine(a + " " + b);

        }
        public void swap(ref int a, ref int b)
        {
            int aux; 
            aux = a;
            a = b;
            b = aux;
        }

    }
}
