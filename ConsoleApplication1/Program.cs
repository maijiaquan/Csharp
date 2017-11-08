using System;   //using的作用是包含命名空间

/*
简单的类型转换    2017.11.8   
    1.隐式类型转换
        以安全方式进行的转换, 不会导致数据丢失
        例如，从小的整数类型转换为大的整数类型，从派生类转换为基类。
    2.显式类型转换 
        即强制类型转换，需要强制转换运算符，会造成数据丢失。

*/

namespace TypeConversionApplication
{
    class TypeConversion  
    {
        static void Main(string[] args)
        {
            //显式类型转换，导致数据丢失
            double dvar = 123.45;
            int num;
            num = (int)dvar;
            Console.WriteLine(num);  //123

            double d = 2345.6789;
            Console.WriteLine(d.ToString());

            num = Convert.ToInt32(Console.ReadLine());
            //类似于cin，由于Console.ReadLine() 只接受字符串格式的数据，所以要把用户输入的数据转换为 int 数据类型
            Console.WriteLine(num);  

            Console.ReadKey();
        }
    }
}