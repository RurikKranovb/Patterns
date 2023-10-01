using FactoryMethod.Core;
using FactoryMethod.Infrastrecture;

internal class Program
{
    private static void Main(string[] args)
    {
        Developer dev = new PanelDeveloper("OOO K");
        House house = dev.Creater();

        dev = new WoodDeveloper("Самозанятый");
        House house1 = dev.Creater();


        Console.WriteLine("Hello, World!");
    }


    //abstract class Product
    //{

    //}

    //class ConcreteProductA : Product { }
    //class ConcreteProductB : Product { }

    //abstract class Creator
    //{
    //    public abstract Product FactoryMethod();
    //}

    //class ConcreteCreatorA : Creator
    //{
    //    public override Product FactoryMethod()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //class ConcreteCreatorB : Creator
    //{
    //    public override Product FactoryMethod()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

}