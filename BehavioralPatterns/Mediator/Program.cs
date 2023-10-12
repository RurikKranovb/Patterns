using Mediator.Core;
using Mediator.Infrastructure;

internal class Program
{
    private static void Main(string[] args)
    {
        ManagerMediator mediator = new ManagerMediator();
        Colleague customer = new CustomerColleague(mediator);
        Colleague programmer = new ProgrammerColleague(mediator);
        Colleague tester = new TesterColleague(mediator);
        mediator.Customer = customer;
        mediator.Programmer = programmer;
        mediator.Tester = tester;
        customer.Send("Есть заказ, надо сделать программу");
        programmer.Send("Программа готова, надо протестировать");
        tester.Send("Программа протестирована и готова к продаже");
    }
}



//abstract class Mediator
//{
//    public abstract void Send(string message, Colleague colleague);
//}

//abstract class Colleague
//{
//    protected Mediator mediator;

//    public Colleague(Mediator mediator)
//    {
//        this.mediator = mediator;
//    }
//}

//class ConcreteColleague1 : Colleague
//{
//    public ConcreteColleague1(Mediator mediator) : base(mediator)
//    {
//    }

//    public void Send(string message)
//    {
//        mediator.Send(message, this);
//    }

//    public void Notify(string message)
//    {

//    }
//}

//class ConcreteColleague2 : Colleague
//{
//    public ConcreteColleague2(Mediator mediator) : base(mediator)
//    {
//    }

//    public void Send(string message)
//    {
//        mediator.Send(message, this);
//    }

//    public void Notify(string message)
//    {

//    }
//}

//class ConcreteMediator : Mediator
//{
//    public ConcreteColleague1 ConcreteColleague1 { get; set; }
//    public ConcreteColleague2 ConcreteColleague2 { get; set; }

//    public override void Send(string message, Colleague colleague)
//    {
//        if (ConcreteColleague1 == colleague)
//            ConcreteColleague2.Notify(message);
//        else
//            ConcreteColleague1.Notify(message);
//    }
//}

