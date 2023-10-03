using Command.Core;
using Command.Infrastructure;

internal class Program
{
    private static void Main(string[] args)
    {
        Put put = new Put();
        TV tv = new TV();
        put.SetCommand(new TVOnCommand(tv));
        put.PressButton();
        put.PressUndo();

        Console.Read();
    }
}

//abstract class Command
//{
//    public abstract void Execute();
//    public abstract void Undo();
//}

//class ConcreteCommand : Command
//{

//    Receiver receiver;

//    public ConcreteCommand(Receiver receiver)
//    {
//        this.receiver = receiver;
//    }

//    public override void Execute()
//    {
//        receiver.Operation();
//    }

//    public override void Undo()
//    {
       
//    }
//}

//class Receiver
//{
//    public void Operation() 
//    {

//    }
//}

//class Invoker
//{
//    Command command;
//    public void SetCommand(Command command )
//    {
//        this.command = command;
//    }

//    public void Run()
//    {
//        command.Execute();
//    }

//    public void Cancel()
//    {
//        command.Undo();
//    }
//}

//class Client
//{
//    void Main()
//    {
//        Invoker invoker = new Invoker();
//        Receiver receiver = new Receiver();
//        ConcreteCommand command = new ConcreteCommand(receiver);
//        invoker.SetCommand(command);
//        invoker.Run();

//    }
//}