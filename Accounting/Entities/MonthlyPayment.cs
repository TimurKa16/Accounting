using System;

namespace Accounting
{
    public class MonthlyPayment
    {   
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int Amount { get; set; }        
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
