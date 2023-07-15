using System;

namespace ArraySplitCodingChallenge_CH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayController arrayController = new ArrayController(15, 5);
            arrayController.GroupArrayElementsAndPrint();

            arrayController.Array = new int[] { 1, 2, 3, 4, 5 };
            arrayController.DivisibleSize = 3;

            arrayController.GroupArrayElementsAndPrint();

            Console.ReadLine();
        }
    }
}

// Console interface version
//static void Main(string[] args)
//{
//    while (true)
//    {
//        bool arraySizeValueObtained = false;
//        bool divideSizeValueObtained = false;
//        int arraySize = 0;
//        int divideSize = 0;

//        while (arraySizeValueObtained == false)
//        {
//            Console.WriteLine("Please enter a size for the array (0 or more): ");
//            var arraySizeString = Console.ReadLine();
//            arraySizeValueObtained = int.TryParse(arraySizeString, out arraySize);

//            if (arraySizeValueObtained == false)
//            {
//                Console.WriteLine("Please only enter an integer value.");
//            }
//            if (arraySize < 0)
//            {
//                Console.WriteLine("Please only enter an integer value of 0 or more.");
//                arraySizeValueObtained = false;
//            }
//        }

//        while (divideSizeValueObtained == false)
//        {
//            Console.WriteLine("Please enter an amount to divide by: ");
//            var divideSizeString = Console.ReadLine();
//            divideSizeValueObtained = int.TryParse(divideSizeString, out divideSize);

//            if (divideSizeValueObtained == false)
//            {
//                Console.WriteLine("Please only enter an integer value.");
//            }
//            if (divideSize < 1)
//            {
//                Console.WriteLine("Please only enter an integer value of 1 or more.");
//                divideSizeValueObtained = false;
//            }
//        }


//        ArrayController arrayController = new ArrayController(arraySize, divideSize);

//        arrayController.GroupArrayElementsAndPrint();
//        Console.WriteLine("Restart? Y/N");
//        string answer = Console.ReadLine();
//        if (answer.ToUpper() == "N")
//        {
//            break;
//        }
//    }
//}


