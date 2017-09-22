using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{

    class program
    {

        public static void Main ( string [] args )
        {

            Console.WriteLine(" Esta é a calculadora V. 7.2 ");
            Console.WriteLine(" *************************** ");

#pragma warning disable CS0168 // Variable is declared but never used
            int soma (int a, int b)
#pragma warning restore CS0168 // Variable is declared but never used
            {

                return a + b;

            }
            Console.ReadKey();

        }

    }

}