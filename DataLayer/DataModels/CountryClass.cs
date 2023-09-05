using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid_Data.DataLayer.DataModels
{
    public class CountryClass
    {
        public string Country { get; set; }

        public string CountryCode { get; set; }

        public double TotalDeaths { get; set; }

        public double TotalConfirmed { get; set; }

        public double NewConfirmed { get; set; }

        public double NewDeaths { get; set; }
    }
}
