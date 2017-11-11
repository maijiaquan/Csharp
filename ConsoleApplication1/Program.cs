using System;

//个感：这个感兴趣的内容列表 一定是 跟 subject被监控对象有关的
public class UserEventArgs : EventArgs
{
    public readonly string emailAddress;    //邮件地址
    public readonly string mobilePhone;     //手机号码
    public readonly string amount;          //取款金额
    public UserEventArgs(string emailAddress, string mobilePhone, string amount)
    {
        this.emailAddress = emailAddress;
        this.mobilePhone = mobilePhone;
        this.amount = amount;
    }
}

//subject 被监控对象 为银行账号
public class BankAccount
{
    
    public delegate void ProcessTranEventHandler(object sender, UserEventArgs e);//理解2个参数：这两个参数是参照observer的回调函数而加入的
    public event ProcessTranEventHandler ProcessTran;  //事件是对委托的封装

    //如果被监控对象有需要被访问的成员变量，这里就加上相应的成员变量

    //该函数实现了事件的触发
    protected virtual void OnProcessTran(UserEventArgs e) //理解e：因为委托有e，所以要传e进去，因为自己就是sender，所以不用传this
    {
        if (ProcessTran != null)    //事件注册了 对象
        {
            ProcessTran(this, e);   //其实就是调用委托，由于委托可以叠加，因此这一步会调用所有注册对象的方法（即 回调函数/事件处理程序）
        }
    }



    //为什么还要额外通过这个函数实现事件的触发呢？暂定是规范的写法
    public void Prcess(UserEventArgs e)
    {
        OnProcessTran(e);
    }

}

//observer1
class MobileSystem
{
    //理解两个参数的目的：因为observer对e感兴趣; 因为把subject传进去可以方便直接访问，增强灵活性
    public static void SendNotification(object sender, UserEventArgs e)
    {
        Console.WriteLine("向用户手机" + e.mobilePhone + "发送短信:您在" + System.DateTime.Now.ToString() + "取款金额为" + e.amount);
    }
}

//observer2
class EmailSystem
{
    //理解两个参数的目的：因为observer对e感兴趣; 因为把subject传进去可以方便直接访问，增强灵活性
    public static void SendEmail(object sender, UserEventArgs e)
    {
        Console.WriteLine("向用户邮箱" + e.emailAddress + "发送邮件:您在" + System.DateTime.Now.ToString() + "取款金额为" + e.amount);
    }
}

//SubscribSystem订阅系统，实现银行系统订阅几个Observer，实现与客户端Client的松耦合
class SubscribSystem
{
    public SubscribSystem()
    {
    }

    public SubscribSystem(BankAccount bankAccount, UserEventArgs e)
    {
        //现在我们在银行账户订阅2个，分别是电子邮件和手机短信
        bankAccount.ProcessTran += new BankAccount.ProcessTranEventHandler(EmailSystem.SendEmail);
        bankAccount.ProcessTran += new BankAccount.ProcessTranEventHandler(MobileSystem.SendNotification);
        bankAccount.Prcess(e);  //publisher在这里触发事件
    }
}

class Client    //就是TestClass
{
    public static void Main(string[] args)
    {
        Console.Write("请输入您要取款的金额：");
        string amount = Console.ReadLine();
        Console.WriteLine("交易成功，请取磁卡。");

        //初始化e
        UserEventArgs user = new UserEventArgs("jinjiangbo2008@163.com", "18868789776", amount);

        //初始化SubscribSystem
        SubscribSystem subject = new SubscribSystem(new BankAccount(), user);
        Console.ReadKey();
    }
}