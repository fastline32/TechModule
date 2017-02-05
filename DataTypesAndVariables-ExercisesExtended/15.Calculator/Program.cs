using System;

namespace _15.Calculator
{
    class Calculator
    {
        static void Main()
        {
            int operand1 = int.Parse(Console.ReadLine());
            char operatorMath = Char.Parse(Console.ReadLine());
            int operand2 = int.Parse(Console.ReadLine());

            switch (operatorMath)
            {
                case '+':
                    Console.WriteLine($"{operand1} + {operand2} = {operand1 + operand2}");break;
                case '-':
                    Console.WriteLine($"{operand1} - {operand2} = {operand1 - operand2}");break;
                case '*':
                    Console.WriteLine($"{operand1} * {operand2} = {operand1 * operand2}");break;
                case '/':
                    Console.WriteLine($"{operand1} / {operand2} = {operand1 / operand2}");break;
            }
        }
    }
}
