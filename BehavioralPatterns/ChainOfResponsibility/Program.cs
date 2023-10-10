using ChainOfResponsibility.Core;
using ChainOfResponsibility.Infrastructure;

internal class Program
{
    private static void Main(string[] args)
    {
        Receiver receiver = new Receiver(false, true, true);

        PaymentHandler bankPaymentHandler = new BankPaymentHandler();
        PaymentHandler moneyPaymentHadler = new MoneyPaymentHandler();
        PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();
        //bankPaymentHandler.Successor = paypalPaymentHandler;
        paypalPaymentHandler.Successor = moneyPaymentHadler;

        bankPaymentHandler.Handle(receiver);
    }
}

//class Client
//{
//    void Main()
//    {
//        Handler h1 = new ConcreteHandler1();
//        Handler h2 = new ConcreteHandler2();
//        h1.Successor = h2;
//        h1.HandleRequest(2);
//    }
//}

//abstract class Handler
//{
//    public Handler Successor { get; set;}
//    public abstract void HandleRequest(int id);
//}

//class ConcreteHandler1 : Handler
//{
//    public override void HandleRequest(int id)
//    {
//        if (id == 1)
//        {
//            // завершение выполнения запроса;
//        }
//        // передача запроса дальше по цепи при наличии в ней обработчиков
//        else if (Successor != null)
//        {
//            Successor.HandleRequest(id);
//        }
//    }
//}

//class ConcreteHandler2 : Handler
//{
//    public override void HandleRequest(int id)
//    {

//        if (id == 2)
//        {
//            // завершение выполнения запроса;
//        }
//        else if (Successor != null)
//        {
//            Successor.HandleRequest(id);
//        }
//    }
//}