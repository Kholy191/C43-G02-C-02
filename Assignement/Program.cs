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

        }
    }
}
