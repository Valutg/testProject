using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProjWF
{
    [Serializable]
    public class Persons
    {
        public List<Person> personList { get; set; } = new List<Person>();

    }


    [Serializable]
    public class Person : IObservable
    {
        
        public int id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string patronym { get; set; }
        public DateTime startReside { get; set; }
        public DateTime endReside { get; set; }
        public LivingSpace livingSpace { get; set; }

        public string fullName => $"{lastName} {firstName} {patronym}";

        private List<IObserver> observers;

      
        public Person() { }
        public Person(string lastName, string firstName, string patronym, int id, DateTime startReside, DateTime endReside, LivingSpace livingSpace)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.patronym = patronym;
            this.id = id;
            this.livingSpace = livingSpace;
            this.startReside = startReside;
            this.endReside = endReside;
         
        }
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(this);
            }
        }

    }
}
