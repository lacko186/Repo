using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace jarmupark
{
    internal class Program
    {
        
        class Jarmu
        {
            public static int felhasznaloegyenleg = 212340;
            public static string jarmu = "Jármű";
            public string Azonosito;
            public int gyartasi_ev;
            public string rendszam;
            public double fogyasztas;
            public double futottkm;
            public int aktualiskoltseg;
            public int benzinar = 600;
            public int berletidij = 0;
            public bool szabad = false;
            public int kor;
            public bool fuvaroz = false;

            public Jarmu(string Azonosito, int gyartasi_ev, string rendszam, double fogyasztas, double futottkm, int aktualiskoltseg, int kor)
            {
                this.Azonosito = Azonosito;
                this.gyartasi_ev = gyartasi_ev;
                this.rendszam = rendszam;
                this.fogyasztas = fogyasztas;
                this.futottkm = futottkm;
                this.aktualiskoltseg = aktualiskoltseg;
                this.kor = kor;

            }
        } 

        class Busz: Jarmu
        {
            public int ferohely;
            public double szorzó;
            public int berletidij = 30000;

            public Busz(string Azonosito, int gyartasi_ev, string rendszam, double fogyasztas, double futottkm, int aktualiskoltseg, int kor, int ferohely, double szorzó, int berletidij) : base(Azonosito, gyartasi_ev, rendszam, fogyasztas, futottkm, aktualiskoltseg, kor)
            {

                this.Azonosito = Azonosito;
                this.gyartasi_ev = gyartasi_ev;
                this.rendszam = rendszam;
                this.fogyasztas = fogyasztas;
                this.futottkm = futottkm;
                this.aktualiskoltseg = aktualiskoltseg;
                this.kor = kor;
                this.ferohely = ferohely;
                this.szorzó = szorzó;
                this.berletidij = berletidij;
            }
                
            public void berles()
            {
                if (Jarmu.felhasznaloegyenleg - this.berletidij >= 0)
                {
                    Console.WriteLine($"A Buszt kibérelheted az egyenleged {Jarmu.felhasznaloegyenleg} a levonás után {Jarmu.felhasznaloegyenleg - this.berletidij} ft");
                }
                else { Console.WriteLine("Nincs elegendő összeg a bérléshez"); }

            }


            
        
        }
        class Teherauto : Jarmu
        {
            public int teherbiras;
            public double szorzó;
            public int berletidij = 40000;

            public Teherauto(string Azonosito, int gyartasi_ev, string rendszam, double fogyasztas, double futottkm, int aktualiskoltseg, int kor, int teherbiras, double szorzó, int berletidij) : base(Azonosito, gyartasi_ev, rendszam, fogyasztas, futottkm, aktualiskoltseg, kor)
            {
                this.Azonosito = Azonosito;
                this.gyartasi_ev = gyartasi_ev;
                this.rendszam = rendszam;
                this.fogyasztas = fogyasztas;
                this.futottkm = futottkm;
                this.aktualiskoltseg = aktualiskoltseg;
                this.kor = kor;
                this.teherbiras = teherbiras;
                this.szorzó = szorzó ;
                this.berletidij = berletidij;

            }
            
            public void berles() 
            {
                if (Jarmu.felhasznaloegyenleg - this.berletidij >= 0)
                {
                    Console.WriteLine($"A teherautót kibérelheted az egyenleged {Jarmu.felhasznaloegyenleg} a levonás után {Jarmu.felhasznaloegyenleg- this.berletidij}");
                }
                else { Console.WriteLine("Nincs elegendő összeg a bérléshez"); }
            
            }
            
            

            public override string ToString()
            {
                return $"Teherautó bérlésnél az Azonosító{this.Azonosito}\n gyártási éve: {this.gyartasi_ev} rendszáma: {this.rendszam}\n fogyasztása: {this.fogyasztas} Ennyi km-t futott: {this.futottkm} km \n aktuális költsége: {this.aktualiskoltseg}\n Ennyi idős: {this.kor} \n maximális teherbírása: {this.teherbiras}\n aktuális szorzója: {this.szorzó}\n bértelti díja: {this.berletidij}ft.";
            }
        }
        class Auto : Jarmu
        {
            public int köbcenti;
            public double szorzó;
            public int berletidij = 40000;

            public Auto(string Azonosito, int gyartasi_ev, string rendszam, double fogyasztas, double futottkm, int aktualiskoltseg, int kor, int köbcenti, double szorzó, int berletidij) : base(Azonosito, gyartasi_ev, rendszam, fogyasztas, futottkm, aktualiskoltseg, kor)
            {
                this.Azonosito = Azonosito;
                this.gyartasi_ev = gyartasi_ev;
                this.rendszam = rendszam;
                this.fogyasztas = fogyasztas;
                this.futottkm = futottkm;
                this.aktualiskoltseg = aktualiskoltseg;
                this.kor = kor;
                this.köbcenti = köbcenti;
                this.szorzó = szorzó;
                this.berletidij = berletidij;

            }

            public void berles()
            {
                if (Jarmu.felhasznaloegyenleg - this.berletidij >= 0)
                {
                    Console.WriteLine($"A teherautót kibérelheted az egyenleged {Jarmu.felhasznaloegyenleg} a levonás után {Jarmu.felhasznaloegyenleg - this.berletidij}");
                }
                else { Console.WriteLine("Nincs elegendő összeg a bérléshez"); }

            }
        }
         
        
        static void Main(string[] args)
        {
            

            Teherauto T = new Teherauto("teherABC", 2005, "ABC-123", 20.3, 202312.6, 30000, 19, 7000, 3.4, 60000);


            Console.WriteLine($"{Jarmu.jarmu} Bérlés ");


            Console.WriteLine("Busz, Teherautó, Autó járművekkel rendelkezünk\n\n");
            Console.WriteLine($"Teherautó bérlésnél az Azonosító: {T.Azonosito} \n gyártási éve: {T.gyartasi_ev} rendszáma: {T.rendszam}\n fogyasztása: {T.fogyasztas}\n Ennyi km-t futott: {T.futottkm} km \n aktuális költsége: {T.aktualiskoltseg}\n Ennyi idős: {T.kor} \n maximális teherbírása: {T.teherbiras}\n aktuális szorzója: {T.szorzó}\n bértelti díja: {T.berletidij}ft.");
            Busz b = new Busz("BuszABC", 2008, "CBA-123", 18.3, 300312.3, 40000, 16, 16, 2.4, 80000);
            Console.WriteLine($"\n\n Busz bérlésnél az Azonosító: {b.Azonosito} \n gyártási éve: {b.gyartasi_ev} rendszáma: {b.rendszam}\n fogyasztása: {b.fogyasztas}\n Ennyi km-t futott: {b.futottkm} km \n aktuális költsége: {b.aktualiskoltseg}\n Ennyi idős: {b.kor} \n maximális férőhelye: {b.ferohely}\n aktuális szorzója: {b.szorzó}\n bértelti díja: {b.berletidij}ft.");
            
            Auto A = new Auto("AutoABC", 2020, "DAG-422", 7.1, 124120.3, 40000, 16, 2000, 2.0, 20000);
            Console.WriteLine($"\n\n Autó bérlésnél az Azonosító: {A.Azonosito} \n gyártási éve: {A.gyartasi_ev} rendszáma: {A.rendszam}\n fogyasztása: {A.fogyasztas}\n Ennyi km-t futott: {A.futottkm} km \n aktuális költsége: {A.aktualiskoltseg}\n Ennyi idős: {A.kor} \n Köbcenti: {A.köbcenti} \n aktuális szorzója: {A.szorzó}\n bértelti díja: {A.berletidij}ft.");

            int penz1= Jarmu.felhasznaloegyenleg-T.berletidij;

            int penz2 =Jarmu.felhasznaloegyenleg-b.berletidij;

            int penz3 =Jarmu.felhasznaloegyenleg-A.berletidij;

            if (penz1 >= 0)
            {
                Console.WriteLine($"\nTeherautót tudnál bérelni az aktuális egyenleged a levonás után {penz1} ft\n");
            }
            else { Console.WriteLine("nincs elegendő fedezet a számládon"); }

            if (penz2 >= 0)
            {
                Console.WriteLine($"\nBuszt tudnál bérelni az aktuális egyenleged a levonás után {penz2} ft\n");
            }

            else { Console.WriteLine("nincs elegendő fedezet a számládon"); }


            if (penz3 >= 0)
            {
                Console.WriteLine($"\nAutót tudnál bérelni az aktuális egyenleged a levonás után {penz3} ft\n");
            }

            else { Console.WriteLine("nincs elegendő fedezet a számládon"); }
            Console.ReadKey();
            
        }
            
        }
}
