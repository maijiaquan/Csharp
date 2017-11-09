//C#的几种访问修饰符的区别  2017.11.8

/*
已学习内容：
    C#程序的组成（using关键字、类、main函数等）
    C#装箱和拆箱的概念
    C#的几种数据类型（值类型、引用类型、指针类型）
    C#简单的类型转换（隐式——例如double转int、显式——例如装箱）
    lvalue和rvalue的概念
    C#的变量分类
    C#的常量（常量和const关键字）
    C#的结构体的使用
    C#类的几种访问修饰符的区别（public、private、protected、internal）

    Lua的8种基本类型
    


待补充
    类
    运算符
    判断
    循环
    数组
    字符串

已解决的问题：
    函数的缺省类型是private

感想和理解：
    C#万物皆类
    Lua是一种轻量小巧的脚本语言
    
备注：今天刚刚适应了工作环境，学习时间有限，总结也有限。明天的收货和总结会更多更全面。

*/


using System;


namespace RectangleApplication
{
    class Rectangle
    {
        internal double length;
        internal double width;

        double GetArea()  //类成员的默认访问修饰符为 private
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("长度： {0}", length);
            Console.WriteLine("宽度： {0}", width);
            Console.WriteLine("面积： {0}", GetArea());
        }
    }
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
    }
}