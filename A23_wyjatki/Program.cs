using System;
namespace A23_wyjatki
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. obsługa własnego wuyjątku - przerywa programu
            //Console.WriteLine(dzielenie(3,2));
            //Console.WriteLine(dzielenie(2,0));
            //Console.WriteLine(dzielenie(2,8));
            //2. obsługa własnego wuyjątku - NIE przerywa programu
            try
            {
                //Console.WriteLine(dzielenie(3, 0));
                Console.WriteLine(dzielenie(3, 8));
            }
            //4. W przypadku dzielenia przez zero
            catch (DivideByZeroException e)
            {
                Console.WriteLine("No nieeeee " + e.Message);
            }
            catch (DividedByEightException e)
            {
                Console.WriteLine("8 to nie jest właściwa liczba. Zmień ją. " + e.Message);
            }
            
            catch (Exception e)
            {
                Console.WriteLine("Zastawnów się co robisz. " + e.Message);
            }
            
            finally
            {
                Console.WriteLine("Program został zakończony prawidłowo.");
            }
            //3. linia pokazująca że program jednak się nie przerwał:
            //Console.WriteLine(dzielenie(3,2));
        }
        //static float dzielenie(int a, int b) => (float)a / b;//inny zapis
        //powyższa funkcja może mieć standardowy wygląd:
        
        static int dzielenie(int a, int b)
        {
            //1.- 3.
            
            if (b == 0)
            {
                throw new Exception("Nie wolno dzielić przez zero.");
            } else if (b == 8)
            {
                throw new Exception("Wykonano dzielenie porzez 8");
            } else 
            {
                return a / b;
            }
            
            //4.
            //return a/b;
        }

    }
}