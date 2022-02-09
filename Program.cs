using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_Esimene_C
{
    class Kordused_Massivid
    {
        static void Main(string[] args)
        {
            /*//Console.OutputEncoding = Encoding.UTF8;VENE KEELE KASUTAMINE!!!!
            int[] arvudd = new int[5];
            int a=0;
            int k=0;
            do
            {
                try
                {
                    Console.WriteLine("Sisesta arv => ");
                    a = int.Parse(Console.ReadLine());
                    arvudd[k] = a;
                    k++;
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp);
                }
            } while (k<5);
            int summa = 0;
            int korr = 1;
            float ariv = 0;
            foreach (int arv in arvudd)
            {
                summa += arv;
                korr *= arv;
                ariv = arv / arvudd.Length,4;
            }
            Console.WriteLine($"Summa = {summa},Korr = {korr},Ariv = {ariv}");
            Console.ReadLine();*/



            /*Random rnd = new Random();
            int N = rnd.Next(1, 100);
            int M = rnd.Next(1, 100);
            Console.WriteLine($"N={N}");
            Console.WriteLine($"M={M}");
            if (N>M)
            {
                int abi = N;
                N = M;
                M = abi;

            }//N<M
            int[] massiv = new int[M-N+1];
            int j = 0;
            for (int i = N; i < M+1; i++)//N...M,massiv[0]...massiv[M-M]
            {
                massiv[j]= i;
                j++;

            }
            foreach (var n_m in massiv)
            {
                Console.Write($"{n_m*n_m,5}");
            }
            Console.ReadLine();*/

            /*char[] Tahed = new char[7] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
                        Console.WriteLine($"Esimene täht on {Tahed[0]}");
                        foreach (char taht in Tahed)
                        {
                            Console.Write($"{taht,3}");
                        }
                        Console.WriteLine("");
                        Random rnd = new Random();
                        int[] arvud = new int[10];
                        for (int i = 0; i < arvud.Length; i++)
                        {
                            arvud[i] = rnd.Next(0, 1000);
                        }

                        foreach (int arv in arvud)
                        {
                            Console.Write($"{arv,20}");
                        }
                        Console.WriteLine();
                        int[,] tabel = new int[5,10];
                        for (int i = 1; i < 21; i++)
                        {
                            Console.Write($"rida {i}: ");
                            for (int j = 1; j < 11; j++)
                            {
                                Console.Write($"koht{j} ");
                            }
                            Console.WriteLine();
                        }
                        Console.ReadLine();*/
        }
    }
}
