namespace NumbersGame
{
    using System;
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Välkommen. Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök: ");         //  Niklas Sjödin NET23
            Random random = new Random();
            int number = random.Next(1, 20);

            int maxAttempts = 5;

            for (int attempts = 1; attempts <= maxAttempts; attempts++)
            {
                int guess = int.Parse(Console.ReadLine());
                if (guess == number)
                {
                    Console.WriteLine("Woohoo. Du klarade det!");
                    return;
                }
                else if (guess < number)
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!");
                }
                else
                {
                    Console.WriteLine("Tyvärr, du gissade för högt!");
                }
            }
            Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
        }
    }

}