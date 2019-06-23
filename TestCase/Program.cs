using System;

namespace TestCase
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Testing Github commits

            //uint myUint = 4;
            //short myShort = -5;
            //ushort myUShort = 77;
            //long myLong = -35555;
            //ulong myULong = 6446464;
            //int num1 = 15;
            //int num2 = 14;
            ////int sum = num1 + num2;
            //float myFloat = 3.57F;
            //double myDouble = 5.74646;
            //decimal myDecimal = 6.433245236M;
            //char myChar = 'j';
            //bool myBool = true;
            //string myString = "My string!";

            string myTextString = "I control text";
            string myNumString = "45";
            int parsedInt = int.Parse(myNumString);
            //int parsedInt = Int32.Parse(myNumString); //Same as above
            int sum2 = parsedInt + parsedInt;
            short parsedIntShort = Int16.Parse(myNumString);
            short sum2Short = (short)(parsedIntShort + parsedIntShort);
            long parsedIntLong = int.Parse(myNumString);
            //long parsedIntLong = Int64.Parse(myNumString); //Same as above
            long sum2Long = parsedIntLong + parsedIntLong;

            //Console.WriteLine(myUint);
            //Console.WriteLine(myShort);
            //Console.WriteLine(myUShort);
            //Console.WriteLine(myLong);
            //Console.WriteLine(myULong);
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //Console.WriteLine(myFloat);
            //Console.WriteLine(myDouble);
            //Console.WriteLine(myDecimal);
            //Console.WriteLine(myChar);
            //Console.WriteLine(myBool);
            //Console.WriteLine(myString);
            //Console.WriteLine(myTextString);
            //Console.WriteLine(myNumString);
            //Console.WriteLine(parsedInt);
            //Console.WriteLine(sum2);
            //Console.WriteLine(parsedIntShort);
            //Console.WriteLine(sum2Short);
            //Console.WriteLine(parsedIntLong);
            //Console.WriteLine(sum2Long);
            //Console.WriteLine(sum);
            Console.WriteLine("The speed limit on this road is {0}, but most people go over {0} mph. Oh and, by the way, {1}.", myNumString, myTextString); //{#} represents an index
            Console.Read();

            // COLORS & INPUT NAME ON TERMINAL
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.BackgroundColor = ConsoleColor.DarkGreen;
            //Console.Clear();
            //Console.Write("Please enter your name: ");
            //string input = Console.ReadLine();
            //Console.Write("Hello " + input + "!?!?!");
        }
    }
}
