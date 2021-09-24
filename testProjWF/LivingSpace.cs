using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProjWF
{
    [Serializable]
    public class LivingSpaces
    {
        public List<LivingSpace> livingSpaces { get;set; }= new List<LivingSpace>();
    }
    [Serializable]
    public class LivingSpace
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public double Square { get; set; }
        public LivingSpace()
        {

        }
        public LivingSpace(int id,string address,double square)
        {
            this.Address = address;
            this.Square = square;
            this.Id = id;
        }
       
    }
}
