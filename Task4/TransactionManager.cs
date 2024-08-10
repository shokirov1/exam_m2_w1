using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class TransactionManager
    {
        List<Transaction> transactions = new List<Transaction>();

        public void Add(Transaction transaction)
        {
            try
            {
                if(transaction !=null)
                {
                    transactions.Add(transaction);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public List<Transaction> GetFromDate(DateTime date)
        {
            try
            {
                var ckeckForDate = transactions.FindAll(x => x.Date.Year == date.Year);
                if (ckeckForDate != null)
                {
                    return ckeckForDate;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public List<Transaction> GetTransactions(DateTime date1, DateTime date2)
        {
            try
            {
                var ckeckForDateTransaction = transactions.FindAll(x => x.Date.Day >= date1.Day && x.Date.Day == date2.Day);
                if (ckeckForDateTransaction != null)
                {
                    ckeckForDateTransaction.Count();
                    return ckeckForDateTransaction;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
