using Observer.Infrastructure;
using System;

internal class Program
{
    private static void Main(string[] args)
    {

        Stock stock = new Stock();
        Bank bank = new Bank("ЮнитБанк", stock);
        Broker broker = new Broker("Иван Иваныч", stock);
        // имитация торгов
        stock.Market();
        // брокер прекращает наблюдать за торгами
        broker.StopTrade();
        // имитация торгов
        stock.Market();

        Console.WriteLine("Hello, World!");
    }
}

//interface IObservable
//{
//    void AddObserver(IObserver o);
//    void RemoveObserver(IObserver o);
//    void NotifyObservers();
//}

//class ConcreteObservable : IObservable
//{

//    private List<IObserver> observers;
//    public ConcreteObservable()
//    {
//        observers = new List<IObserver>();
//    }
//    public void AddObserver(IObserver o)
//    {
//        observers.Add(o);
//    }

//    public void NotifyObservers()
//    {
//        foreach (IObserver observer in observers)
//            observer.Update();
//    }

//    public void RemoveObserver(IObserver o)
//    {
//        observers.Remove(o);
//    }
//}

//interface IObserver
//{
//    void Update();
//}

//class ConcreteObserver : IObserver
//{
//    public void Update()
//    {
        
//    }
//}