using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    enum Marka { Opel, Audi, BMW };
    enum DodatnaOprema { klima, alufelge, blutooth};

    struct Auto
    {
        public int godina;
        public string boja;
        public int km;
        public double cijena;
        public string marka;
        public string oprema;
    }


    class Program
    {

        static List<Auto> ListaVoizla = new List<Auto>();
        static DateTime godina = new DateTime();

        static void Main(string[] args)
        {

            Auto A0 = new Auto
            {
                marka = Marka.Audi.ToString(),
                godina = 1999,
                boja = "crvena",
                km = 129492,
                oprema=DodatnaOprema.alufelge.ToString(),
                cijena = 29.123

            };
            ListaVoizla.Add(A0);

            Auto A1 = new Auto
            {
                marka = Marka.BMW.ToString(),
                godina = 1945,
                boja = "crna",
                km = 480265,
                oprema=DodatnaOprema.blutooth.ToString(),
                cijena = 5897

            };
            ListaVoizla.Add(A1);

            Auto A2 = new Auto
            {
                marka = Marka.Opel.ToString(),
                godina = 2014,
                boja = "zuta",
                km = 508798,
                oprema=DodatnaOprema.klima.ToString(),
                cijena = 9.123

            };
            ListaVoizla.Add(A2);

            int br = 0;
            double prosjecnaCijena = 0.0;
            double ukupnaCijena = 0.0;
            int ukupnaGodina = 0;
            double prosjecnaStarost = 0.0;
            DateTime T = DateTime.Now;

            foreach (Auto o in ListaVoizla)
            {
                br++;
                ukupnaCijena += o.cijena;
                prosjecnaCijena += ukupnaCijena / br;
                ukupnaGodina += DateTime.Now.Year - o.godina;
                Console.WriteLine("Marka: {0} Boja: {1} Kilometraza: {2}  Dodatna oprema {3} Cijena: {4} Godina: {5} Starost: {6} god.", o.marka, o.boja, o.km, o.oprema, o.cijena, o.godina, ukupnaGodina);
                prosjecnaStarost = ukupnaGodina / br;

            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ukupna cijena: {0}: ", ukupnaCijena);
            Console.WriteLine("Prosjecna cijena: {0}: ", prosjecnaCijena);
            Console.WriteLine("Prosjecna starost automobila: {0}: ", prosjecnaStarost);
            Console.ReadLine();



        }
    }
}
