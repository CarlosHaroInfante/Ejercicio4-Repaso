using System.ComponentModel.DataAnnotations.Schema;

namespace Ejercicio4Repaso{


    class Program
    {

        public static void Main(string[] args) {


            int[,] num1 = new int[3, 2];

            Random num = new Random();

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 2; j++)
                {
                    num1[i, j] = num.Next(1, 100);
                }

            }
            
            mostrar(num1);
            Console.WriteLine("----------");
            ordenar(num1);
            Console.WriteLine("----------");
            mostrar(num1);

        }

        public static void mostrar(int[,] num1)
        {
            for (int i = 0;i < num1.GetLength(0); i++)
            {

                for (int j = 0;j < num1.GetLength(1); j++)
                {

                    Console.Write(num1[i,j]);
                }
                Console.WriteLine();


            }


        }

        public static void ordenar(int[,] num1)
        {
            for (int j = 0; j < num1.GetLength(1); j++)
            {
                for (int i = 0; i < num1.GetLength(0) - 1; i++)
                {
                    for (int k = i+1; k < num1.GetLength(1); k++)
                    {
                        if (num1[i, j] > num1[k, j])
                        {
                            int a = num1[i, j];
                            num1[i, j] = num1[k, j];
                            num1[k, j] = a; 
                        }
                    }
                }
            }
        }

    }


}
