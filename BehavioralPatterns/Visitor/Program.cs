using System.Xml.Linq;
using Visitor.Infrastructure;

internal class Program
{
    private static void Main(string[] args)
    {
        var structure = new Bank();
        structure.Add(new Person { FIO = "Иван Ива", AccNumber = "954313546" });
        structure.Add(new Company { Name = "Mimicron", RegNumber = "wqr654sdfsa61d", Number = "5646541" });
        structure.Accept(new HtmlVisitor());
        structure.Accept(new XmlVisitor());
    }
}

//class Client
//{
//    void Main()
//    {
//        var structure = new ObjectStructure();
//        structure.Add(new ElementA());
//        structure.Add(new ElementB());
//        structure.Accept(new ConcreteVisitor1());
//        structure.Accept(new ConcreteVisitor2());
//    }
//}

//abstract class Visitor
//{
//    public abstract void VisitElementA(ElementA elemA);
//    public abstract void VisitElementB(ElementB elemB);
//}

//class ConcreteVisitor1 : Visitor
//{
//    public override void VisitElementA(ElementA elementA)
//    {
//        elementA.OperationA();
//    }
//    public override void VisitElementB(ElementB elementB)
//    {
//        elementB.OperationB();
//    }
//}
//class ConcreteVisitor2 : Visitor
//{
//    public override void VisitElementA(ElementA elementA)
//    {
//        elementA.OperationA();
//    }
//    public override void VisitElementB(ElementB elementB)
//    {
//        elementB.OperationB();
//    }
//}

//class ObjectStructure
//{
//    List<Element> elements = new List<Element>();
//    public void Add(Element element)
//    {
//        elements.Add(element);
//    }
//    public void Remove(Element element)
//    {
//        elements.Remove(element);
//    }
//    public void Accept(Visitor visitor)
//    {
//        foreach (Element element in elements)
//            element.Accept(visitor);
//    }
//}

//abstract class Element
//{
//    public abstract void Accept(Visitor visitor);
//    public string SomeState { get; set; }
//}

//class ElementA : Element
//{
//    public override void Accept(Visitor visitor)
//    {
//        visitor.VisitElementA(this);
//    }
//    public void OperationA()
//    { }
//}

//class ElementB : Element
//{
//    public override void Accept(Visitor visitor)
//    {
//        visitor.VisitElementB(this);
//    }
//    public void OperationB()
//    { }
//}