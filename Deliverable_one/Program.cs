using System;

namespace Deliverable_one
{
    class Program
    {
        static void Main(string[] args)
       
        {
            string other_calculation;
            do
            {

                Console.WriteLine("Please provide a measurement type:");
                string measurement_type = Console.ReadLine();

                Console.WriteLine("Please provide a measurement amount:");
                string measurement_amount = Console.ReadLine();
                float amount = float.Parse(measurement_amount);

                if (measurement_type == "inch")
                {
                    amount = (amount * 3.5f);
                    Console.WriteLine(amount + " Fidget Spinners");
                }
                if (measurement_type == "fidget spinner")
                {
                    amount = (amount / 3.5f);
                    Console.WriteLine(amount + " Inches");
                }

                if (measurement_type == "foot")
                {
                    amount = (amount * 5);
                    Console.WriteLine(amount + " Memes");
                }
                if (measurement_type == "meme")
                {
                    amount = (amount / 5);
                    Console.WriteLine(amount + " Feet");
                }

                Console.WriteLine("Would you like to do another calculation?");
                other_calculation = Console.ReadLine();




            }
            while (other_calculation == "yes");
        }
    }
}
