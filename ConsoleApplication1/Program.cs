using System;   //using的作用是包含命名空间


//C#结构体  2017.11.8

/*
已学习内容：
    C#程序的组成（using关键字、类、main函数等）
    C#装箱和拆箱的概念
    C#的几种数据类型（值类型、引用类型、指针类型）
    C#简单的类型转换（隐式——例如double转int、显式——例如装箱）
    lvalue和rvalue的概念
    C#的变量分类
    C#的常量（常量和const关键字）
    
    感想和理解：
        C#万物皆类
        Lua是脚本语言
待补充
    结构体
    类
    运算符
    判断
    循环
    数组
    字符串
*/

struct Books
{
    public string title;
    public string author;
    public string subject;
    public int book_id;

};

class StructureTest
{
    public static void Main(string[] args)
    {

        Books Book1;        /* 声明 Book1，类型为 Book */
        Books Book2;        /* 声明 Book2，类型为 Book */

        /* book 1 详述 */
        Book1.title = "C Programming";
        Book1.author = "Nuha Ali";
        Book1.subject = "C Programming Tutorial";
        Book1.book_id = 6495407;

        /* book 2 详述 */
        Book2.title = "Telecom Billing";
        Book2.author = "Zara Ali";
        Book2.subject = "Telecom Billing Tutorial";
        Book2.book_id = 6495700;

        /* 打印 Book1 信息 */
        Console.WriteLine("Book 1 title : {0}", Book1.title);
        Console.WriteLine("Book 1 author : {0}", Book1.author);
        Console.WriteLine("Book 1 subject : {0}", Book1.subject);
        Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

        Console.WriteLine(" ");


        /* 打印 Book2 信息 */
        Console.WriteLine("Book 2 title : {0}", Book2.title);
        Console.WriteLine("Book 2 author : {0}", Book2.author);
        Console.WriteLine("Book 2 subject : {0}", Book2.subject);
        Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);

        Console.ReadKey();

    }
}
