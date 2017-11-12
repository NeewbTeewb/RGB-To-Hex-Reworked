using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_To_Hex_Reworked
{
    class Calculator
    {
        private decimal[] h = new decimal[5];

        Hex_Converter Convert = new Hex_Converter();

        //calculates the RGB code devides by 16.
        public void calculator(decimal n)
        {
            for (int i = 0; i <= 2; i++)private void Inputted_Variables()
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
            {
                h[i] = n / 16;

                for (int e = 3; e <= 5; e++)
                {
                    h[e] = n % 16;
                }

            }
            
        }

        //Sends the Calculated variables to be calculated
        private void conversion()
        {
            for (int i = 0; i <= 2; i++)
            {
              for(int e = 3; e <=5; e++)
                {
                    Convert.Hex_Numbers(h[i]);
                    Convert.Hex_Numbers(h[e]);
                }
            }
        }
    }
}
