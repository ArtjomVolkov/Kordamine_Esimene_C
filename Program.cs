using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_Esimene_C
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            int b = int.Parse(Console.ReadLine());
            int S;
            S = a * b;
            Console.WriteLine("Pindala",S);
            Console.ReadKey();
            /*Console.WriteLine("Tere nimeta nime pinginaabri => ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Nimeta nime pinginaabri => ");
            string name2 = Console.ReadLine();
            if ((name1=="Artjom" && name2=="Timofei") || (name1=="Artjom" && name2=="Denis") || (name1=="German" && name2=="Kevin") || (name1 == "Timofei" && name2 == "Artjom") || (name1 == "Denis" && name2 == "Artjom") || (name1 == "Kevin" && name2 == "German"))
            {
                Console.WriteLine("Nad on pinginaabrid!");
            }
            else
            {
                Console.WriteLine("Nad ei ole pinginaabrid!");
            }
            Console.ReadKey();*/
            /*double hind = 10;
            string pilet= "täispilet";
            Console.WriteLine("Mis on sinu nimi?");
            string eesnimi = Console.ReadLine();
            Console.Write("Tere tulemast! {0}", eesnimi);
            if (eesnimi.ToLower()=="juku")
            {
                Console.WriteLine(",tule külla! Kas lähme kinno?");
                string vastus = Console.ReadLine();
                if (vastus.ToUpper()=="JAH" || vastus.ToUpper()=="YES" || vastus.ToUpper()=="ДА")
                {
                    Console.WriteLine("Kui vana sa oled?");
                    int vanus = int.Parse(Console.ReadLine());
                    if (vanus < 0 || vanus > 108)
                    {
                        Console.WriteLine("Viga!");
                        pilet = "viga";
                    }
                    else if (vanus<6 || vanus>=65)
                    {
                        hind -= hind * 1;
                        pilet = "tasuta";
                    }
                    else if (vanus>=6 && vanus<12)
                    {
                        hind -= hind * 0.3;
                        pilet = "lastepilet";
                    }
                    else if (vanus>=12 && vanus<18)
                    {
                        hind -= hind * 0.1;
                        pilet = "koolipilet";
                    }
                    else if (vanus >19 && vanus<64)
                    {
                        hind -= hind;
                        pilet = "täispilet";
                    }
                    char[] tahed = eesnimi.ToCharArray();
                    int i = 0;
                    eesnimi = "";
                    foreach (var t in tahed)
                    {
                        if (i==0)
                        {
                            eesnimi += t.ToString().ToUpper();
                        }
                        else
                        {
                            eesnimi += t.ToString().ToLower();
                        }
                        i += 1;
                    }
                    Console.WriteLine("{0}, sul on {1} pilet ja vaja maksta {2} euro", eesnimi, hind, pilet);
                }
                else
                {
                    Console.WriteLine("Mõtle välja ise....");
                }
            }
            else
            {
                Console.WriteLine(",mind täna kodus pole! :(");
            }
            Console.ReadKey();*/
        }
    }
}
