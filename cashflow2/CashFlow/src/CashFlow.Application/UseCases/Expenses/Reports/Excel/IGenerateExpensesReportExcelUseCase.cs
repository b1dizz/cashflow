namespace CashFlow.Application.UseCases.Expenses.Reports.Excel;
public interface IGenerateExpensesReportExcelUseCase
{
    Task<byte[]> Excecute(DateOnly month);
}
