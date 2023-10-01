using Singleton.Infrastructure;

internal class Program
{
    private static void Main(string[] args)
    {
        //Computer comp = new Computer();
        //comp.Launch("Windows");
        //Console.WriteLine(comp.OS.Name);

        //comp.OS = OS.getInstance("Linux");
        //Console.WriteLine(comp.OS.Name);

        (new Thread(() =>
        {
            Computer comp2 = new Computer();
            comp2.OS = OS.getInstance("Linux");
            Console.WriteLine(comp2.OS.Name);
        })).Start();

        Computer comp = new Computer();
        comp.Launch("Windows");
        Console.WriteLine(comp.OS.Name);        
    }
}