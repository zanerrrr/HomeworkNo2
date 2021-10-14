using System;

namespace HomeworkNo2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Abs Values
            
            decimal numb1 = -45.55M;
            Console.WriteLine(Math.Abs(numb1));
            double numb2 = 16.8;
            Console.WriteLine(Math.Abs(numb2));
            short numb16 = -45;
            Console.WriteLine(Math.Abs(numb16));
            int numb32 = -4353;
            Console.WriteLine(Math.Abs(numb32));
            long numb64 = 665;
            Console.WriteLine(Math.Abs(numb64));

            Console.WriteLine("Input a decimal: ");
            string decimalVal = Console.ReadLine();
            decimal decimalV = Convert.ToDecimal(decimalVal);
            Console.WriteLine($"Absolute of your number is {Math.Abs(decimalV)}");

            Console.WriteLine("Input a double: ");
            string doublenumb = Console.ReadLine();
            double doublenum = Convert.ToDouble(doublenumb);
            Console.WriteLine($"Absolute of your number is {Math.Abs(doublenum)}");

            Console.WriteLine("Input a short Int16: ");
            string shortnumb = Console.ReadLine();
            short shortnum = Convert.ToInt16(shortnumb);
            Console.WriteLine($"Absolute of your number is {Math.Abs(shortnum)}");

            Console.WriteLine("Input a long Int64: ");
            string longnumb = Console.ReadLine();
            long longnum = Convert.ToInt64(longnumb);
            Console.WriteLine($"Absolute of your number is {Math.Abs(longnum)}");

            Console.WriteLine("Input a int Int32: ");
            string intnumb = Console.ReadLine();
            int intnum = Convert.ToInt32(intnumb);
            Console.WriteLine($"Absolute of your number is {Math.Abs(intnum)}");       


            #endregion

            #region Algorithm

            //int number1 = 6;
            //int number2 = 6;
            //if (number2 == number1) ;
            //{
            //    Console.WriteLine("6 is equal to 6");
            //}

            Console.WriteLine("Input number: ");
            string number1 = Console.ReadLine();
            int intnumber1 = int.Parse(number1); 


            Console.WriteLine("Input number: ");
            string number2 = Console.ReadLine();
            int intnumber2 = int.Parse(number2);

            if (intnumber1 == intnumber2)

            {
                Console.WriteLine($"{intnumber1} is equal to {intnumber2}");
            }
            else
            { 
                Console.WriteLine($"{intnumber1} is not equal to {intnumber2}");
            }

            Console.WriteLine("Input year: ");
            int year = int.Parse(Console.ReadLine());

            //string result = (intvyear % 4 != 0 ? "Leap year" : "Not leap");

            if (((year % 4 == 0) && (year % 100 != 0 || (year % 400 == 0))))
            {
                Console.WriteLine($"{year} is a leap year!");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year!");
            }
            #endregion

            #region Press key
            Console.WriteLine("Press any key on your keyboard");
            if (Console.ReadKey().Key == ConsoleKey.Z)
            {
                Console.WriteLine();
                Console.WriteLine($"You pressed key Z.");
            }
            else
            {
                Console.WriteLine("It is not Z.");
            }
            #endregion
            
            #region 



            #endregion

            Console.ReadLine();
        }
    }
}
