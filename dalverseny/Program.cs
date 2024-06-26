using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dalverseny
{
    internal class Program
    {
        class Osztaly
        {
            public string nev;
            public string szak;
            public int rajtszam;
            public int pontszam;

            public Osztaly(string sor)
            {
                string[] r = sor.Split(';');
                this.nev = r[0];
                this.szak= r[1];
                this.rajtszam = Int32.Parse(r[2]);
                this.pontszam = Int32.Parse(r[3]);

            }
        }
    
        static void Main(string[] args)
        {   int maxpont = 1000;
            Random rnd = new Random();

            
            StreamWriter sw = new StreamWriter("d:\\versenyzo.txt");

            Console.WriteLine("A szóköz kulcsszóval állítható meg a program"); ;
            int a = 0;
            while (a != 1)
            {
                Console.Write(" Add meg a neved: ");
                string nev = Console.ReadLine();

                Console.Write(" Add meg a szakod: ");
                string szak = Console.ReadLine();


                if (nev == " ")
                {
                    a += 1;
                    break;
                }

                
                Console.WriteLine($"neve: {nev} szak: {szak}");
                sw.WriteLine($"{nev};{szak};{rnd.Next(0, 600)};{rnd.Next(0, maxpont)}");
            }sw.Close();

            List<Osztaly> list = new List<Osztaly>();
            StreamReader sr = new StreamReader("D:\\versenyzo.txt");
            while (!sr.EndOfStream) 
            {
                string sor = sr.ReadLine();
                Osztaly o = new Osztaly(sor);
                list.Add(o);
            }
            int legnagyobb = 0;
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].pontszam> legnagyobb)
                {
                    legnagyobb += i;  
          
        }     
            }  
            Console.WriteLine($"a legnagyobb pontszámot '{list[legnagyobb].nev}' szerezte, szakmája: '{list[legnagyobb].szak}'  rajtszáma: '{list[legnagyobb].rajtszam}', pontszáma: '{list[legnagyobb].pontszam}'");
            Console.ReadKey();
        }
    }
}