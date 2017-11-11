using System;

//个感：这个感兴趣的内容列表 一定是 跟 subject被监控对象有关的
public class PublishEventArgs : EventArgs
{
    public string magazine_name;
    public PublishEventArgs()   
    {

    }
    public PublishEventArgs(string name)
    {
        magazine_name = name;
    }
}

//subject
public class Publisher
{
    public delegate void PublishEventHandler(object sender, PublishEventArgs e);    //理解2个参数：这两个参数是参照observer的回调函数而加入的
    public event PublishEventHandler Publish;   //事件是对委托的封装

    //如果被监控对象有需要被访问的成员变量，这里就加上相应的成员变量

    //该函数实现了事件的触发
    public virtual void OnPublish(PublishEventArgs e)   //理解e：因为委托有e，所以要传e进去，因为自己就是sender，所以不用传this
    {
        if (Publish != null)    //事件注册了 对象
        {
            this.Publish(this, e);  //其实就是调用委托，由于委托可以叠加，因此这一步会调用所有注册对象的方法（即 回调函数/事件处理程序）
        }
    }

    //为什么还要额外通过这个函数实现事件的触发呢？暂定是规范的写法
    public void issue(string magazine_name)
    {
        OnPublish(new PublishEventArgs(magazine_name));
    }
}

//observer
public class MrMing
{
    //理解两个参数的目的：因为observer对e感兴趣; 因为把subject传进去可以方便直接访问，增强灵活性
    public static void recv(object sender, PublishEventArgs e)
    {
        Console.WriteLine("小明已订阅" + e.magazine_name);
    }
}

class TestClass
{
    static void Main(string[] args)
    {
        Publisher publisher = new Publisher();
        publisher.Publish += MrMing.recv;   //理解事件的+=：事件是委托的封装，事件的叠加本质上是委托的叠加
        //publisher.Publish += new Publisher.PublishEventHandler(MrMing.recv);
        publisher.issue("playboy"); //publisher是触发事件的对象

        System.Console.ReadKey();
    }
}