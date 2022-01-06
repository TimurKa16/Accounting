using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;


namespace Accounting
{
    static class Storage
    {
        static int historyMaxId = -2;
        static int monthlyPaymentMaxId = -2;
        static bool dbIsInitialized = false;


        static LinqToSqlDataContext context = null;

        public static void Init()
        {

            //context = new LinqToSqlDataContext(
            //    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=AccountingDB.mdf;Integrated Security=True");



            context = new LinqToSqlDataContext(
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Public\Documents\Timur\AccountingDB.mdf;Integrated Security=True");
           
        }

        //_____________________________________________________________________________________________//
        public static List<TransactionsTable> LoadHistory(int numberOfDays)
        {
            if (!dbIsInitialized)
            {
                Init();
                dbIsInitialized = true;
            }
            try
            {
                historyMaxId = context.TransactionsTable.Max(t => t.T_Id);
            }
            catch(Exception)
            {
                historyMaxId = 0;
            }

            List<TransactionsTable> transactionList;

            if (numberOfDays == 0)
                transactionList = context.TransactionsTable.OrderByDescending(
                    table => table.T_Date).AsEnumerable().ToList();
            else
                transactionList = context.TransactionsTable
                                    .Where(t => (DateTime.Now  - t.T_Date).Value.TotalDays < numberOfDays)
                                    .OrderByDescending(t => t.T_Date)
                                    .ToList();
            
            return transactionList;
        }



        public static void AddHistory(TransactionsTable transactionsTable)
        {
            transactionsTable.T_Id = ++historyMaxId;
            context.TransactionsTable.InsertOnSubmit(transactionsTable);
            context.SubmitChanges();
        }

        public static void DeleteHistory(int id)
        {
            var transaction = context.TransactionsTable.FirstOrDefault(t => t.T_Id.Equals(id));
            context.TransactionsTable.DeleteOnSubmit(transaction);
            context.SubmitChanges();
        }

        public static void UpdateHistory(TransactionsTable transactionsTable)
        {
            //TransactionsTable tmpTransactionsTable = context.TransactionsTable.FirstOrDefault(t => t.T_Id == transactionsTable.T_Id);
            //tmpTransactionsTable = transactionsTable;
            context.SubmitChanges();
        }

        //_____________________________________________________________________________________________//
        static List<string> fromDebts;
        static List<string> toDebts;
        static List<Debt> debtList;

        public static List<Debt> LoadDebts(int debtIndex)
        {
            fromDebts = new List<string>();
            toDebts = new List<string>();
            debtList = new List<Debt>();

            // Ищем по истории
            if (debtIndex == ((int)WhoComboBoxItems.All))
            {
                fromDebts = context.TransactionsTable
                    .OrderByDescending(t => t.T_Date)
                    .Select(t => t.T_From).Distinct().ToList();

                toDebts = context.TransactionsTable
                    .OrderByDescending(t => t.T_Date)
                    .Select(t => t.T_To).Distinct().ToList();
            }
            else if (debtIndex == ((int)WhoComboBoxItems.FromMe))
            {
                fromDebts = context.TransactionsTable
                    .OrderByDescending(t => t.T_Date)
                    .Select(t => t.T_From).Distinct().ToList();

                toDebts.Add("Я");
            }
            else if (debtIndex == ((int)WhoComboBoxItems.ToMe))
            {
                fromDebts.Add("Я");

                toDebts = context.TransactionsTable
                    .OrderByDescending(t => t.T_Date)
                    .Select(t => t.T_To).Distinct().ToList();
            }

            ReadDebts();
            DistinctDebts();            

            return debtList;

        }

        private static void ReadDebts()
        {
            for (int i = 0; i < fromDebts.Count; i++)
                for (int j = 0; j < toDebts.Count; j++)
                {
                    try
                    {
                        if (fromDebts[i] != toDebts[j])
                        {
                            var sum = context.TransactionsTable
                                .Where(t => (t.T_From == fromDebts[i]) & (t.T_To == toDebts[j]))
                                .Select(t => t.T_Amount.Value).Sum();

                            debtList.Add(new Debt
                            {
                                To = fromDebts[i],
                                From = toDebts[j],
                                Amount = sum
                            });
                        }
                    }
                    catch (Exception) { }
                }
        }

        private static void DistinctDebts()
        {
            for (int i = 0; i < debtList.Count; i++)
                for (int j = i + 1; j < debtList.Count; j++)
                {
                    if ((debtList[i].From == debtList[j].To) ||
                        (debtList[i].To == debtList[j].From))
                    {
                        if (debtList[i].Amount > debtList[j].Amount)
                        {
                            debtList[i].Amount = debtList[i].Amount - debtList[j].Amount;
                            debtList[i].From = debtList[i].From;
                            debtList[i].To = debtList[i].To;

                            debtList.RemoveAt(j);
                        }
                        else if (debtList[i].Amount < debtList[j].Amount)
                        {
                            debtList[i].Amount = debtList[j].Amount - debtList[i].Amount;
                            debtList[i].From = debtList[j].From;
                            debtList[i].To = debtList[j].To;

                            debtList.RemoveAt(j);
                        }
                        else
                        {
                            debtList.RemoveAt(i);
                            if (j > i)
                                debtList.RemoveAt(j - 1);
                            else
                                debtList.RemoveAt(j);
                        }
                    }
                }
        }

        enum WhoComboBoxItems
        {
            All = 0,
            ToMe = 1,
            FromMe = 2
        }

        //_____________________________________________________________________________________________//

        static List<MonthlyPaymentTable> monthlyPaymentList;

        public static List<MonthlyPaymentTable> LoadNotHandledMonthlyPayments()
        {
            var list = context.MonthlyPaymentTable
                .Where(t => (t.M_LastDate == null) ||
                (
                ((DateTime.Now.Month > t.M_LastDate.Value.Month) || (DateTime.Now.Year > t.M_LastDate.Value.Year)) && (DateTime.Now.Day >= t.M_LastDate.Value.Day)) ||
                (((DateTime.Now.Month > t.M_LastDate.Value.Month) || (DateTime.Now.Year > t.M_LastDate.Value.Year)) && (DateTime.Now.Day >= t.M_Date)) ||
                ((DateTime.Now.Month == t.M_LastDate.Value.Month) && (DateTime.Now.Year == t.M_LastDate.Value.Year) && (t.M_LastDate.Value.Day < t.M_Date) && (DateTime.Now.Day >= t.M_Date))
                )
                .Select(t => t).ToList();

            return list;
        }

        public static List<MonthlyPaymentTable> LoadMonthlyPayments(int monthlyPaymentIndex)
        {
            try
            {
                monthlyPaymentMaxId = context.MonthlyPaymentTable.Max(t => t.M_Id);
            }
            catch (Exception)
            {
                monthlyPaymentMaxId = 0;
            }

            monthlyPaymentList = new List<MonthlyPaymentTable>();

            if (monthlyPaymentIndex == ((int)WhoComboBoxItems.All))
            {
                monthlyPaymentList = context.MonthlyPaymentTable.OrderByDescending(t => t.M_Id).ToList();
            }
            else if (monthlyPaymentIndex == ((int)WhoComboBoxItems.FromMe))
            {
                monthlyPaymentList = context.MonthlyPaymentTable
                    .OrderByDescending(t => t.M_Id)
                    .Where(t => t.M_From == "Я")
                    .Select(t => t)
                    .ToList();
            }
            else if (monthlyPaymentIndex == ((int)WhoComboBoxItems.ToMe))
            {
                monthlyPaymentList = context.MonthlyPaymentTable
                     .OrderByDescending(t => t.M_Id)
                     .Where(t => t.M_To == "Я")
                     .Select(t => t)
                     .ToList();
            }

            return monthlyPaymentList;
        }

        public static void AddMonthlyPayment(MonthlyPaymentTable monthlyPaymentTable)
        {
            monthlyPaymentTable.M_Id = ++monthlyPaymentMaxId;
            context.MonthlyPaymentTable.InsertOnSubmit(monthlyPaymentTable);
            context.SubmitChanges();
        }

        public static void DeleteMonthlyPayment(int id)
        {
            var monthlyPayment = context.MonthlyPaymentTable.FirstOrDefault(t => t.M_Id.Equals(id));
            context.MonthlyPaymentTable.DeleteOnSubmit(monthlyPayment);
            context.SubmitChanges();
        }

        public static void UpdateMonthlyPayment(MonthlyPaymentTable monthlyPaymentTable)
        {
            context.SubmitChanges();
        }
    }
}
