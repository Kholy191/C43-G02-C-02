namespace Assignement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 Write a program that allows the user to enter a number then print it
            //int Num;
            //int.TryParse(Console.ReadLine(), out Num);
            //Console.WriteLine(Num);
            #endregion

            #region Q2 Write C# program that converts a string to an integer, but the string contains non-numeric characters.And mention what will happen
            //int Num;
            //string Name = "Ahmed23";
            //int.TryParse(Name, out Num);
            //Console.WriteLine(Num);

            /**
             * Result:
             * Num will be 0 because TryParse Can't convert the string
             * and TryParse give the variable the default Value of it int => 0
             */
            #endregion


            #region Q3 Write C# program that Perform a simple arithmetic operation with floating - point numbers And mention what will happen
            //float Num1 = 4.5F;
            //float Num2 = 5.3F;
            //Console.WriteLine($"Result = {Num1 + Num2}");

            /**
             * Result:
             * Just added numbers
             */
            #endregion

            #region Q4 Write C# program that Extract a substring from a given string.
            //string Name = "Ahmed Adel";
            //string Fname = Name.Substring(0, 5);
            //Console.WriteLine(Fname);

            #endregion

            #region Q5 Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen *

            //int Num1 = 4;
            //int Num2 = 5;
            //Num1 = Num2;
            //Num2 = 1;
            //Console.WriteLine($" Num1 = {Num1} \n Num2 = {Num2}");

            /**
             * Result:
             * the value of Num2 will be copied to Num1
             * then Num1 will be equal 5 and Num2 will be equal 1
             */
            #endregion


            #region Q6 Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            //string Name1 = "Ahmed";
            //string Name2 = "Mohamed";
            //Name1 = Name2;
            //Console.WriteLine(Name1);
            //Console.WriteLine(Name2);

            /**
             * Result:
             * Name1 will have the address that Name2 reference on 
             * then both will have reference same address in heap
             * and have the same value "Mohamed" 
             * Name1 first address will be not reachable that makes the 
             * garbage collector remove it soon
             */
            #endregion

            #region Q7 Write C# program that take two string variables and print them as one variable
            //string Name1 = "Ahmed";
            //string Name2 = "Mohamed";
            //Console.WriteLine(string.Format("The Full string is {0} {1}", Name1, Name2));
            ////or
            //Console.WriteLine(string.Format(Name1 + " " + Name2));
            #endregion

            #region Question 8
            /* Which of the following statements is correct about the C#.NET code snippet given below?
            int d;
            d = Convert.ToInt32(!(30 < 20));*/

            //Answer: (a) A value 1 will be assigned to d.
            #endregion

            #region Question 9
            /*Which of the following is the correct output for the C# code given below
            Console.WriteLine(13 / 2 + " " + 13 % 2);*/

            //Answer:(d) 6 1
            #endregion

            #region Question 10
            /*What will be the output of the C# code given below?
            int num = 1, z = 5;
            if (!(num <= 0))
                Console.WriteLine( ++num + z++ + " " + ++z ); 
            else
                Console.WriteLine( --num + z-- + " " + --z ); 
            */

            //Answer: (d) 7 7

            #endregion
        }
    }
}
