using System;

namespace homework_6_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose mode(N = normal or D = detailed): ");
            char Choosemode = char.Parse(Console.ReadLine());
            if (Choosemode == 'N')
            {
                Console.Write("Input water that your drink in 1 day (glass): ");
                double waterGlassThatYouDrink = double.Parse(Console.ReadLine());
                if (waterGlassThatYouDrink >= 8)
                {
                    Console.WriteLine("Good pls drink like this everyday for your health");
                }
                else if (waterGlassThatYouDrink < 8)
                {
                    Console.WriteLine("Drink more water pls");
                    Console.WriteLine("You should drink 8-10 glass per day");
                }
            }
            else if (Choosemode == 'D')
            {
                Console.Write("Input water that your drink in 1 day (milliliter): ");
                double waterThatYouDrink = double.Parse(Console.ReadLine());
                Console.Write("Input Your weight(Kilogram): ");
                double Weight = double.Parse(Console.ReadLine());

                double RecommendDrinkwater = Weight * 2.2 * 30 / 2;
                if (waterThatYouDrink > RecommendDrinkwater)
                {
                    Console.WriteLine("Good pls drink like this everyday for your health");
                }
                else
                    Console.WriteLine("Drink more water pls");
                Console.WriteLine("You should drink: {0} milliliter", RecommendDrinkwater);
            }
            else
                Console.WriteLine("pls close program to restart sorry for unconvenient");
        }
    }
}
