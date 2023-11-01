using Proxy.Infrastructure;

internal class Program
{
    private static void Main(string[] args)
    {
        using (Proxy.Core.IBook book = new BookStoreProxy())
        {
            // читаем первую страницу
            Page page1 = book.GetPage(1);
            Console.WriteLine(page1.Text);
            // читаем вторую страницу
            Page page2 = book.GetPage(2);
            Console.WriteLine(page2.Text);
            // возвращаемся на первую страницу    
            page1 = book.GetPage(1);
            Console.WriteLine(page1.Text);
        }
    }
}

//class Client
//{
//    void Main()
//    {
//        Subject subject = new Proxy();
//        subject.Request();
//    }
//}
//abstract class Subject
//{
//    public abstract void Request();
//}

//class RealSubject : Subject
//{
//    public override void Request()
//    { }
//}
//class Proxy : Subject
//{
//    RealSubject realSubject;
//    public override void Request()
//    {
//        if (realSubject == null)
//            realSubject = new RealSubject();
//        realSubject.Request();
//    }
//}