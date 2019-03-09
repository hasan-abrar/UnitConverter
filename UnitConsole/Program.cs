using System;

namespace UnitConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Unit to convert!");
            Console.WriteLine("Enter 1 for Temprature, 2 for Volume");
            string unitMain = Console.ReadLine();
            string unitFrom = "";
            string unitTo = "";
            string unitVal = "0";

            try
            {
                if (unitMain == "1")
                {
                    Console.WriteLine("Enter From Unit like one of from Fahrenheit/Celsius/Kelvin ");
                    unitFrom = Console.ReadLine();

                    Console.WriteLine("Enter To Unit like one of from Fahrenheit/Celsius/Kelvin");
                    unitTo = Console.ReadLine();


                    Console.WriteLine("Enter Unit value like greater than 0");
                    unitVal = Console.ReadLine();


                    Units unitObj = new Temperature();
                    double results = unitObj.ConvertUnit(double.Parse(unitVal), unitFrom.ToLower(), unitTo.ToLower());

                    Console.WriteLine("{0} ({1}) = {2} ({3})", unitFrom, unitVal, unitTo, results.ToString());
                    Console.ReadLine();
                }
                else if (unitMain == "2")
                {
                    Console.WriteLine("Enter From Unit like one of from Litre/Millilitre/USgal");
                    unitFrom = Console.ReadLine();

                    Console.WriteLine("Enter To Unit like one of from Litre/Millilitre/USgal");
                    unitTo = Console.ReadLine();

                    Console.WriteLine("Enter Unit value like greater than 0");
                    unitVal = Console.ReadLine();


                    Units unitObj = new Volume();
                    double results = unitObj.ConvertUnit(double.Parse(unitVal), unitFrom.ToLower(), unitTo.ToLower());

                    Console.WriteLine("{0} ({1}) = {2} ({3})", unitFrom, unitVal, unitTo, results.ToString());
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid Unit");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("Invalid operation");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            
            


        }
    }
}
