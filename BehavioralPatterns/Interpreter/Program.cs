using Interpreter.Core;
using Interpreter.Infrastructure;
using System.Linq.Expressions;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        Context context = new Context();
        
        int x = 5;
        int y = 8;
        int z = 2;
       
        context.SetVariable("x", x);
        context.SetVariable("y", y);
        context.SetVariable("z", z);
       
        IExpression expression = new SubtractExpression(
            new AddExpression(
                new NumberExpression("x"),
                new NumberExpression("y")),
            new NumberExpression("z")
        );

        int result = expression.Interpret(context);
        Console.WriteLine("результат: {0}", result);
    }
}

//
//реализациия грамматики:
//IExpression::= NumberExpression | Constant | AddExpression | SubtractExpression
//AddExpression::= IExpression + IExpression
//SubtractExpression::= IExpression - IExpression
//NumberExpression::= [A - Z, a - z] +
//Constant::= [1 - 9] +

//class Client
//{
//    void Main()
//    {
//        Context context = new Context();

//        var expression = new NonterminalExpression();
//        expression.Interpret(context);
//    }
//}

//class Context {}

//abstract class AbstractExpression
//{
//    public abstract void Interpret(Context context);
//}

//class TerminalExpression : AbstractExpression
//{
//    public override void Interpret(Context context)
//    {

//    }
//}

//class NonterminalExpression : AbstractExpression
//{
//    AbstractExpression expression1;
//    AbstractExpression expression2;
//    public override void Interpret(Context context)
//    {

//    }
//}