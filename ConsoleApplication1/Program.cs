using System;   //using的作用是包含命名空间

/*
数据类型    2017.11.8
    
    

值类型 value types         --> 继承 System.ValueType
    bool
    char
    int
    float等等

引用类型 reference types    【引用类型不包含存储在变量中的实际数据，但包含对变量的引用】    
    1.object    
        Object类型是C#所有数据类型的终极基类，是System.Object类的别名，
            【装箱】：值类型 转换为 Object
            【拆箱】：object 转换为 值类型
    2.dynamic   
        a.类似于Object类型，可以存储任何类型的值
        b.区别：Object变量的类型检查在编译时发生，Dynamic变量的类型检查在运行时发生
    3.String
        a.String是 System.String 类的别名，从Object类型派生
        b.通过""和@""进行分配，其中@可以任意换行
    4.补充：用户自定义引用类型有: class interface delegate


指针类型 pointer types

*/

namespace Datatype
{
    class Data  
    {

    

    }

    class MainClass
    {
        //个人理解：main可以入放别的类里面，但是一定要有main函数
        static void Main(string[] args)   //【一定要有main函数，而且只能有一个，不然报错】为什么？ Program does not contain a static 'Main' method suitable for an entry point ConsoleApplication1
        {
            //object
            object obj;         //Object 和 object 有什么区别？
            obj = 100;          //装箱：值转换为 object
            int num = (int)obj; //拆箱：object转换为值
            
            //dynamic
            dynamic dnmc;
            dnmc = "sdf";

            //String
            String str = "hello";
            string str2 = @"www.baidu.
com";


            //指针类型 Pointer types
            int var = 20;
            //int* p = &var;  //使用static unsafe void Main(string[] args)   就可以使用指针，unsafe是什么？
            //Console.WriteLine(*p);


            Console.WriteLine(obj);
            //为什么有错？ Console.WriteLine(sizeof(obj));
            Console.WriteLine(dnmc);
            Console.WriteLine(str);
            Console.WriteLine(str2);

            Console.ReadKey();
        }
    }
}