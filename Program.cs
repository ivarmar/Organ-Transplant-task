using System;

namespace Organ_Transplant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            string userInput;

            while (true)
            {
                Console.WriteLine("There has been an accident; Bernt needs an organ transplant!");
                Console.WriteLine(
                    "Choose one option:\n1. Give him your kidney\n2. Refuse, your organs are your own damnit!\n3. Tell them to find someone else.");

                userInput = Console.ReadLine();

                if (userInput == "1" || userInput == "2" || userInput == "3")
                {
                    var victim = new Hospital(random.Next(1, 101));
                    victim.GenerateSurvival(userInput);
                }
            }
        }
    }
}
