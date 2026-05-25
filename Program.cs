using System;

namespace prinde_error
{
    class Program
    {
        static void Main()
        {
            

            try
            {
                Console.WriteLine("Scrieti primul numar");
            int nr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Scrieti al doilea numar");
            int nr2 = Convert.ToInt32(Console.ReadLine());
            int impartire = nr1 / nr2 ;
            Console.WriteLine(impartire);
            }catch (FormatException)
            {
                Console.WriteLine("Scrieti numar dar nu litera");
            }
            finally
            {
                Console.WriteLine("Gata am terminat ");
            }

        }
    }
}