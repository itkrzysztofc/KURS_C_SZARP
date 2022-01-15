// A09 Tablice wielowymiarowe 

using System;

namespace A09_Tablice_wielowymiarowe
{
    class Program
    {
        private const string V = "Jeden";
        private const string X = "Dwa";
        private const string Y = "Trzy";
        private const string Z = "Cztery";

        static void Main(string[] args)
        {
            string[,] tab1 = { 
                { V, X }, 
                { Y, Z }
            };  
            Console.Write(tab1[0, 0] + " ");
            Console.Write(tab1[0, 1] + " ");
            Console.Write(tab1[1, 0] + " ");
            Console.Write(tab1[1, 1] + " ");
            Console.WriteLine();
            // przy użyciu konstruktora - tablica stała
            int[,] tab2 = new int[2, 2] { 
                { 2, 3 }, 
                { 4, 5 } 
            };
            Console.Write(tab2[0, 0]+ " ");
            Console.Write(tab2[0, 1] + " ");
            Console.Write(tab2[1, 0] + " ");
            Console.Write(tab2[1, 1] + " ");
            Console.WriteLine();
            //tablica o trzech wymiarach 3D
            int[,,] tab3 = new int[2, 2, 3] { 
                { { 1, 2 , 3 }, { 4, 5, 6 } }, //zero
                { { 7, 8, 9 }, { 10, 11, 12 } } //jeden
            };
            Console.Write(tab3[0, 0 , 0] + " ");
            Console.Write(tab3[0, 0 , 1] + " ");
            Console.Write(tab3[0, 0 , 2] + " ");
            Console.Write(tab3[0, 1 , 0] + " ");
            Console.Write(tab3[0, 1 , 1] + " ");
            Console.Write(tab3[0, 1 , 2] + " ");
            Console.Write(tab3[1, 0 , 0] + " ");
            Console.Write(tab3[1, 0 , 1] + " ");
            Console.Write(tab3[1, 0 , 2] + " ");
            Console.Write(tab3[1, 1 , 0] + " ");
            Console.Write(tab3[1, 1 , 1] + " ");
            Console.Write(tab3[1, 1 , 2] + " ");
            Console.WriteLine();
            //tablica 2D    'n' x 'm'
            int n = 11;
            int m = 11;
            int[,] tab4 = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    tab4[i, j] = i * j;
                    if(j%m == 0) Console.WriteLine();
                    Console.Write(tab4[i, j] + " ");
                }
            }
            Console.WriteLine();
            //składanie tablic
            int[][] tab5 = new int[2][];//tablica z 2-ch tablic
            tab5[0] = new int[3];//3 elementy typu int
            tab5[1] = new int[5];//5 elementów typu int
            tab5[0][0] = 1;
            tab5[0][1] = 2;
            tab5[0][2] = 3;//koniec tab 3-elemntowej
            tab5[1][0] = 4;
            tab5[1][1] = 5;
            tab5[1][2] = 6;
            tab5[1][3] = 7;
            tab5[1][4] = 8;//koniec tab 5-elemntowej
            for (int i = 0; i < tab5.Length; i++)
            {
                for (int j = 0; j < tab5[i].Length; j++)
                {
                    Console.Write(tab5[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //operacje na tablicach
            int[] tab6 = { -8, 9, -6, 0, 2, 4, 4 };
            Array.Sort(tab6);
            for (int i = 0;i < tab6.Length; i++)
            {
                Console.Write(tab6[i] + " ");
            }
            //Tablica 2D sortowana
            string[] tab7 = { V, X, Y, Z };
            Array.Sort(tab7);// sortuje tylko liczby
            Console.WriteLine(); Console.WriteLine();
            //sortowanie tablicy złożonej
            int[][] tab8 = new int[2][];
            tab8[0] = new int[] { 4, 2 , 9, 5, 7, -9 };
            Array.Sort(tab8[0]);
            tab8[1] = new int[] { 2 , 9, 5 };
            Array.Sort(tab8[1]);
            for (int i = 0; i < tab8.Length; i++)
            {
                for (int j = 0; j < tab8[i].Length; j++)
                {
                    Console.Write(tab8[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}