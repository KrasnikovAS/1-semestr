using System;

class Circle
{
    private int x;
    private int y;
    private int radius;

    public Circle()
    {
        x = 0;
        y = 0;
        radius = 0;
    }

    public Circle(int radius)
    {
        x = 0;
        y = 0;
        this.radius = radius;
    }

    public Circle(int x, int y)
    {
        this.x = x;
        this.y = y;
        radius = 0;
    }

    public Circle(int x, int y, int radius)
    {
        this.x = x;
        this.y = y;
        this.radius = radius;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Circle: Center=({x}, {y}), Radius={radius}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle1 = new Circle();
        Circle circle2 = new Circle(5);
        Circle circle3 = new Circle(3, 4);
        Circle circle4 = new Circle(2, 3, 7);

        circle1.DisplayInfo();
        circle2.DisplayInfo();
        circle3.DisplayInfo();
        circle4.DisplayInfo();
    }
}
