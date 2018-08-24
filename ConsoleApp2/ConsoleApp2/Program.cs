using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //This will write to the Cosnole
            Console.WriteLine("This will output BuzzFizz using a static class method to the UpperBound of 100.");
            BuzzFizz.StaticOutput(100);
            Console.ReadKey();
            Console.WriteLine();

            //This will write to the Cosnole
            Console.WriteLine("This will output BuzzFizz using an instantiated object of BuzzFizz \n " +
                "to the UpperBound of 150 which is set when the object is constructed.");
            BuzzFizz BF = new BuzzFizz(150);
            BF.ObjectInstanceOutput();
            Console.ReadKey();
            Console.WriteLine();

            //If you wanted to run this Console Application from the command line 
            //by passing an integer value as the first parameter
            Console.WriteLine("This will output BuzzFizz using a static class mehod to the UpperBound of \n " +
                "the int value passed into the console application as the first parameter.");
            int parameter;
            if (args.Count() > 0)
            { 
                if (int.TryParse(args[0], out parameter))
                {
                    BuzzFizz.StaticOutput(Convert.ToInt32(args[0]));
                }
                else
                {
                    Console.WriteLine("Invalid Argument: " + args[0]);
                }
            }
            else
            {
                Console.WriteLine("No Argugment passed into the application.");
            }
        }
    }
}
