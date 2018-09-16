using System;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            try
            {
                Input getInput = new Input();
                int input1 = getInput.Intake(Console.ReadLine());
                int input2 = getInput.Intake(Console.ReadLine());
                string operate = Console.ReadLine();
                Calculate calc = new Calculate();
                int result = calc.resCalculate(input1, input2, operate);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }

            //TODO : Create a Class or method to deal with input
            //TODO : Create a class to deal with operator
            //TODO : Create a class to perform operation on inputs
            //TODO : Handle exception in all the steps
        }
    }
}
