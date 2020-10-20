using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecturaEnTren
{
    class Program
    {
        static int Main(string[] args)
        {
            //Reading hours
            int kHours;

            //Travel hours
            int nHours;

            //Input
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Ingresar cúal es el número de horas en el tren y el número de horas para leer.");
            string kn = Console.ReadLine();
            int[] HoursArray = NumberArray(kn);

            if (HoursArray[0] >= 1 && HoursArray[0] <= 1000)
            {
                nHours = HoursArray[0];
            }
            else
            {
                Console.WriteLine("\nSe sale del rango\n");
                return 0;
            }


            if (HoursArray[1] >= 1 && HoursArray[1] <= HoursArray[0])
            {
                kHours = HoursArray[1];
            }
            else
            {
                Console.WriteLine("\nSe sale del rango\n");
                return 0;
            }


            Console.WriteLine("\nIngresar cúal es el nivel de luz por cada hora.");
            string HourLevels = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------");

            int[] LightLevel = NumberArray(HourLevels);
            if (LightLevel.Length != nHours)
            {
                Console.WriteLine("\nNúmero de horas incorrecto");
                return 0;
            }
            int min = 100;
            foreach (int i in LightLevel)
            {
                if (i >= 0 && i <= 100)
                {
                    if (i < min && i >= 20)
                    {
                        min = i;
                    }
                }
                else

                {
                    Console.WriteLine("\nNúmero se sale del rango");
                    return 0;
                }
            }

            //Output
            Console.WriteLine("");
            if (min == 100 && !LightLevel.Contains(100))
            {
                Console.WriteLine("Nivel de luz no adecuado para leer en este viaje\n");
                return 0;
            }
            Console.WriteLine(min);
            Console.WriteLine("");


            int pos = 0;
            foreach (int i in LightLevel)
            {
                if (i >= 20)
                {
                    int bi = Array.IndexOf(LightLevel, i, pos);
                    pos++;
                    Console.Write(bi + 1);
                    Console.Write(" ");
                }
            }

            Console.WriteLine("\n");
            return 1;
        }

        public static int[] NumberArray(string input)
        {
            string[] inputStrings = input.Split(' ');
            int[] intArray = new int[inputStrings.Length];

            for (int i = 0; i < inputStrings.Length; i++)
            {
                intArray[i] = int.Parse(inputStrings[i]);

            }
            return intArray;
        }
    }
}
