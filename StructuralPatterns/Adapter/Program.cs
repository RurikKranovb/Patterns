using Adapter.Core;
using Adapter.Infrastructure;

internal class Program
{
    private static void Main(string[] args)
    {
        // путушественник
        Drive driver = new Drive();
        // машина
        Auto auto = new Auto();
        // отправляемся в путешествие
        driver.Travel(auto);
        // встретились пески, надо использовать верблюда
        Camel camel = new Camel();
        // используем адаптер
        ITransport camelTransport = new CamalToTransportAdapter(camel);
        // продолжаем путь по пескам пустыни
        driver.Travel(camelTransport);
    }
}

//class Client
//{
//    public void Request(Target target)
//    {
//        target.Request();
//    }
//}

//class Target
//{
//    public virtual void Request() { }
//}

//class Adapter : Target
//{
//    private Adaptee adaptee = new Adaptee();

//    public override void Request()
//    {
//        adaptee.SpecificRequest();
//    }
//}

//class Adaptee
//{
//    public void SpecificRequest() { }
//}