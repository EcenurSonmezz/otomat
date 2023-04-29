using System;
using System.Reflection.PortableExecutable;

namespace otomat
{
    class kahve
    {
        protected int sutMiktari;
        protected int kahveMiktari;

        public void SutEkle(int miktar)
        {
            Console.WriteLine("süt ekleniyor: " + miktar + "ml");
            sutMiktari += miktar;
        }

        public void KahveEkle(int miktar)
        {
            Console.WriteLine("kahve ekleniyor: " + miktar + "ml");
        kahveMiktari  += miktar;
        }

        public virtual void otomat()
        {
            SutEkle(sutMiktari);
            KahveEkle(kahveMiktari);
        }
    }

    class Espresso : kahve
    {
        public Espresso()
        {
            sutMiktari = 0;
            kahveMiktari = 30;
        }
    }

    class Latte : kahve
    {
        public Latte()
        {
            sutMiktari = 100;
            kahveMiktari = 30;
        }
    }

    class Cappuccino : kahve
    {
        public Cappuccino()
        {
            sutMiktari = 50;
            kahveMiktari = 30;
        }
    }

    class Americano : kahve
    {   
        public Americano()
        {
            sutMiktari = 0;
            kahveMiktari = 60;
        }
    }

    class Mocha : kahve
    {
        public Mocha()
        {
            sutMiktari = 50;
            kahveMiktari = 30;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen seçim yapınız?");
            Console.WriteLine("1. Espresso");
            Console.WriteLine("2. Latte");
            Console.WriteLine("3. Cappuccino");
            Console.WriteLine("4. Americano");
            Console.WriteLine("5. Mocha");

            int secim = int.Parse(Console.ReadLine());
            kahve coffee = null;

            if (secim == 1)
            {
                coffee = new Espresso();
            }
            else if (secim == 2)
            {
                coffee = new Latte();
            }
            else if (secim == 3)
            {
                coffee = new Cappuccino();
            }
            else if (secim == 4)
            {
                coffee = new Americano();
            }
            else if (secim == 5)
            {
                coffee = new Mocha();
            }
            else
            {
                Console.WriteLine("lütfen yeniden seçim yapınız");
            }

            if (coffee != null)
            {
                coffee.otomat();
                Console.WriteLine("afiyet olsun");
            }

            Console.ReadLine();
        }
    }


}
