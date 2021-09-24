using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProjWF
{
    [Serializable]
    public class ServiceBalances
    {
        public List<ServiceBalance> serviceBalances { get; set; } = new List<ServiceBalance>();
        public ServiceBalances()
        {
        }
        public string getOverpay()
        {
            string res = String.Empty;
            for (int i = 0; i < serviceBalances.Count; i++)
                res += serviceBalances[i].service.name + " : ;" + serviceBalances[i].overpay.ToString() + "; ";
            return res;
        }
        public string getDebt()
        {
            string res = String.Empty;
            for (int i = 0; i < serviceBalances.Count; i++)
                res += serviceBalances[i].service.name + " : " + serviceBalances[i].debt.ToString() + "; ";
            return res;
        }
    }
    [Serializable]
    public class ServiceBalance : Tariff
    {
        public decimal overpay;
        public decimal debt;

        public ServiceBalance()
        {
        }
        public ServiceBalance(decimal cost, Service service, decimal overpay, decimal debt)
        {
            this.cost = cost;
            this.service = service;
            this.debt = debt;
            this.overpay = overpay;
        }

    }
}
