namespace Task_3_DataType_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            int myInt1 = 2;
            long myLong1 = myInt1;  //implicit
            double myDouble1 = (double)myInt1;    //explicit 
            double myDouble2 = Convert.ToDouble(myInt1); //convert class
            Console.WriteLine(myInt1.GetType() + " " + myInt1);
            Console.WriteLine(myLong1.GetType() + " " + myLong1);
            Console.WriteLine(myDouble1.GetType() + " " + myDouble1);
            Console.WriteLine(myDouble2.GetType() + " " + myDouble2);
            Console.WriteLine();
            //Task2
            int myInt2 = 122;
            long myLong2 = myInt2;
            int myInt3 = (int)myLong2; //Difference is in "(int)". 
            //Task3
            double myDouble3 = 3.14;
            int myInt4 = (int)myDouble3;
            Console.WriteLine(myInt4.GetType() + " " + myInt4);
            Console.WriteLine();
            //Task4
            float myFloat1 = 213.4191f;
            double myDouble4 = Convert.ToDouble(myFloat1);
            string myString1 = Convert.ToString(myFloat1);
            Console.WriteLine(myDouble4.GetType() + " " + myDouble4);
            Console.WriteLine(myString1.GetType() + " " + myString1);
            Console.WriteLine();
            //Task5
            string myString3 = "99999999";
            int myInt6 = int.Parse(myString3);
            Console.WriteLine(myInt6.GetType() + " " + myInt6);
            Console.WriteLine();
            //Task6
            /*
            string myString2 = "99999999999999"; error is that 9999999999999 is out of bounds of int and there isnt enough space to keep myString2's value in int
            int myInt5 = int.Parse(myString1);
            */
            //Task7
            Console.WriteLine("Parsing Doesn't Work: ");
            string myString4 = "9999999999999";
            int result1;
            int.TryParse(myString4, out result1);
            Console.WriteLine(result1.GetType() + " " + result1);
            Console.WriteLine("Parsing works: ");
            int result2;
            int.TryParse(myString3, out result2);
            Console.WriteLine(result2.GetType() + " " + result2);
            Console.WriteLine();
            //Task8
            Console.WriteLine("Enter Number: ");

            int result3;
            bool UserEnteredWord = false;
            while (UserEnteredWord == false)
            {
                string userInput1 = Console.ReadLine();
                if (int.TryParse(userInput1, out result3))
                {
                    Console.WriteLine(result3);
                    UserEnteredWord = true;
                }
                else
                {
                    Console.WriteLine("Enter Number: ");
                }
            }
            //Task 9
            string myString5 = "454789";
            int myInt7 = Convert.ToInt32(myString5);
            Console.WriteLine(myInt7.GetType() + " " + myInt7);
            int myInt8 = int.Parse(myString5);
            Console.WriteLine(myInt8.GetType() + " " + myInt8);
            //Parse is more safe beacuse it has method try parse;
            //Task 10
            int FinalInt = 10;
            long FinalLong = 123141;
            double FinalDouble = 12.312;
            string FinalString = "-4712415465231";

            long FinalLong1 = FinalInt; //implicit conversion to long
            long FinalLong2 = (int)FinalInt; //Explicit conversion to long
            Console.WriteLine(FinalLong1 + " " + FinalLong2);

            int FinalInt1 = Convert.ToInt32(FinalLong1); // Casting From long To int using class Convert
            int FinalInt2 = (int)FinalLong; // Casting from long to int using explicit casting
            Console.WriteLine(FinalInt1 + " " + FinalInt2);

            int FinalInt3 = Convert.ToInt32(FinalDouble); // Casting from double to int using Convert Class
            int FinalInt4 = (int)FinalDouble; // Casting from double to int using Explicit Casting
            Console.WriteLine(FinalInt3 + " " + FinalInt4);

            long FinalLong3 = long.Parse(FinalString); // Parsing string to numeric value
            Console.WriteLine(FinalLong3);


        }
    }
}
