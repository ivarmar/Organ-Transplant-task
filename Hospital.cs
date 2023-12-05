using System;

internal class Hospital
{
    private int SurvivalRate { get; set; }
    private Random random = new Random();

    public Hospital(int survivalRate)
    {
        SurvivalRate = survivalRate;
        random = new Random();
    }

    public void GenerateSurvival(string userInput)
    {
        var percentageSurvive = RandomSurvival(0, 101);


        if (userInput == "1")
        {
            percentageSurvive = RandomSurvival(40, 101);
            Console.WriteLine($"You have given Bernt your kidney; he has {percentageSurvive}% chance to survive.");
            Console.WriteLine($"Bernt {(percentageSurvive > 50 ? "survived" : "did not survive")}");

        }
        else if (userInput == "2")
        {
            percentageSurvive = RandomSurvival(0, 55);
            Console.WriteLine($"You have refused to give your kidney. Bernt has {percentageSurvive}% chance to survive.");
            Console.WriteLine($"Bernt {(percentageSurvive > 50 ? "survived" : "did not survive")}");
        }
        else
        {
            percentageSurvive = RandomSurvival( 0, 75);
            Console.WriteLine($"The doctors are scrambling to find someone else to donate their kidney. Bernt has {percentageSurvive}% chance.");
            Console.WriteLine($"Bernt {(percentageSurvive > 50 ? "survived" : "did not survive")}");

        }
    }

    private int RandomSurvival(int min, int max)
    {
        return random.Next(min, max);
    }
}


