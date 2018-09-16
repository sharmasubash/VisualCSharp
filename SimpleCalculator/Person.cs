using System;
namespace SimpleCalculator
{
    public class Person
    {
            private int _age = 29;
            public int getAge(){
            return _age;
            }
            public void setAge(int newAge){
            _age = newAge;
            }
        static public void greet(){
            Console.WriteLine("Hello, How are you ?");
        }
        }
}

