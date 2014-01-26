using System;
//3. Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

class Brackets
{
    private static void Result(int bracketsCounter)
    {
        if (bracketsCounter == 0)
        {
            Console.WriteLine("The expression is correct");
        }
        else
        {
            Console.WriteLine("The expression is not correct");
        }
    }

    private static int BracketsCounter(string brackets, int bracketsCounter)
    {
        for (int i = 0; i < brackets.Length; i++)
        {
            if (brackets[i] == '(')
            {
                bracketsCounter++;
            }
            else if (brackets[i] == ')')
            {
                bracketsCounter--;
            }
            if (bracketsCounter < 0)
            {
                break;
            }
        }
        return bracketsCounter;
    }
    static void Main()
    {
        string brackets = "((a+b)/5-d)";
        int bracketsCounter = 0;
        bracketsCounter = BracketsCounter(brackets, bracketsCounter);
        Result(bracketsCounter);
    }
}
