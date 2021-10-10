using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{
    class Transaction
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
    }
}
