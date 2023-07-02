// See https://aka.ms/new-console-template for more information

using ChainOfResponsibility1;

var expenseChainHandler = 
            new ExpensesHandler(new Employee("Ahmed", decimal.Zero));
expenseChainHandler
    .RegisterNext(new ExpensesHandler(new Employee("Mohammad", 1000)))
    .RegisterNext(new ExpensesHandler(new Employee("Ismail", 5000)))
    .RegisterNext(new ExpensesHandler(new Employee("Ibrahim", 100000)));



Console.WriteLine("Enter the expenses: ");
while (decimal.TryParse(Console.ReadLine(), out var expenseReportAmount))
{

    var expense = new ExpensesReport
    {
        TotalExpenses = expenseReportAmount
    };

    expenseChainHandler.ApproveExpense(expense);


    Console.WriteLine("Enter the expenses: ");

}

Console.WriteLine("Not A decimal, Bye.");

Console.ReadLine();