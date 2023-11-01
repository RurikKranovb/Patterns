using Facade.Core;
using Facade.Infrastructure;

internal class Program
{
    private static void Main(string[] args)
    {
        TextEditor textEditor = new TextEditor();
        Compiller compiller = new Compiller();
        CLR clr = new CLR();

        VisualStudioFacade ide = new VisualStudioFacade(textEditor, compiller, clr);

        Programmer programmer = new Programmer();
        programmer.CreateApplication(ide);
    }
}

//public class SubsystemA
//{
//    public void A1() { }
//}

//public class SubsystemB
//{
//    public void B1() { }
//}

//public class SubsystemC
//{
//    public void C1() { }
//}

//public class Facade
//{
//    SubsystemA subsystemA;
//    SubsystemB subsystemB;
//    SubsystemC subsystemC;

//    public Facade(SubsystemA subsystemA, SubsystemB subsystemB, SubsystemC subsystemC)
//    {
//        this.subsystemA = subsystemA;
//        this.subsystemB = subsystemB;
//        this.subsystemC = subsystemC;
//    }

//    public void Operation1()
//    {
//        subsystemA.A1();
//        subsystemB.B1();
//        subsystemC.C1();
//    }
//    public void Operation2()
//    {
//        subsystemB.B1();
//        subsystemC.C1();
//    }
//}

//class Client
//{
//    public void Main()
//    {
//        Facade facade = new Facade(new SubsystemA(), new SubsystemB(), new SubsystemC());
//        facade.Operation1();
//        facade.Operation2();
//    }
//}


