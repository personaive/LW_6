using System;

public class LineSegment // класс отрезка
{
    private double x;
    private double y;

    public LineSegment() // конструктор по умолчанию
    {
        x = 0;
        y = 0;
    }

    public LineSegment(double x, double y) // конструктор с параметрами
    {
        this.x = x;
        this.y = y;
    }

    public LineSegment(LineSegment segment) // конструктор копирования
    {
        x = segment.x;
        y = segment.y;
    }

    public double X // свойство для x
    {
        get { return x; }
        set { x = value; }
    }

    public double Y // свойство для y
    {
        get { return y; }
        set { y = value; }
    }

    public bool Intersects(LineSegment segment) // метод проверки пересечения
    {
        double start1 = Math.Min(x, y); // начало первого отрезка
        double end1 = Math.Max(x, y); // конец первого отрезка

        double start2 = Math.Min(segment.x, segment.y); // начало второго отрезка
        double end2 = Math.Max(segment.x, segment.y); // конец второго отрезка

        return !(end1 < start2 || end2 < start1); // проверка пересечения
    }

    public override string ToString()
    {
        return $"Segment: [{x}; {y}]"; // строковое представление
    }

    // унарные операторы
    public static double operator !(LineSegment segment) // оператор ! длина отрезка
    {
        return Math.Abs(segment.y - segment.x); // вычисление длины
    }

    public static LineSegment operator ++(LineSegment segment) // оператор ++ расширение
    {
        segment.x -= 1; // расширение влево
        segment.y += 1; // расширение вправо
        return segment; // возврат результата
    }

    // операции приведения типа
    public static implicit operator int(LineSegment segment) // неявное преобразование в int
    {
        return (int)segment.x; // возврат целой части x
    }

    public static explicit operator double(LineSegment segment) // явное преобразование в double
    {
        return segment.y; // возврат y
    }

    // бинарные операторы
    public static LineSegment operator -(LineSegment segment, int value) // segment - int
    {
        segment.x -= value; // уменьшение x
        return segment; // возврат результата
    }

    public static LineSegment operator -(int value, LineSegment segment) // int - segment
    {
        segment.y -= value; // уменьшение y
        return segment; // возврат результата
    }

    public static bool operator <(LineSegment a, LineSegment b) // оператор <
    {
        return a.Intersects(b); // проверка пересечения
    }

    public static bool operator >(LineSegment a, LineSegment b) // оператор >
    {
        return !a.Intersects(b); // обратная проверка
    }
}
