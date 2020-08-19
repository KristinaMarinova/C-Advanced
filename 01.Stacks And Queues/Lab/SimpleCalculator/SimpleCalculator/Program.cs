using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    public static void Main()
    {
        string[] inputTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Stack<string> calcExpression = new Stack<string>(inputTokens.Reverse());

        int result = 0;
        int leftOperand = int.Parse(calcExpression.Pop());
        while (calcExpression.Count > 1)
        {
            string @operator = calcExpression.Pop();
            int rightOperand = int.Parse(calcExpression.Pop());

            switch (@operator)
            {
                case "+":
                    result = leftOperand + rightOperand;
                    break;
                case "-":
                    result = leftOperand - rightOperand;
                    break;
            }

            leftOperand = result;
        }
        Console.WriteLine(result);
    }
}
