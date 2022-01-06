using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{
    static class Logic
    {

        private static void Init()
        {
            Storage.Init();
        }

        private static List<TransactionsTable> LoadHistory(int numberOfDays)
        {
            return Storage.LoadHistory(numberOfDays);
        }

        private static void AddHistory(TransactionsTable transactionsTable)
        {
            Storage.AddHistory(transactionsTable);
        }

        private static void DeleteHistory(int id)
        {
            Storage.DeleteHistory(id);
        }

        private static void UpdateHistory(TransactionsTable transactionsTable)
        {
            Storage.UpdateHistory(transactionsTable);
        }

        private static List<Debt> LoadDebts(int debtIndex)
        {
            return Storage.LoadDebts(debtIndex);
        }

        //__________________________________________________________________________________________________//

        private static List<MonthlyPaymentTable> LoadNotHandledMonthlyPayments()
        {
            return Storage.LoadNotHandledMonthlyPayments();
        }

        private static List<MonthlyPaymentTable> LoadMonthlyPayments(int monthlyPaymentIndex)
        {
            return Storage.LoadMonthlyPayments(monthlyPaymentIndex);
        }

        private static void AddMonthlyPayment(MonthlyPaymentTable monthlyPaymentTable)
        {
            Storage.AddMonthlyPayment(monthlyPaymentTable);
        }

        private static void DeleteMonthlyPayment(int id)
        {
            Storage.DeleteMonthlyPayment(id);
        }

        private static void UpdateMonthlyPayment(MonthlyPaymentTable monthlyPaymentTable)
        {
            Storage.UpdateMonthlyPayment(monthlyPaymentTable);
        }

    }
}
