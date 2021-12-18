using System;

namespace Kaluklator
{
    class Liczenie
    {
        static void Main(string[] args)
        {
            try
            {


                //1. Wyświetlenie nagłowka - opis aplikacji
                Console.WriteLine("Witam w kalkulatorze");

                //2. Prośba o podanie 1 liczby
                Console.WriteLine("Proszę wpisać pierwszą liczbę.");

                //3. Pobranie liczby od użytkownika
                var a = WpisanaLiczba();

                //4. Prośba o podanie działania
                Console.WriteLine("Prosze wpisać jaką operacje checie wykorzystać.\nObecne operacje to:'+', '-', '*', '/'.");

                //5. Pobranie wybranego działania od użytkownika
                var operacje = Console.ReadLine();

                //6. Prośba o podanie 2 liczby
                Console.WriteLine("Proszę wpisać drugą liczbę.");

                //7. Pobranie liczby od użytkownika
                var b = WpisanaLiczba();

                //8. Wykonanie obliczeń
                var rezultat = Obliczanie(a, b, operacje);

                //9. Wyświetlenie wyniku użytkownikowi

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
