using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZdravoCorp.Users;
using ZdravoCorp.Model;
using Newtonsoft.Json;

namespace ZdravoCorp.Repository
{
    internal class ChartRepository
    {
        public static List<Chart> charts = new List<Chart>();
        
        public void CreateChartFile(Chart chart)
        {
            string fileName = chart.GetChartFilename();

            //Make a file with filename and load it with chart info
        }

        public void DeleteChart(string chartFilename)
        {
            //delete chart from system only if deleting a patient alltogether.
        }

        public Chart GetLastChart()
        {
            return charts.Last();
        }
    }
}
