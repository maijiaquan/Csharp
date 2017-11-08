using System;   //using的作用是包含命名空间

namespace RectangleApplication
{
    class Rectangle
    {
        double length;
        double width;   //有C++那样的public private protected 访问权限吗？

        public void initRect()     //1.不加public修饰函数名也可以，缺省访问是什么？是public吗？ 2.如何先声明函数而不是直接定义？
        {
            length = 3;
            width = 2;
        }

        public double getArea()    //传参数进去跟C++一样吗？
        {
            return length * width;
        }

        public void printInfo()
        {
            Console.WriteLine("length: {0}", length);   //{0}是占位符，用法如下：【Console.WriteLine("第{0}个占位符，第{1}个占位符","1","二"); 】
            Console.WriteLine("length: {0}", width);
            Console.WriteLine("length: {0}", getArea());   
        }

        public void setRect(double x, double y)
        {
            length = x;
            width = y;
        }
    }

    class MainClass
    {
        //个人理解：main可以入放别的类里面，但是一定要有main函数
        static void Main(string[] args)   //【一定要有main函数，而且只能有一个，不然报错】为什么？ Program does not contain a static 'Main' method suitable for an entry point ConsoleApplication1
        {
            Rectangle rect = new Rectangle();   //默认构造函数？ new是跟C++的区别？
            rect.initRect();
            rect.setRect(4.5,3.5);
            rect.printInfo();
            Console.ReadKey();
        }
    }
}