using Composite.Core;
using Composite.Infrastructure;

internal class Program
{
    private static void Main(string[] args)
    {
        Component fileSystem = new Composite.Infrastructure.Directory("Файловая система");
        // определяем новый диск
        Component diskC = new Composite.Infrastructure.Directory("Диск С");
        // новые файлы
        Component pngFile = new Composite.Infrastructure.File("12345.png");
        Component docxFile = new Composite.Infrastructure.File("Document.docx");
        // добавляем файлы на диск С
        diskC.Add(pngFile);
        diskC.Add(docxFile);
        // добавляем диск С в файловую систему
        fileSystem.Add(diskC);
        // выводим все данные
        fileSystem.Print();
        Console.WriteLine();
        // удаляем с диска С файл
        diskC.Remove(pngFile);
        // создаем новую папку
        Component docsFolder = new Composite.Infrastructure.Directory("Мои Документы");
        // добавляем в нее файлы
        Component txtFile = new Composite.Infrastructure.File("readme.txt");
        Component csFile = new Composite.Infrastructure.File("Program.cs");
        docsFolder.Add(txtFile);
        docsFolder.Add(csFile);
        diskC.Add(docsFolder);

        fileSystem.Print();

    }
}

//public class Client
//{
//    public void Main()
//    {
//        Component root = new Composite("Root");
//        Component leaf = new Leaf("Leaf");
//        Composite subtree = new Composite("Subtree");
//        root.Add(leaf);
//        root.Add(subtree);
//        root.Display();
//    }
//}

//abstract class Component
//{
//    protected string name;

//    public Component(string name)
//    {
//        this.name = name;
//    }

//    public abstract void Display();
//    public abstract void Add(Component c);
//    public abstract void Remove(Component c);
//}

//class Composite : Component
//{
//    List<Component> children = new List<Component>();

//    public Composite(string name)
//        : base(name)
//    { }

//    public override void Add(Component component)
//    {
//        children.Add(component);
//    }

//    public override void Remove(Component component)
//    {
//        children.Remove(component);
//    }

//    public override void Display()
//    {
//        Console.WriteLine(name);

//        foreach (Component component in children)
//        {
//            component.Display();
//        }
//    }
//}

//class Leaf : Component
//{
//    public Leaf(string name)
//        : base(name)
//    { }

//    public override void Display()
//    {
//        Console.WriteLine(name);
//    }

//    public override void Add(Component component)
//    {
//        throw new NotImplementedException();
//    }

//    public override void Remove(Component component)
//    {
//        throw new NotImplementedException();
//    }
//}
