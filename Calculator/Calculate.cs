using System;
namespace Calculator
{
    public class Calculate
    {
        public int resCalculate(int input1, int input2 , string operator1)
        {
            int result;
            switch (operator1){
                case "add":
                case "+":
                    result = input1 + input2;
                    break;
                case "subtract":
                case "-":
                    result = input1 - input2;
                    break;
                case "multiply":
                case "*":
                    result = input1 * input2;
                    break;
                case "divide":
                case "/":
                    result = input1 / input2;
                    break;
                default:
                    throw new Exception("Please enter valid Operator");
            }
            return result;
        }
    }
}
