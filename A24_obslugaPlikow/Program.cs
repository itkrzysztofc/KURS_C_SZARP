using System;
using System.IO;// klas aobsługi we/wy
namespace A24_obslugaPlikow
{
    public class Program
    {
        static void Main (string[] args)
        {
            //1. tworzenie pliku
            string doPliku = @"plik.txt";
            StreamWriter sw;
            if (!File.Exists(doPliku))
            {
                sw = File.CreateText(doPliku);
                Console.WriteLine("Plik został utworzony");
            }
            else
            {
                sw = new StreamWriter(doPliku, true);
                Console.WriteLine("Plik został otwarty do zapisu / uzupełnienia");
            }
            //2. Wpisanie lini do pliku
            Console.WriteLine("Podaj linię tekstu: ");
            string tekst = Console.ReadLine();
            sw.WriteLine(tekst);
            sw.Close(); //zamknięcie pliku
            //3. otwarcie i odczyt lpliku
            StreamReader sr;
            sr = File.OpenText(doPliku);
            string linia = "";
            int i = 0; //licznik linii
            Console.WriteLine("\nZawartość pliku:\n");
            while((linia = sr.ReadLine()) != null){
                Console.WriteLine(++i + ". " + linia);
            }
            sr.Close();
        }
    }
}