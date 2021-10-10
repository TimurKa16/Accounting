using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{
    static class Storage
    {
        static int maxId = 0;
        public static IEnumerable<TransactionsTable> Load()
        {
            LinqToSqlDataContext context = new LinqToSqlDataContext();
            maxId = context.TransactionsTable.Max(t => t.Id);
            return context.TransactionsTable.AsEnumerable();
        }

        public static void Add(TransactionsTable transactionsTable)
        {
            using (LinqToSqlDataContext context = new LinqToSqlDataContext())
            {
                TransactionsTable transactionsTable1 = new TransactionsTable();
                transactionsTable1.Id = ++maxId;
                transactionsTable1.From = "k";
                transactionsTable1.To = "l";
                transactionsTable1.Amount = 1;
                transactionsTable1.Date = DateTime.Now.ToString();
                transactionsTable1.Description = "m";
                //transactionsTable.Id = ++maxId;
                context.TransactionsTable.InsertOnSubmit(transactionsTable1);
                context.SubmitChanges();
            }
        }



        //public static void Load()
        //{

        //}
    }
}
