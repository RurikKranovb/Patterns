using Strategy.Infrastructure;

internal class Program
{
    private static void Main(string[] args)
    {

        Car auto = new Car(4, "volvo", new PetrolMove());
        auto.Move();
        auto.Movable = new ElectricMove();
        auto.Move();
        Console.WriteLine("Hello, World!");
    }
}

//public interface IStrategy
//{
//    void Algorithm();
//}

//class ConcreteStrategy1 : IStrategy
//{
//    public void Algorithm()
//    {
        
//    }
//}

//class ConcreteStrategy2 : IStrategy
//{
//    public void Algorithm()
//    {

//    }
//}

//class Context
//{
//    public IStrategy ContextStrategy { get; set; }

//    public Context(IStrategy _strategy)
//    {
//        ContextStrategy = _strategy;
//    }

//    public void ExecuteAlgorithm()
//    {
//        ContextStrategy.Algorithm();
//    }
//}