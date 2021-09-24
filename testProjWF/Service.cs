using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProjWF
{
    public class Services 
    {
        public List<Service> serviceList { get; set; } = new List<Service>();
        public Services()
        {
            Service service = new Service("Отопление");   
            serviceList.Add(service);
            service = new Service("Электроэнергия");
            serviceList.Add(service);
            service = new Service("Водоотведение");
            serviceList.Add(service);
            service = new Service("Капитальный ремонт");
            serviceList.Add(service);
            service = new Service("Холодная вода");
            serviceList.Add(service);
            service = new Service("Горячая вода");
            serviceList.Add(service);
            service = new Service("Вывоз ТКО");
            serviceList.Add(service);
        }
    }

    public class Service
    {
        public string name { get; set;  }
        public Service() { }
        public Service(string name)
        {
            this.name = name;
        }
    }
}
