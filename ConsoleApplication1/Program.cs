using System;
abstract class Shape
{
    int a = 1;  //可以有成员变量
    public void printInfo()
    {
        Console.WriteLine();
    }

    public abstract int area();
}

class Rectangle : Shape
{
    private int length;
    private int width;
    public Rectangle(int w, int l)
    {
        length = l;
        width = w;
    }
    public override int area()
    {
        return width * length;
    }
}

class TestClass
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle(10, 5);
        double a = rect.area();
        Console.WriteLine("area = {0}", a);
        Console.ReadKey();
    }
}