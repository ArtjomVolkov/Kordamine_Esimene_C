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
            Console.WriteLine("Kas sa tahad midagi osta? (1/2)");
            int ans = int.Parse(Console.ReadLine());
            if (ans==1)
            {
                Console.WriteLine("Poodis on piim,sai ja leib");
                Console.WriteLine("Kas sa soovib osta piima ? Hind:1.13 => ");
                string piim = Console.ReadLine();
                if (piim.ToUpper()=="JAH")
                {
                    Console.WriteLine("Added...");
                    Console.WriteLine("Kas sa soovib osta saia ? Hind:0.99 => ");
                    string sai = Console.ReadLine();
                    if (sai.ToUpper()=="JAH")
                    {
                        Console.WriteLine("Added...");
                        Console.WriteLine("Kas sa soovib osta leiba ? Hind:0.73 => ");
                        string leib = Console.ReadLine();
                        if (leib.ToUpper()=="JAH")
                        {
                            Console.WriteLine("Added...");
                            float w = (float)(1.13 + 0.99 + 0.73);
                            Console.WriteLine("Price {0} euro", w);
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Remove...");
                    }
                }
                else
                {
                    Console.WriteLine("Remove...");
                }


            }
            else
            {
                Console.WriteLine("Viga...");
                return;
            }
            /*Console.WriteLine("Mis pikkus sa oled? => ");
            float pikk = float.Parse(Console.ReadLine());
            Console.WriteLine("Sa oled naine või mees? (mees=1)(naine=2)");
            int pol = int.Parse(Console.ReadLine());
            if (pikk<=160)
            {
                Console.WriteLine("Sa oled lühike.");
            }
            else if (pikk < 160 || pikk > 190 )
            {
                Console.WriteLine("Sa oled keskmine.");
            }
            else if (pikk>=190)
            {
                Console.WriteLine("Sa oled pikk.");
            }
            Console.ReadKey();
            /*Console.WriteLine("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            int b = int.Parse(Console.ReadLine());
            int S = a * b;
            Console.WriteLine("Pindala = {0}",S);
            Console.WriteLine("Kas soovite tegeda romondi ? => ");
            string remont = Console.ReadLine();
            if (remont.ToUpper() == "JAH" || remont.ToUpper() == "YES")
            {
                Console.WriteLine("Kui palju maksab üks ruutmeeter ? =>");
                int c = int.Parse(Console.ReadLine());
                int Ruut = S * c;
                Console.WriteLine("Põranda vahetamise hind => {0}", Ruut);
                float skid = (float)(Ruut * 0.3);
                int skid1 = (int)(Ruut - skid);
                Console.WriteLine("30% hinnasoodustusega => {0}\nHind koos hinnasoodustusega => {1}", skid,skid1);
                    Console.WriteLine("Kas temperatuur kodus on üle kaheksateistkümne kraadi (18) => (jah/ei)");
                    string temp = Console.ReadLine();
                    if (temp.ToUpper()=="JAH")
                    {
                        Console.WriteLine("Hästi,see on soovitav toasoojus talvel temperatuur.");
                    }
                    else
                    {
                        Console.WriteLine("Again...");
                        return;
                    }
                    Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Viga");
                return;
            }
            Console.ReadLine();


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
