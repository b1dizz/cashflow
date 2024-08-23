using CashFlow.Communication.Responses;
using CashFlow.Communication.Resquests;

namespace CashFlow.Application.UseCases.Expenses.Register;
public interface IRegisterExpenseUseCase
{
    Task <ResponseRegisteredExpenseJson> Execute(RequestExpenseJson request);
}
