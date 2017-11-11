using System;

class Publisher
{
    public delegate void PublishEventHandler();
    public event PublishEventHandler OnPublish;

    public void issue() //触发事件的函数
    {
        if (OnPublish != null)
        {
            Console.WriteLine("publish");
            OnPublish();  //触发事件
        }
    }
}

class Subscriber
{
    public static void recv()
    {
        Console.WriteLine("receive");
    }
}

class TestClass
{
    static void Main(string[] args)
    {
        Publisher publisher = new Publisher();
        publisher.OnPublish += Subscriber.recv;
        //publisher.OnPublish += new Publisher.PublishEventHandler(Subscriber.recv);
        publisher.issue();
        System.Console.ReadKey();
    }
}