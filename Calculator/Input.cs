using System;
namespace Calculator
{
    public class Input
    {
        public int Intake(string input)
        {
            int ConvertToInt;
            bool isConvertedToInt = int.TryParse(input, out ConvertToInt);
            if (!isConvertedToInt) { throw new ArgumentException("Invalid Input, Please enter numeric values"); }
            return ConvertToInt;
        }
    }
}
