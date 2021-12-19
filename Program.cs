using System;

namespace Kaluklator
{
    class Liczenie
    {
        static void Main(string[] args)
        {
            try
            {


                
                Console.WriteLine("Witam w kalkulatorze");

                
                Console.WriteLine("Proszę wpisać pierwszą liczbę.");

               
                var a = WpisanaLiczba();

               
                Console.WriteLine("Prosze wpisać jaką operacje checie wykorzystać.\nObecne operacje to:'+', '-', '*', '/'.");

                
                var operacje = Console.ReadLine();

                
                Console.WriteLine("Proszę wpisać drugą liczbę.");

                
                var b = WpisanaLiczba();

                
                var rezultat = Obliczanie(a, b, operacje);

                

                Console.WriteLine($"Wynik Twojego działania to: {rezultat}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nie dziel przez zero.");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static int WpisanaLiczba()
        {
            if (!int.TryParse(Console.ReadLine(), out int input))
                throw new Exception("Podana wartość nie jest liczbą");

            return input;
        }

        private static double Obliczanie(double a, double b, string operacje)
        {


            Console.WriteLine("Nie mozna dzielić przez 0 popraw wynik");



            switch (operacje)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    if (b == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    else
                        return a / b;
                default:
                    throw new Exception("Wybrałeś złą operację!"); ;

            }

           
        }


    }
}
