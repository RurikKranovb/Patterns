using AbstractFactory.Infrastructure;

internal class Program
{
    private static void Main(string[] args)
    {

        Hero elf = new Hero(new ElfFactory());
        elf.Run();
        elf.Hit();


        Hero voin = new Hero(new VoinFactory());
        voin.Run();
        voin.Hit();


        Console.WriteLine("Hello, World!");
    }


    //abstract class AbstractFactory
    //{
    //    public abstract AbstractProductA CreateProductA();
    //    public abstract AbstractProductB CreateProductB();
    //}
    //class ConcreteFactory1 : AbstractFactory
    //{
    //    public override AbstractProductA CreateProductA()
    //    {
    //        return new ProductA1();
    //    }

    //    public override AbstractProductB CreateProductB()
    //    {
    //        return new ProductB1();
    //    }
    //}
    //class ConcreteFactory2 : AbstractFactory
    //{
    //    public override AbstractProductA CreateProductA()
    //    {
    //        return new ProductA2();
    //    }

    //    public override AbstractProductB CreateProductB()
    //    {
    //        return new ProductB2();
    //    }
    //}

    //abstract class AbstractProductA
    //{ }

    //abstract class AbstractProductB
    //{ }

    //class ProductA1 : AbstractProductA
    //{ }

    //class ProductB1 : AbstractProductB
    //{ }

    //class ProductA2 : AbstractProductA
    //{ }

    //class ProductB2 : AbstractProductB
    //{ }

    //class Client
    //{
    //    private AbstractProductA abstractProductA;
    //    private AbstractProductB abstractProductB;

    //    public Client(AbstractFactory factory)
    //    {
    //        abstractProductB = factory.CreateProductB();
    //        abstractProductA = factory.CreateProductA();
    //    }
    //    public void Run() { }
    //}


}