using System;
namespace SimpleCalculator
{
    public class StringToIntConverter
    {
        public int convert(string input)
        {
            try {
                int isConvertedNumber;
                bool convertedToIntSuccessfully = int.TryParse(input, out isConvertedNumber);
                if (!convertedToIntSuccessfully){
                    throw new Exception("Conversion was not successfull");
                }
                return isConvertedNumber;

            }
            catch(Exception ex){
                throw ex;
            }

        }
    }
}
