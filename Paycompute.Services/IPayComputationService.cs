using Paycompute.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Paycompute.Services
{
    public interface IPayComputationService
    {
        Task CreateAsyn(PaymentRecord paymentRecord);
        PaymentRecord GetById(int id);
        IEnumerable<PaymentRecord> GetAll();
        IEnumerable<SelectListItem> GetAllTaxYear();
        decimal OvertimeHours(decimal hoursWorked, decimal contratualHOurs);
        decimal ContractualEarnings(decimal contractualHours, decimal hoursWorked, decimal hourlyRate);
        decimal OvertimeRate(decimal hourlyRate);
        decimal OvertimeEarnings(decimal overtimeRate, decimal overtimeHours);
        decimal TotalEarnings(decimal overtimeEarnings, decimal contractualEarnings);
        decimal TotalDeduction(decimal tax, decimal nic, decimal studentLoanPayment, decimal unionFees);
        decimal NetPay(decimal totalEarnings, decimal totalDeduction);
    }
}
