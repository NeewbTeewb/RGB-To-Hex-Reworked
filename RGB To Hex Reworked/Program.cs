using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_To_Hex_Reworked
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //Calls out the two primary classes.
            User_input User = new User_input();
            Compiler compiled = new Compiler();

            //Advises end user what the program will do.
            Console.WriteLine("This program will convert your RGB code to Hexadecimals.");
            Console.WriteLine("Press Any Key To Proceed");
            Console.ReadLine();
            Console.Clear();

            User.input();
            compiled.comiled();

            //Concludes the program.
            Console.WriteLine("Press Any Key To Restart.");
            Console.ReadKey();
            Console.Clear();

            User.input();
        }
    }
}
