using System;   //using的作用是包含命名空间


//C#结构体2  2017.11.8

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

struct Books
{
    public string title;
    public string author;
    public string subject;
    public int book_id;

    public void setValues(string t, string a, string s, int id)
    {
        title = t;
        author = a;
        subject = s;
        book_id = id;
    }

    public void display()
    {
        Console.WriteLine("Title : {0}", title);
        Console.WriteLine("Author : {0}", author);
        Console.WriteLine("Subject : {0}", subject);
        Console.WriteLine("Book_id :{0}", book_id);
    }
};

class StructureTest
{
    public static void Main(string[] args)
    {
        Books Book1 = new Books(); 
        Books Book2 = new Books(); 

        Book1.setValues("C Programming", "Nuha Ali", "C Programming Tutorial", 6495407);
        Book2.setValues("Telecom Billing", "Zara Ali", "Telecom Billing Tutorial", 6495700);

        Book1.display();
        Book2.display();

        Console.ReadKey();
        Console.ReadKey();
    }
}
