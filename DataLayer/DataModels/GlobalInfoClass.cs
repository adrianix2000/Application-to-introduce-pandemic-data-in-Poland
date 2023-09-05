using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid_Data.DataLayer.DataModels
{
    public class GlobalInfoClass
    {
        public double NewConfirmed { get; set; }

        public double TotalConfirmed { get; set; }

        public double NewDeaths { get; set; }

        public double TotalDeaths { get; set; }

        public double NewRecovered { get; set; }

        public double TotalRecovered { get; set; }
    }
}
