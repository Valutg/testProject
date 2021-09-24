using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace testProjWF
{
    [Serializable]
    public class ServiceProviders
    {
      
        public List<ServiceProvider> providerList { get; set; } = new List<ServiceProvider>();
        public ServiceProviders()
        {

        }
    }


    [Serializable]
    public class ServiceProvider
    {
   
        public int id { get; set; }
        public string Name { get; set; }
        public Tariffs tariffs { get; set; }
        public ServiceProvider() { }
        
        public ServiceProvider(int id, string Name,Tariffs tariffs)
        {
            this.id = id;
            this.Name = Name;
            this.tariffs = tariffs;
        }

    }

}
