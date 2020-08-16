using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECG_Analyzer.Models
{
    public class MyData
    {
        public List<int> PData = new List<int>();
        public List<int> QData = new List<int>();
        public List<int> RData = new List<int>();
        public List<int> SData = new List<int>();
        public List<int> TData = new List<int>();
        public List<int> PatientId = new List<int>();
        public List<int> DayCount = new List<int>();
        public List<int> Cycle = new List<int>();
        public List<int> AverageRowData = new List<int>();
        public int Id { get; set; }

    }
}
