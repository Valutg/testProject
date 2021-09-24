using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace testProjWF
{
   
    [Serializable]
    public class Tariffs
    {
        
        public List<Tariff> tariffsList { get; set; } = new List<Tariff>();
        public string name;
     
        public Tariffs()
        {
            this.name = "123";
        }
        public override string ToString()
        {
            string str = "";
            foreach (Tariff tarif in tariffsList)
                str += tarif.service.name + " ";
            return str;
        }
    }
 
    [Serializable]
    public class Tariff
    {
 
        public decimal cost { get; set; }

        public Service service { get; set; }
        public Tariff()
        {

        }
        public Tariff(decimal cost, Service service)
        {
            this.cost = cost;
            this.service = service;
        }
    }
}
