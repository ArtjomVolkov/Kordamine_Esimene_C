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
            /*for (int i = 1; i < 10; i++)
            {
                Console.Write(i + "   |  ");
                for (int j = 1; j < 11; j++)
                {
                    Console.Write("\t" + i * j);
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
            Console.ReadLine();*/
            /*Console.WriteLine("Купи слона!");
            string slon = Console.ReadLine();
            if (slon != "слон")
            {
               Console.WriteLine("Все так говорят "+slon+ "а ты купи!");
               Console.ReadLine();
            }
            Console.WriteLine("Слон теперь твой!");
            Console.ReadLine();

            Random rnd = new Random();
            int i = rnd.Next(10);
            int c = 1;
            Console.WriteLine("Компьютер загадал число от 0 до 9. Попробуйте отгодать его за три попытки.");
            Console.WriteLine("Введите первое число:");
            int j = Convert.ToInt32(Console.ReadLine());
            while (c <= 3)
            {
                if (i == j)
                {
                    Console.WriteLine("Да! Компьютер загадал число " + j + "!");
                    break;
                }
                else
                {
                    c++;
                    if (c == 4)
                    {
                        Console.WriteLine("Увы, вы не отгодали загаданное число. Это было число " + i + "!");
                        break;
                    }
                    Console.WriteLine("Нет, это не число " + j + "! Попытка № " + c + ":");
                    j = Convert.ToInt32(Console.ReadLine());*/

            /*Console.ReadLine();*/
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
            Console.OutputEncoding = Encoding.UTF8;
            Random rnd = new Random();
            Dictionary<string, string> dict = new Dictionary<string, string>();

            List<string> strana = new List<string> { "Estonia", "Russia", "England", "Germany", "Finland" };
            List<string> kond = new List<string> { "Tallinn", "Moscow", "London", "Berlin", "Helsinki" };
            bool wantTo = true;
            int randInt = 0;
            double score = 0;

            for (int i = 0; i < strana.Count; i++)
            {
                dict.Add(strana[i], kond[i]);
                dict.Add(kond[i], strana[i]);
            }
            while (wantTo == true)
            {

                Console.WriteLine("Что ты хочешь? Найти страну и столицу - 1, играть в игру - 2");
                int answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    Console.Write("Введи столицу и страну: ");
                    string input = Console.ReadLine();
                    if (dict.ContainsKey(input))
                    {
                        Console.WriteLine("Пара " + input + " это " + dict[input]);
                    }
                    else if (!dict.ContainsKey(input))
                    {
                        Console.WriteLine("К сожалению, в этом словаре нет такого слова, вы хотите добавить новые слова? да - 1, нет - 2");
                        answer = int.Parse(Console.ReadLine());
                        if (answer == 1)
                        {
                            Console.WriteLine("Введите новую страну, пожалуйста");
                            string new1 = Console.ReadLine();

                            Console.WriteLine("Введите новую столицу, пожалуйста");
                            string new2 = Console.ReadLine();
                            dict.Add(new1, new2);
                            dict.Add(new2, new1);
                        }
                    }
                }
                else if (answer == 2)
                {
                    score = 0;
                    for (int i = 0; i < strana.Count; i++)
                    {
                        randInt = rnd.Next(1, 3);
                        int b = rnd.Next(1, strana.Count);
                        if (randInt == 1)
                        {
                            Console.WriteLine("Пара - " + strana[b]);
                            string userInput = Console.ReadLine();
                            if (kond.IndexOf(userInput) == strana.IndexOf(strana[b]))
                            {
                                Console.WriteLine("Замечательно!");
                                score++;
                            }
                        }
                        else if (randInt == 2)
                        {
                            Console.WriteLine("Пара - " + kond[b]);
                            string userInput = Console.ReadLine();
                            if (strana.IndexOf(userInput) == kond.IndexOf(kond[b]))
                            {
                                Console.WriteLine("Замечательно!");
                                score++;
                            }
                        }
                    }
                    Console.WriteLine(score / strana.Count * 100 + "%");
                }
            }
            List<string> tooded = new List<string>();
            tooded.Add("leib");
            tooded.Add("piim");
            tooded.Add("õun");
            List<double> kalorid = new List<double>();
            kalorid.Add(265);
            kalorid.Add(42);
            kalorid.Add(52);
            Console.WriteLine("Olete naine või mees? (naine/mees)");
            string soo = Console.ReadLine();
            Console.WriteLine("Palun sisetage oma kaal, pikkus ja vanus");
            int kaala = int.Parse(Console.ReadLine());
            double pikkus = double.Parse(Console.ReadLine());
            int vanus = int.Parse(Console.ReadLine());
            Console.WriteLine("Passiivne elustiil/1, Vähe tegevust/2, Mõõdukas aktiivsus/3, Kõrge aktiivsus/4, Väga kõrge aktiivsus/5");
            string sport = Console.ReadLine();
            double BOO = 0;
            double calories = 0;
            if (soo == "mees")
            {
                BOO = 66 + (13.7 * kaala) + (5 * pikkus) - (6.8 * vanus);
            }
            else if (soo == "naine")
            {
                BOO = 655 + (9.6 * kaala) + (1.8 * pikkus) - (4.7 * vanus);
            }
            if (sport == "1")
            {
                calories = BOO * 1.2;
            }
            else if (sport == "2")
            {
                calories = BOO * 1.375;
            }
            else if (sport == "3")
            {
                calories = BOO * 1.55;
            }
            else if (sport == "4")
            {
                calories = BOO * 1.725;
            }
            else if (sport == "5")
            {
                calories = BOO * 1.9;
            }
            Console.WriteLine($"Teie kalorite norm päevas - {Math.Round(calories, 2)}");
            foreach (var item in tooded)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            foreach (int toode in kalorid)
            {
                Console.WriteLine(Math.Round(calories / toode, 2));
            }
        }
    }
}
