using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input first segment:");
        double x1 = ReadDouble("Enter x: ");
        double y1 = ReadDouble("Enter y: ");

        LineSegment s1 = new LineSegment(x1, y1);

        Console.WriteLine("\nInput second segment:");
        double x2 = ReadDouble("Enter x: ");
        double y2 = ReadDouble("Enter y: ");

        LineSegment s2 = new LineSegment(x2, y2);

        Console.WriteLine("\nSegments:");
        Console.WriteLine(s1);
        Console.WriteLine(s2);

        Console.WriteLine("\nDo they intersect: " + s1.Intersects(s2));

        Console.WriteLine("\nLength of s1: " + !s1);

        ++s1;
        Console.WriteLine("After expanding s1: " + s1);

        int intValue = s1;
        Console.WriteLine("int (x): " + intValue);

        double doubleValue = (double)s1;
        Console.WriteLine("double (y): " + doubleValue);

        s1 = s1 - 2;
        Console.WriteLine("\ns1 - 2: " + s1);

        s2 = 3 - s2;
        Console.WriteLine("3 - s2: " + s2);

        Console.WriteLine("\nOperator <: " + (s1 < s2));
    }

    static double ReadDouble(string message)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            double value;
            if (double.TryParse(input, out value))
            {    
                return value;
            }
            
            Console.WriteLine("Error! Enter a number.");
        }
    }
}
