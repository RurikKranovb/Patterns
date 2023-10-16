using Decorator.Core;
using Decorator.Infrastructure;

internal class Program
{
    private static void Main(string[] args)
    {
        Pizza pizza1 = new ItalianPizza();
        pizza1 = new TomatoPizza(pizza1); // итальянская пицца с томатами
        Console.WriteLine("Название: {0}", pizza1.Name);
        Console.WriteLine("Цена: {0}", pizza1.GetCost());

        Pizza pizza2 = new ItalianPizza();
        pizza2 = new CheesePizza(pizza2);// итальянская пиццы с сыром
        Console.WriteLine("Название: {0}", pizza2.Name);
        Console.WriteLine("Цена: {0}", pizza2.GetCost());

        Pizza pizza3 = new BulgerianPizza();
        pizza3 = new TomatoPizza(pizza3);
        pizza3 = new CheesePizza(pizza3);// болгарская пиццы с томатами и сыром
        Console.WriteLine("Название: {0}", pizza3.Name);
        Console.WriteLine("Цена: {0}", pizza3.GetCost());
    }
}

//abstract class Component
//{
//    public abstract void Operation();
//}

//class ConcreteComponent : Component
//{
//    public override void Operation()
//    { }
//}
//abstract class Decorator : Component
//{
//    protected Component component;

//    public void SetComponent(Component component)
//    {
//        this.component = component;
//    }

//    public override void Operation()
//    {
//        if (component != null)
//            component.Operation();
//    }
//}
//class ConcreteDecoratorA : Decorator
//{
//    public override void Operation()
//    {
//        base.Operation();
//    }
//}
//class ConcreteDecoratorB : Decorator
//{
//    public override void Operation()
//    {
//        base.Operation();
//    }
//}