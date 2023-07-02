namespace ChainOfResponsibility1;


public record Employee(string Name, decimal ApprovalLimit) : IExpensesApprover
{
    public ApprovalResponse ApproveExpense(IExpensesReport report)
    {
        ArgumentNullException.ThrowIfNull(report);
        if (report.TotalExpenses > ApprovalLimit)
        {
            return ApprovalResponse.BeyonApprovalLimit;
        }

        return ApprovalResponse.Approved;
    }
}

public class ExpensesHandler : IExpensesHandler
{
    private readonly IExpensesApprover _approver;
    private IExpensesHandler _nextHandler;
    public ExpensesHandler(IExpensesApprover approver)
    {
        _approver = approver;
    }
    public ApprovalResponse ApproveExpense(IExpensesReport report)
    {
        var res = _approver.ApproveExpense(report);
        if (res == ApprovalResponse.Approved)
        {
            Console.WriteLine($"The Expense is Approved.");
            return res;
        }
        if (_nextHandler is null)
        {
            Console.WriteLine("The Expense is denied.");
            return ApprovalResponse.Denied;
        }
        return _nextHandler.ApproveExpense(report);
    }

    public IExpensesHandler RegisterNext(IExpensesHandler approver)
    {
        _nextHandler = approver;
        return _nextHandler;
    }
}
public interface IExpensesHandler : IExpensesApprover
{
    IExpensesHandler RegisterNext(IExpensesHandler handler);
}

public interface IExpensesReport
{
    decimal TotalExpenses { get; set; }
}


public class ExpensesReport : IExpensesReport
{
   public decimal TotalExpenses { get; set; }
}


public interface IExpensesApprover
{
    ApprovalResponse ApproveExpense(IExpensesReport report);
}


public enum ApprovalResponse
{
    Denied,
    Approved, 
    BeyonApprovalLimit
}