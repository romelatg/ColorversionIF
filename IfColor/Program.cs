using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace IfColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //functColor("Amarillo");
            functColor("Morado");
            //functColor("Rosa");
            //functColor("Azul");
            //functColor("Blanco");

            Console.ReadLine();
        }

        static void functColor(string color)
        {
            if(color.ToLower() == "amarillo")
            {
                for (int i = 1; i < 13; i++)
                {
                    Console.WriteLine("2x{0}={1}",i,2*i);
                }
            }
            else if (color.ToLower() == "morado")
            {
                for (int i = 1; i < 13; i++)
                {
                    Console.WriteLine("7x{0}={1}", i, 7 * i);
                }
            }
            else if (color.ToLower() == "rosa")
            {
                for (int i = 1; i < 13; i++)
                {
                    Console.WriteLine("9x{0}={1}", i, 9 * i);
                }
            }
            else if (color.ToLower() == "azul")
            {
                for (int i = 1; i < 13; i++)
                {
                    Console.WriteLine("6x{0}={1}", i, 6 * i);
                }
            }
            else if (color.ToLower() == "blanco")
            {
                for (int i = 1; i < 13; i++)
                {
                    Console.WriteLine("12x{0}={1}", i, 12 * i);
                }
            }
        }
    }
}
