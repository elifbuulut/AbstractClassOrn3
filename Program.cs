using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassOrn3
{
    internal class Program
    {
        // 1 adet ortak , mobilya abstract class. 
        //Mobilya da bir adet renk field 
        //OzellikVer() methodu 
        // 2 adet class .Classlar Gardrop ve Masa . Her ikisinin kendine has özellikleri olacak 
        static void Main(string[] args)
        {
            Masa masa = new Masa()
            {
                renk ="siyah",
                sekli ="kare"

            };
            masa.OzellikVer();
            Gardrop gardrop = new Gardrop()
            {
                tipi = "Sürgülü",
                renk = "beyaz"

            };
            gardrop.OzellikVer();



            Console.ReadLine();
        }
    }

    abstract class Mobilya
    {
        private string _renk; // field 
        public string renk   // proportey
        {
            get { return _renk; }
            set { _renk = value; }
        }
        abstract public void OzellikVer(); // abstract methodu


    }

    class Gardrop : Mobilya
    {
        public string tipi;

        public override void OzellikVer()
        {
            Console.WriteLine($"Gardrob {tipi} ve rengi {renk}.");

        }
    }


    class Masa : Mobilya
    {
        public string sekli;
        public override void OzellikVer()
        {
            Console.WriteLine($"Masa {sekli} ve rengi {renk}");


        }
    }
}
