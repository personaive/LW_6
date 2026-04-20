using System;

public class LineSegment
{
    private double x;
    private double y;

    public LineSegment()
    {
        x = 0;
        y = 0;
    }

    public LineSegment(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public LineSegment(LineSegment segment)
    {
        x = segment.x;
        y = segment.y;
    }

    public double X
    {
        get { return x; }
        set { x = value; }
    }

    public double Y
    {
        get { return y; }
        set { y = value; }
    }

    public bool Intersects(LineSegment segment)
    {
        double start1 = Math.Min(x, y);
        double end1 = Math.Max(x, y);

        double start2 = Math.Min(segment.x, segment.y);
        double end2 = Math.Max(segment.x, segment.y);

        return !(end1 < start2 || end2 < start1);
    }

    public override string ToString()
    {
        return $"Segment: [{x}; {y}]";
    }

    public static double operator !(LineSegment segment)
    {
        return Math.Abs(segment.y - segment.x);
    }

    public static LineSegment operator ++(LineSegment segment)
    {
        segment.x -= 1;
        segment.y += 1;
        return segment;
    }

    public static implicit operator int(LineSegment segment)
    {
        return (int)segment.x;
    }

    public static explicit operator double(LineSegment segment)
    {
        return segment.y;
    }

    public static LineSegment operator -(LineSegment segment, int value)
    {
        segment.x -= value;
        return segment;
    }

    public static LineSegment operator -(int value, LineSegment segment)
    {
        segment.y -= value;
        return segment;
    }

    public static bool operator <(LineSegment a, LineSegment b)
    {
        return a.Intersects(b);
    }

    public static bool operator >(LineSegment a, LineSegment b)
    {
        return !a.Intersects(b);
    }
}
