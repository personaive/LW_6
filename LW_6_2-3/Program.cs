using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input first segment:");
        double x1 = ReadDouble("Enter x: ");
        double y1 = ReadDouble("Enter y: ");

        LineSegment s1 = new LineSegment(x1, y1); // создание первого отрезка

        Console.WriteLine("\nInput second segment:");
        double x2 = ReadDouble("Enter x: ");
        double y2 = ReadDouble("Enter y: ");

        LineSegment s2 = new LineSegment(x2, y2); // создание второго отрезка

        Console.WriteLine("\nSegments:");
        Console.WriteLine(s1);
        Console.WriteLine(s2);

        Console.WriteLine("\nDo they intersect: " + s1.Intersects(s2));

        Console.WriteLine("\nLength of s1: " + !s1);

        ++s1; // расширение отрезка
        Console.WriteLine("After expanding s1: " + s1);

        int intValue = s1; // неявное преобразование
        Console.WriteLine("int (x): " + intValue); // вывод x

        double doubleValue = (double)s1; // явное преобразование
        Console.WriteLine("double (y): " + doubleValue); // вывод y

        s1 = s1 - 2; // уменьшение x
        Console.WriteLine("\ns1 - 2: " + s1); // вывод результата

        s2 = 3 - s2; // уменьшение y
        Console.WriteLine("3 - s2: " + s2); // вывод результата

        Console.WriteLine("\nOperator <: " + (s1 < s2)); // проверка через оператор
    }

    static double ReadDouble(string message)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            double value;
            if (double.TryParse(input, out value))
                return value;

            Console.WriteLine("Error! Enter a number.");
        }
    }
}
