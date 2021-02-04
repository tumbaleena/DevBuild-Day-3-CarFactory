using System;

namespace CarFactory
{
    class CarFactory
    {
        public string GetColor()
        {
            Console.Write("What color would you like your car to be? ");
            string carColor = Console.ReadLine();

            return carColor;
        }

        public int HorsePower()
        {
            Console.WriteLine("How many horsies would you like to pull your wagon? ");
            string input = Console.ReadLine();
            int horsies = int.Parse(input);

            return horsies;
        }

        public string Extras()
        {
            Console.Write("Would you like to add a sunroof?(y/n) ");
            string roof = Console.ReadLine();

            Console.Write("How about the hatchback?(y/n) ");
            string hatchback = Console.ReadLine();
            string extras = roof + hatchback;

            if (extras == "yy")
            {
                extras = "a sunroof and hatchback.";
            }
            else if (extras == "yn")
            {
                extras = "a sunroof.";
            }
            else if (extras == "ny")
            {
                extras = "a hatchback.";
            }
            else
            {
                extras = "no extra features.";
            }

            return (extras);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Clarice!");
            CarFactory car = new CarFactory();

            string color = car.GetColor();
            int hp = car.HorsePower();
            string features = car.Extras();
            Console.WriteLine();

            Console.WriteLine($"The car you have built is {color}, has {hp} horsepower, and comes with {features}");

        }
    }
}
