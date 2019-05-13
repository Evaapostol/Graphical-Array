using System;

namespace GraphicalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 4, 3 };
            numbers = PreProcess(numbers);
            Console.WriteLine("Enter symbol");
            char symbol = char.Parse(Console.ReadLine());
            Console.WriteLine("############");
            foreach (int aNumber in numbers)
            {
                GraphicalRepresentation(aNumber, symbol);
            }
        }

        static int[] PreProcess(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < 0) data[i] = 0;
                if (data[i] > 60) data[i] = 60;
            }
            return data;
        }

        static void GraphicalRepresentation(int figure, char sign)
        {
            Console.Write("{0:00}:", figure);
            for (int i = 0; i < figure; i++)
                Console.Write(sign);
            Console.WriteLine();
        }
    }
}
