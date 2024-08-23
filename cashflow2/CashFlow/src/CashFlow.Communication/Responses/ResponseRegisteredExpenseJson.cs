namespace CashFlow.Communication.Responses;

public class ResponseRegisteredExpenseJson
{
    public string Title { get; set; } = string.Empty;
    public object Expenses { get; set; }
}
