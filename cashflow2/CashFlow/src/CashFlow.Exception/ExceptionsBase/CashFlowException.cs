namespace CashFlow.Exception.ExceptionsBase;

public abstract class CashFlowException : SystemException
{
    protected CashFlowException(string massage) : base(massage)
    {
        
    }

    public abstract int StatusCode { get; }
    public abstract List<string> GetErrors();
}
