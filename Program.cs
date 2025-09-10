using System.Diagnostics.Metrics;

namespace gitDemoGrupp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Siffra att kolla: ");
                int inputNumber = int.Parse(Console.ReadLine());

                if (inputNumber == 0)
                {
                    break;
                }
                else
                {
                    isEven(inputNumber);
                }
            }
        }

        static bool isEven(int number)
        {
            //X []  Skapa en metod som ska heta “IsEven” och returnerar följande:
            //- []  `True` om talet är jämnt, `False` annars.
            //- []  Använd en loop i `Main` metoden för att låta användaren testa flera tal tills de skriver in `0`
            //- []  Om användaren skriver `0` avslutas programmet.

            if (number % 2 == 0)
            {
                Console.WriteLine("true");
                return true;
            }
            else if (number % 2 != 0)
            {
                Console.WriteLine("false");
                return false;
            }
            else 
            {
                Console.WriteLine("Ingen resultat");
                return false;
            }
        }
    }
}
