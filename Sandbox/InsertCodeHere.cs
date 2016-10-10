using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            CubeCalculator cc = new CubeCalculator();

            String userInput = cc.GetUserInput("Please enter a number (or q for quit): ");

            while (userInput != "q")
            {
                if (cc.IsANumber(userInput))
                {
                    int value = cc.ConvertToNumber(userInput);
                    int result = cc.CalculateCube(value);
                    Console.WriteLine("The cube of {0} is {1}", value, result);
                }
                else
                {
                    Console.WriteLine("Could not calculate...");
                }
                userInput = cc.GetUserInput("Please enter a number (or q for quit): ");
            }

            // The LAST line of code should be ABOVE this line
        }
    }
}
