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
            //Console.OutputEncoding = Encoding.UTF8;
            Random rnd = new Random();
            Dictionary<string, string> dict = new Dictionary<string, string>();

            List<string> kond1 = new List<string> { "Pärnumaa", "Harjumaa", "Tartumaa", "Valgamaa", "Viljandimaa" };
            List<string> pealinn = new List<string> { "Pärnu", "Tallinn", "Tartu", "Valga", "Viljandi" };
            bool wantTo = true;
            int randInt = 0;
            double score = 0;

            for (int i = 0; i < kond1.Count; i++)
            {
                dict.Add(kond1[i], pealinn[i]);
                dict.Add(pealinn[i], kond1[i]);
            }
            while (wantTo == true)
            {

                Console.WriteLine("Mida sa tahad? Leidke riik ja pealinn - 1, mängige mängu - 2");
                int answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    Console.Write("Sisestage pealinn ja maakond:");
                    string input = Console.ReadLine();
                    if (dict.ContainsKey(input))
                    {
                        Console.WriteLine("Paari " + input + " ja " + dict[input]);
                    }
                    else if (!dict.ContainsKey(input))
                    {
                        Console.WriteLine("Kahjuks pole selles sõnastikus sellist sõna, kas soovite lisada uusi sõnu? jah - 1, ei - 2");
                        answer = int.Parse(Console.ReadLine());
                        if (answer == 1)
                        {
                            Console.WriteLine("Palun sisestage uus maakond");
                            string new1 = Console.ReadLine();

                            Console.WriteLine("Palun sisestage uus pealinn");
                            string new2 = Console.ReadLine();
                            dict.Add(new1, new2);
                            dict.Add(new2, new1);
                        }
                    }
                }
                else if (answer == 2)
                {
                    score = 0;
                    for (int i = 0; i < kond1.Count; i++)
                    {
                        randInt = rnd.Next(1, 3);
                        int b = rnd.Next(1, kond1.Count);
                        if (randInt == 1)
                        {
                            Console.WriteLine("Paari - " + kond1[b]);
                            string userInput = Console.ReadLine();
                            if (pealinn.IndexOf(userInput) == kond1.IndexOf(kond1[b]))
                            {
                                Console.WriteLine("Hämmastav!");
                                score++;
                            }
                        }
                        else if (randInt == 2)
                        {
                            Console.WriteLine("Paari - " + pealinn[b]);
                            string userInput = Console.ReadLine();
                            if (kond1.IndexOf(userInput) == pealinn.IndexOf(pealinn[b]))
                            {
                                Console.WriteLine("Hämmastav");
                                score++;
                            }
                        }
                    }
                    Console.WriteLine(score / kond1.Count * 100 + "%");
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
