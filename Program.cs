// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace WerkenMetArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mijnArray = new int[4];
            VulArray(mijnArray);
            ToonArray(mijnArray);

            Console.WriteLine("Voeg enkele extra elementen toe:");
            VoegElementToe(ref mijnArray, 5);
            VoegElementToe(ref mijnArray, 6);
            VoegElementToe(ref mijnArray, 7);
            ToonArray(mijnArray);

            Console.ReadLine();
        }

        static void VulArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
        }

        static void VoegElementToe(ref int[] array, int waarde)
        {
            int nieuweLengte = array.Length + 1;
            int[] nieuweArray = new int[nieuweLengte];

            for (int i = 0; i < array.Length; i++)
            {
                nieuweArray[i] = array[i];
            }

            nieuweArray[nieuweLengte - 1] = waarde;
            array = nieuweArray;
        }

        static void ToonArray(int[] array)
        {
            Console.Write("Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

