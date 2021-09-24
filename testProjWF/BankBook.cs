using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProjWF
{
    [Serializable]
    public class BankBooks
    {
        public List<BankBook> bankBooks { get; set; } = new List<BankBook>();
        public BankBooks()
        { }
    }

    [Serializable]
    public class BankBook
    {
        public int accountNum { get; set; }
        public Person responsiblePerson { get; set; }
        public ServiceProvider serviceProvider { get; set; }
        public ServiceBalances serviceBalances { get; set; }
        public LogChanges logChanges { get; set; }
        public BankBook()
        {
        }
        public BankBook(int accountNum, Person person,ServiceProvider serviceProvider,ServiceBalances serviceBalances, LogChanges logChanges)
        {
            this.accountNum = accountNum;
            this.responsiblePerson = person;
            this.serviceProvider = serviceProvider;
            this.serviceBalances = serviceBalances;
            this.logChanges = logChanges;
        }
    }
}
