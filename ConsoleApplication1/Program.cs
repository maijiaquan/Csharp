﻿//C#的几种访问修饰符的区别  2017.11.8

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
    C#的几种访问修饰符的区别（public、private、protected、internal、protected internal）
    Lua的8种基本类型
    


待补充
    类
    运算符
    判断
    循环
    数组
    字符串

待解决：
    函数的缺省类型是public吗？

感想和理解：
    C#万物皆类
    Lua是脚本语言
*/


using System;

namespace RectangleApplication
{
    class Rectangle
    {
        public double length;
        public double width;

        public double GetArea()
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