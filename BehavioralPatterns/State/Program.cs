using State.Infrastructure;

internal class Program
{
    private static void Main(string[] args)
    {
        Water water = new Water(new LiquidWaterState());
        water.Heat();
        water.Frost();
        water.Frost();        
    }
}

//class Program1
//{
//    static void Main()
//    {
//        Context context = new Context(new StateA());
//        context.Request();
//        context.Request();
//    }
//}

//abstract class State
//{
//    public abstract void Handle(Context context);
//}

//class StateA : State
//{
//    public override void Handle(Context context)
//    {
//        context.State = new StateB();
//    }
//}

//class StateB : State
//{
//    public override void Handle(Context context)
//    {
//        context.State = new StateA();
//    }
//}

//class Context
//{
//    public State State { get; set; }
//    public Context(State state)
//    {
//        this.State = state;
//    }

//    public void Request()
//    {
//        this.State.Handle(this);
//    }
//}

