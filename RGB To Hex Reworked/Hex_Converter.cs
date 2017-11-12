using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_To_Hex_Reworked
{
    class Hex_Converter
    {
        private string[] h = new string[6];

        public void Hex_Numbers(decimal n)
        {
            for (int i = 0; i <= 5; i++)
            {

                if (n == 10)
                {
                    h[i] = "A";
                }

                else if (n == 11)
                {
                    h[i] = "B";
                }

                else if (n == 12)
                {
                    h[i] = "C";
                }

                else if (n == 13)
                {
                    h[i] = "D";
                }

                else if (n == 14)
                {
                    h[i] = "E";
                }

                else if (n == 15)
                {
                    h[i] = "F";
                }
                else
                {
                    h[i] = n.ToString();
                }
            }

        }

        private string final;
        public string Converted(ref string a)
        {
            for (int i = 0; i <= 2; i++)
            {
                for (int c = 3; c <= 5; c++)
                {
                    final += h[i] + h[c];
                }
            }

            return a = final;

        }
    }
}
