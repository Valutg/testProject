using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProjWF
{
    [Serializable]
    public class LogChanges
    {
        public List<LogChange> logChanges = new List<LogChange>();
        public LogChanges() 
        { }
    }
    [Serializable]
    public class LogChange
    {
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public Tariffs tariffs { get; set; }
        public int countReside { get; set; }
        public LogChange()
        {

        }
        public LogChange(DateTime start,DateTime end, Tariffs tariffs, int countReside)
        {
            this.start = start;
            this.end = end;
            this.tariffs=tariffs;
            this.countReside = countReside;
        }


    }
}
