namespace pr_obiektowe_4bt
{
    public class Samochod
    {
        public string marka = " ";
        public string model = " ";
        public int rok;
        public double pojemnosc, przebieg;

       public Samochod()
        {
            marka = "brak";
            model = "brak";    
            rok = 0;
            pojemnosc = 0;
            przebieg = 0;
        }

        public Samochod(string marka, string mod, int rok, double pojemnosc, double przebieg)
        {
            this.marka = marka;
            model = mod;
            this.rok = rok;
            this.pojemnosc = pojemnosc;
            this.przebieg = przebieg;
        }


        public void wyswietl()
        {
            Console.WriteLine("Marka " + marka + " Model " + model + "\nRok " + rok
                               + " Pojemność " + pojemnosc + " Przebieg " + przebieg + "\n");

        }

        public void zmien(string marka, string mod, int rok, double pojemnosc, double przebieg)
        {
            this.marka = marka;
            model = mod;
            this.rok = rok;
            this.pojemnosc = pojemnosc;
            this.przebieg = przebieg;
        }


        
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Samochod sam1 = new Samochod();
            Samochod sam2 = new Samochod();
            Samochod sam3 = new Samochod("Audi", "A8", 2019, 4.2, 29333);
              
            sam1.marka = "VW";
            sam1.wyswietl();

            sam2.zmien("Peugeot", "3008", 2012, 1.6, 100000);
            sam2.wyswietl() ;

            sam3.wyswietl();


        }

    }


}
