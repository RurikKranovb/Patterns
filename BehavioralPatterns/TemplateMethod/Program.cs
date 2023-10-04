using TemplateMethod.Infrastructure;

internal class Program
{
    private static void Main(string[] args)
    {
        School school = new School();
        University university = new University();

        school.Learn();
        university.Learn();


    }
}

//abstract class AbstractClass
//{
//    public void TemplateMethod()
//    {
//        Operation1();
//        Operation2();
//    }
//    public abstract void Operation2();
//    public abstract void Operation1();
//}

//class ConcreteClass : AbstractClass
//{
//    public override void Operation1()
//    {
        
//    }
//    public override void Operation2()
//    {
        
//    }
//}
