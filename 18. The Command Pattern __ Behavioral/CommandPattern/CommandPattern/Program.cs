using CommandPattern.Commands;
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoker = new Invoke();
            var text = new MyText();
            text.WriteNewLine("Hi I am Ahmed \n");
            text.WriteNewLine("Hello This is a mistake \n");
            text.Print();
            var undoCommand = new UndoCommand(text);
            var redoCommand = new RedoCommand(text);
            invoker.SetCommand(undoCommand);
            invoker.ExecuteCommand();
            Console.WriteLine("==============================================");
            Console.WriteLine("Undo Completed");
            Console.WriteLine("==============================================");
            text.Print();
            text.WriteNewLine("Hell I now write good \n");
            text.WriteNewLine("Let's complete our work \n");
            invoker.ExecuteCommand();
            Console.WriteLine("==============================================");
            Console.WriteLine("Undo Completed");
            Console.WriteLine("==============================================");
            text.Print();
            invoker.SetCommand(redoCommand);
            invoker.ExecuteCommand();
            Console.WriteLine("==============================================");
            Console.WriteLine("Redo Completed");
            Console.WriteLine("==============================================");
            text.Print();



        }
    }
}
