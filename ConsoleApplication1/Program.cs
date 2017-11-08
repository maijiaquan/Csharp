using System;   //using的作用是包含命名空间

/*
变量和常量    2017.11.8   

    1.lvalue：lvalue 表达式可以出现在赋值语句的左边或右边。
        变量是 lvalue 的，所以可以出现在赋值语句的左边。
    2.rvalue：rvalue 表达式可以出现在赋值语句的右边，不能出现在赋值语句的左边。
        数值是 rvalue 的，因此不能被赋值，不能出现在赋值语句的左边。
        举例：
            int g = 20; //有效的语句
            10 = 20;    //无效的语句
*/

namespace DeclaringConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159; // 常量声明
            double r;
            Console.WriteLine("Enter Radius: ");
            r = Convert.ToDouble(Console.ReadLine());
            double areaCircle = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
            Console.ReadLine();
        }
    }
}