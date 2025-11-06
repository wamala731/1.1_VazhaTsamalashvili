namespace Task4_VazhaTsamalashvili
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1 and Task4 granting operators
            int myInt1 = 10;
            Console.WriteLine(myInt1);
            myInt1 += 20;
            Console.WriteLine(myInt1);
            myInt1 -= 5;
            Console.WriteLine(myInt1);
            myInt1 /= 5;
            Console.WriteLine(myInt1);
            myInt1 *= 12;
            Console.WriteLine(myInt1);
            myInt1 %= 7;
            Console.WriteLine(myInt1);
            Console.WriteLine();
            #endregion
            #region Task 2 mathematical operations
            int myInt2 = 10;
            int myInt3 = 200;
            int sum = myInt3 + myInt2;
            Console.WriteLine(sum);
            int difference = myInt3 - myInt2;
            Console.WriteLine(difference);
            int multiplied = myInt3 * myInt2;
            Console.WriteLine(multiplied);
            int division = myInt3 / myInt2;
            Console.WriteLine(division);
            Console.WriteLine();
            #endregion
            #region Task 3 Using + operators in lines
            string mystring1 = "Hello";
            string mystring2 = "World";
            Console.WriteLine(mystring1 + " " + mystring2);
            Console.WriteLine();
            #endregion
            #region Task 5 .result after multiple operations
            int myInt4 = 12;          
            myInt4 += 432;           
            myInt4 -= 21;
            myInt4 /= 5;
            myInt4 *= 16;           
            Console.WriteLine(myInt4);
            Console.WriteLine();
            #endregion
            #region Task 6 Logical operations
            bool TRUE = true;
            bool FALSE = false;
            bool usingAndOperator = TRUE && FALSE;
            Console.WriteLine(usingAndOperator);
            bool usingOrOperator = TRUE || FALSE;
            Console.WriteLine(usingOrOperator);
            bool usingXorOperator = TRUE ^ FALSE;
            Console.WriteLine(usingXorOperator);
            //using Not operator;
            bool result1 = !FALSE;
            Console.WriteLine(result1);
            bool result2 = !TRUE;
            Console.WriteLine(result2);
            Console.WriteLine();
            #endregion
            #region Task 7 
            bool TRUE1 = true;
            bool FALSE1 = false;
            bool usingNAndOperator = !(TRUE1 && FALSE1);
            Console.WriteLine(usingNAndOperator);
            bool usingNOrOperator = !(TRUE1 || FALSE1);
            Console.WriteLine(usingNOrOperator);
            bool usingNXorOperator = !(TRUE1 ^ FALSE1);
            Console.WriteLine(usingNXorOperator);
            Console.WriteLine();
            #endregion
            #region Task8
            //Both should be True
            bool myBool1 = true;
            bool myBool2 = true;
            if(myBool1 && myBool2)
            {
                Console.WriteLine("Both are true");
            }
            //Atleast one should be True
            bool myBool3 = true;
            bool myBool4 = false;
            if (myBool3 || myBool4)
            {
                Console.WriteLine("At least one is true");
            }
            //None should be True
            bool myBool5 = false;
            bool myBool6 = false;
            if ((myBool5 == false) && (myBool6 == false))
            {
                Console.WriteLine("Both are False");
            }
            Console.WriteLine();
            #endregion
            #region Task 9 Checking users input
            string UserInput = Console.ReadLine();
            int UserInputinInt = int.Parse(UserInput);
            if((UserInputinInt > 0) && (UserInputinInt < 10)){
                Console.WriteLine("This number is positive and lower than 10");
            }else {
                Console.WriteLine("This number is not positive or is greater than 10");            
            }
            Console.WriteLine() ;
            #endregion
            #region Task 10 Using Logical and Arithmetical operations together
            string UserInput2 = Console.ReadLine();
            int UserInputinInt2 = int.Parse(UserInput2);
            if ((UserInputinInt2 + 5 > 0) && (UserInputinInt2 <= 10))
            {
                Console.WriteLine("+5 to this number is positive and lower than 10");
            }
            else
            {
                Console.WriteLine("+5 to this number is not positive or is greater than 10");
            }
            Console.WriteLine();
            #endregion
        }
    }
}
