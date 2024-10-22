using System;


public class Program
{
    public static void Main(string[] args)
    {
        Write1ThroughN_While(-1);
        Write1ThroughN_While(5);
        Write1ThroughN_While(0);
        Console.WriteLine();

        Write1ThroughN_For(-1);
        Write1ThroughN_For(5);
        Write1ThroughN_For(0);
        Console.WriteLine();

        WriteNThrough1_While(-1);
        WriteNThrough1_While(5);
        WriteNThrough1_While(0);
        Console.WriteLine();

        WriteNThrough1_For(-1);
        WriteNThrough1_For(5);
        WriteNThrough1_For(0);
        Console.WriteLine();

        WriteEvensThrough100();
        Console.WriteLine();

        FindSum(5);
        FindSum(1);
        FindSum(-3);
        FindSum(100);
        Console.WriteLine();

        FindSumOfEvenNumbers(10);
        FindSumOfEvenNumbers(-5);
        FindSumOfEvenNumbers(2);
        FindSumOfEvenNumbers(0);
        FindSumOfEvenNumbers(1);
        FindSumOfEvenNumbers(25);
        FindSumOfEvenNumbers(-25);
        Console.WriteLine();

        FindSumOfOddNumbers(10);
        FindSumOfOddNumbers(-5);
        FindSumOfOddNumbers(1);
        FindSumOfOddNumbers(2);
        FindSumOfOddNumbers(25);
        FindSumOfOddNumbers(-25);
        Console.WriteLine();

        OutputRightTriangle(4);
        OutputRightTriangle(6);
        OutputRightTriangle(-4);
        OutputRightTriangle(-6);
        OutputRightTriangle(0);
    }

    public static void Write1ThroughN_While(int n)
    {
        if (n < 1) { OutOfRangeMessage(n); return; }
        int current = 1;
        while (current <= n)
        {
            Console.Write($"{current} ");
            current++;
        }
        Console.WriteLine();
    }

    public static void Write1ThroughN_For(int n)
    {
        if (n < 1) { OutOfRangeMessage(n); return; }
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
    }

    public static void WriteNThrough1_While(int n)
    {
        if (n < 1) { OutOfRangeMessage(n); return; }
        while (n >= 1)
        {
            Console.Write($"{n} ");
            n--;
        }
        Console.WriteLine();
    }

    public static void WriteNThrough1_For(int n)
    {
        if (n < 1) { OutOfRangeMessage(n); return; }
        for (int i = n; i >= 1; i--)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
    }

    public static void WriteEvensThrough100()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.Write(i % 2 == 0 ? " " : i);
        }
        Console.WriteLine();
    }

    public static void FindSum(int n)
    {
        if (n == 0) { Console.WriteLine(n); return; }
        int output = 0;
        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                output += i;
            }
        }
        else
        {
            for (int i = 1; i >= n; i--)
            {
                output += i;
            }
        }
        Console.WriteLine(output);
    }

    public static void FindSumOfEvenNumbers(int n)
    {
        if (n == 0) { Console.WriteLine(n); return; }
        int output = 0;
        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                output += i % 2 == 0 ? i : 0;
            }
        }
        else
        {
            for (int i = 1; i >= n; i--)
            {
                output += i % 2 == 0 ? i : 0;
            }
        }
        Console.WriteLine(output);
    }

    public static void FindSumOfOddNumbers(int n)
    {
        if (n == 0) { Console.WriteLine(n); return; }
        int output = 0;
        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                output += i % 2 == 0 ? 0 : i;
            }
        }
        else
        {
            for (int i = 1; i >= n; i--)
            {
                output += i % 2 == 0 ? 0 : i;
            }
        }
        Console.WriteLine(output);
    }

    public static void OutputRightTriangle(int n)
    {
        if (n == 0) { OutOfRangeMessage(n); return; }
        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('*',i));
            }
        }
        else
        {
            for (int i = n; i <= -1; i++)
            {
                Console.WriteLine(new string('*',Math.Abs(i)));
            }
        }
        Console.WriteLine();
    }

    public static void OutOfRangeMessage(int n)
    {
        Console.WriteLine($"ERR: parameter 'int n = {n}' is out of range.");
    }
}
