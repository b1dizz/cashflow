using CashFlow.Domain.Enums;
using CashFlow.Domain.Payment;

namespace CashFlow.Domain.Extensions;

public static class PaymentTypeExtensions
{
    public static string PaymentTypeToString(this PaymentType paymentType)
    {
        return paymentType switch
        {
            PaymentType.Cash => ResourcePaymentMessages.CASH,
            PaymentType.CreditCard => ResourcePaymentMessages.CREDIT_CARD,
            PaymentType.DebitCard => ResourcePaymentMessages.DEBIT_CARD,
            PaymentType.EletronicTransfer => ResourcePaymentMessages.ELETRONIC_TRANSFER,
            _ => string.Empty
        };
    }
    
}
