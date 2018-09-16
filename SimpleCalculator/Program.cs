using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //comment can i put
            /* string sorted = "haa bhai, sorted hai !!";
             Console.WriteLine(sorted);
             int integer = 2345;
             Console.WriteLine(integer);
             double floaters = 2345.70;
             float floater = 2345.54f;
             Console.WriteLine(floaters);
             Console.WriteLine(floater);
             bool isOrdered = true;
             Console.WriteLine(isOrdered);
             string input1 = Console.ReadLine();
             string input2 = Console.ReadLine();
             string strr = input1 + input2;
             Console.WriteLine(strr);
             //How to convert data types
             string input = Console.ReadLine();
             int convertedNumber;
             int.TryParse(input, out convertedNumber);
             int sum = 10 + 10 - convertedNumber;
             Console.WriteLine(sum);

            int res = 10 / (5 * 2);
            Console.WriteLine(res);
            string comp1 = "text";
            string comp2 = "Text";

            bool new1 = comp1.Equals(comp2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(new1);
            string addedText = comp1 + " "+ comp2 + ".";
            string formatText = string.Format("{0} {1}.", comp1, comp2);
            Console.WriteLine(addedText);
            Console.WriteLine(formatText);
            Console.WriteLine(addedText.Length);
            Console.WriteLine(addedText[9]);
            Console.WriteLine(addedText.Substring(3, 4));
            Console.WriteLine(addedText.Contains("text"));
            Console.WriteLine(addedText.GetType());
            string anotherString = string.Empty;
            Console.WriteLine(anotherString);

            string input = Console.ReadLine();
            if (input.Equals("subash"))
            {
                Console.WriteLine("True");
            }
            else { Console.WriteLine("False"); }

            string input = Console.ReadLine();
            switch (input){
                case "subash":
                    {
                        Console.WriteLine("True");
                        break;
                    }
                case "sharma":
                    {
                        Console.WriteLine("True");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("False");
                        break;
                    }
            }
            Person newPerson = new Person();
            Console.WriteLine(newPerson.getAge());
            newPerson.setAge(30);
            Console.WriteLine(newPerson.getAge());
            Person.greet();

            // Exception and throw keyword
            string input = Console.ReadLine();
            int convertToNumber;
            bool isConvertedSuccessfully = int.TryParse(input, out convertToNumber);
            if (!isConvertedSuccessfully){
                throw new Exception("Not Converted SuccessFully");
            }

            // Exception Handling
            try
            {
                string input = Console.ReadLine();
                int isConvertedToNumber;
                bool isConvertedSuccessfully = int.TryParse(input, out isConvertedToNumber);
                if (!isConvertedSuccessfully)
                {
                    throw new Exception("Conversion was not Successful :(");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an Error with Conversion {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("Application is still running");
            }

            StringToIntConverter stringToInt = new StringToIntConverter();

            string input = Console.ReadLine();
            try{
                stringToInt.convert(input);
            }
            catch (Exception ex){
                Console.WriteLine(ex);
            }
            */
            // Simple Calculator
            //TODO Step 1: Fetch all three inputs from the User Console
            //TODO Step 2: Handle Exception if the first 2 inputs are not Integer
            //TODO Step 3: Handle Exception if the last input which is a operator other 
            //than add,
            //subtract, multiply and Divide
            //TODO Step 4: Write the logic to operate on those numbers
            try
            {
                Console.WriteLine("Enter first input");
                string input1 = Console.ReadLine();
                Console.WriteLine("Enter second input");
                string input2 = Console.ReadLine();
                Console.WriteLine("Enter operator");
                string operate = Console.ReadLine();
                int ConvertedToIntInput1;
                int ConvertedToIntInput2;
                bool isConvertedSuccessfullyInput1 = int.TryParse(input1, out ConvertedToIntInput1);
                bool isConvertedSuccessfullyInput2 = int.TryParse(input2, out ConvertedToIntInput2);
                if (!isConvertedSuccessfullyInput1)
                {
                    throw new Exception("Please enter number instead of string. Your input" +
                                         "is :" + input1);
                }
                if (!isConvertedSuccessfullyInput2){
                    throw new Exception("Please enter number instead of string, your input is:"
                                         + input2);
                }
                switch(operate){
                    case "add":
                    case "+":
                        Console.WriteLine(ConvertedToIntInput1 + ConvertedToIntInput2);
                        break;
                    case "subtract":
                    case "-":
                        Console.WriteLine(ConvertedToIntInput1 - ConvertedToIntInput2);
                        break;
                    case "divide":
                    case "/":
                        Console.WriteLine(ConvertedToIntInput1 / ConvertedToIntInput2);
                        break;
                    case "multiply":
                    case "*":
                        Console.WriteLine(ConvertedToIntInput1 * ConvertedToIntInput2);
                        break;
                }

            }
            catch (Exception ex){
                Console.WriteLine(ex);
            }

        }
    }
}
