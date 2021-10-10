using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{
    public static class Logic
    {

        public static IEnumerable<TransactionsTable> Load()
        {
            return Storage.Load();
        }

        public static void Add(TransactionsTable transactionsTable)
        {
            Storage.Add(transactionsTable);
        }
    }
}
