// A27_Gra_Lotto
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace A27_Gra_Lotto
{
    class Program
    {
        static int kumulacja; //wartość kumulacji wygranej
        static int fundusz; //pieniądze przeznaczone na grę
        static Random rnd = new Random(); //los
        static void Main(string[] args)
        {
            { //rozpoznawanie klawiszy
                /* do{ Console.WriteLine(Console.ReadKey().Key.ToString());} while(Console.ReadKey().Key != ConsoleKey.Enter); */}
            int dzien = 0; //ilość dni gry
            Console.WriteLine("Podaj kwotę przeznaczoną na grę: ");
            String kasa = Console.ReadLine();
            fundusz = int.Parse(kasa);//wczytana wartość kasy w formie liczby typu int
            do  //główna pętla gry
            {
                fundusz += fundusz; //zmieniona wartość funduszu
                dzien = 0; //zaczynamy kolejny dzień gry
                ConsoleKey wybor; //klawiszem wybieramy działanie w grze
                do //pętla pomocnicza dla danego dnia
                {
                    kumulacja = rnd.Next(1, 120) * 1000000; //wartość kumulacji
                    dzien++; //koleny dzień gry
                    int losow = 0; //nie posiadamy skreślonych kuponów na starcie
                    List<int[]> kupon = new List<int[]>(); //konstruktor przechowujący listy kuponów
                    do //pętla wykonująca się w danymm dniu
                    {
                        Console.Clear(); //czyszczenie ekranu
                        Console.WriteLine("stan twojego konta: {0},00 zł.", fundusz);
                        WyswietlKupon(kupon);
                        //MENU początkowe
                        Console.WriteLine("Na jednym kuponie maksymalnie możesz mieć 8 losów");
                        Console.WriteLine("1: Skreśl 6 liczb w losowaniu - koszt 3,00 zł. [{0}/8]",losow+1);
                        Console.WriteLine("2: Losowanie - spawdz kupon");
                        Console.WriteLine("3: Zakończ grę");
                        wybor = Console.ReadKey().Key;//wczytujemy klawisz wyboru menu
                        //MENU KONIEC
                        //dodajemy do listy skreślone kupony - kolekcja
                        if(wybor == ConsoleKey.D1 && fundusz >=3 && losow < 8)
                        {
                            //uzupełniamy listę kuponów
                            kupon.Add(PostawLos());
                            fundusz -= 3; //opłata za jedno typowanie
                            losow++;
                        }
                    } while (wybor == ConsoleKey.D1);//koniec skreślania kuponow
                    //sprawdzanie losów
                    Console.Clear();
                    if(kupon.Count > 0)
                    {
                        int wygrana = Sprawdz(kupon);
                        if(wygrana > 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nNiestety nic nie wygrałeś.\n");
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nie skreśliłeś żadnych losów.");
                    }
                    Console.WriteLine("ENTER  - kontynuuj grę");
                    Console.ReadKey();
                } while((fundusz >=3) && (wybor != ConsoleKey.D3));//koniec gry
                Console.Clear(); //czyścimy ekran
                Console.WriteLine("\n Koniec gry:\n - grałeś {0} dni. \n - posiadasz {1},00 zł.", dzien, fundusz);
            } while (Console.ReadKey().Key != ConsoleKey.Enter); //<ENTER>kończy grę

        }

        private static int[] PostawLos()
        {
            throw new NotImplementedException();
        }

        private static void WyswietlKupon(List<int[]> kupon)
        {
            throw new NotImplementedException();
        }

        private static int Sprawdz(List<int[]> kupon)
        {
            throw new NotImplementedException();
        }
    }
}