using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[,] arr = new string[n, n];
            if (n % 2 == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {


                        if (j == (n - 1) / 2)
                        {
                            arr[i, j] = "*";
                            Console.Write(arr[i, j] + " ");
                        }
                        else if (i == (n - 1) / 2)
                        {
                            arr[i, j] = "*";
                            Console.Write(arr[i, j] + " ");
                        }
                        else if (i == j)
                        {
                            arr[i, j] = "*";
                            Console.Write(arr[i, j] + " ");
                        }
                        else if (i + j == n - 1)
                        {
                            arr[i, j] = "*";
                            Console.Write(arr[i, j] + " ");
                        }
                        else
                        {
                            arr[i, j] = ".";
                            Console.Write(arr[i, j] + " ");
                        }

                    }
                    Console.WriteLine();
                }

            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {


                        if ((j == n / 2) | j == (n / 2 - 1))
                        {
                            arr[i, j] = "*";
                            Console.Write(arr[i, j] + " ");
                        }
                        else if ((i == n / 2) | i == (n / 2 - 1))
                        {
                            arr[i, j] = "*";
                            Console.Write(arr[i, j] + " ");
                        }
                        else if (i == j)
                        {
                            arr[i, j] = "*";
                            Console.Write(arr[i, j] + " ");
                        }
                        else if (i + j == n - 1)
                        {
                            arr[i, j] = "*";
                            Console.Write(arr[i, j] + " ");
                        }
                        else
                        {
                            arr[i, j] = ".";
                            Console.Write(arr[i, j] + " ");
                        }

                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
