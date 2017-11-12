using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_To_Hex_Reworked
{
    class Compiler
    {
        Hex_Converter Conv = new Hex_Converter();
        User_input RGB = new User_input();

        string h;

        //Compiles String variables from the converter and User input for the console.
        public void comiled()
        {
            Conv.Converted(ref h);
            RGB.RGB_Code();
            Console.WriteLine($"Your Hexadecimal Number is #{h}");
        }


    }
}
