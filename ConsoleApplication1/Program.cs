/*
已学习内容：
    20171108
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
    
    20171109
        引用的用法

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


*/


//按引用传递参数 20171109 9.39

using System;

class SwapClass
{
    public void swap(ref int x, ref int y)    //原来的&变成了ref
    {
        int temp = x;
        x = y;
        y = temp;
    }

    static void Main(string [] args)
    {
        SwapClass s = new SwapClass();

        int a = 1;
        int b = 2;

        Console.WriteLine("a = {0}, b = {1}", a, b);
        s.swap(ref a, ref b);   //传参数也要用ref，这一点跟C++不同
        Console.WriteLine("a = {0}, b = {1}", a, b);

        Console.ReadKey();
    }

}