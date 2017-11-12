using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_To_Hex_Reworked
{
    class User_input
    {
        Calculator Cal = new Calculator();

        private decimal[] a = new decimal[3];
        private string f;
        private int[] numbers = new int[3];
        

        public void input()
        {

            //Provides Instructions to the end user.
            Console.WriteLine("Insert the 3 codes for the RGB Colour System as requested.");
            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Note if a number over or under the range of 0 - 255 is inserted you will have to start over");
            Console.WriteLine("Press Any Key to begin.");
            Console.ReadKey();
            Console.Clear();


            for (int i = 0; i != 3; i++)
            {
                /*if( i == 0 )
                {
                    f = "st";
                }
                else if (i == 1)
                {
                    f = "nd";
                }
                else
                {
                    f = "rd";
                }

                Console.WriteLine($"Insert the {1 + i}{f} number into the console.");*/


                
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(numbers[i]);
                
                while(Number_is_outside_range(numbers[i]))
                {
                    Console.WriteLine("Number is outside range, try again");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(numbers[i]);
                }
                for(int j = 0; j != 10; j++)
                {
                    Console.WriteLine(j);
                }

                Inputted_Variables();
                
            }

        }

        private void Inputted_Variables()//Implementation
        {
            for (int i = 0; i != 3; i++)
            {
                if (a[i] <= 255 && a[i] >= 0)
                {
                    Cal.calculator(a[i]);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("You inserted a value greater or lower than the give range of 0 - 255");
                    Console.WriteLine("Press Any Key To Restart");
                    Console.ReadKey();
                    Console.Clear();
                    input();
                }
            }
        }

        public void RGB_Code()
        {
            Console.WriteLine($"Your unprocessed RGB code is {a[0]},{a[1]},{a[2]}");
        }

        private bool Number_is_outside_range(int number)
        {
            if (number > 255 || number < 0) return true;
            else return false;
        }
    }
}
