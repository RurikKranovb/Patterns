using Memento.Infrastructure;

internal class Program
{
    private static void Main(string[] args)
    {

        Hero hero = new Hero();
        hero.Shoot(); // делаем выстрел
        GameHistory game = new GameHistory();

        game.History.Push(hero.SaveState()); // сохраняем игру

        hero.Shoot(); //делаем выстрел

        hero.RestoreState(game.History.Pop());

        hero.Shoot(); //делаем выстрел
    }
}

//class Memento
//{
//    public string State { get; private set; }
//    public Memento(string state)
//    {
//        State = state;
//    }
//}

//class Caretake
//{
//    public Memento Memento { get; set; }
//}

//class Originator
//{
//    public string State { get; set; }
//    public void SetMemento(Memento memento)
//    {
//        State = memento.State;
//    }
//    public Memento CreateMemento()
//    {
//        return new Memento(State);
//    }
//}