using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayData.Model
{
    class CovidMetrics
    {
        public string DistrictName { get; set; }
        public int ConfirmedCases { get; set; }
        public int ActiveCases { get; set; }
        public int RecoveredCases { get; set; }
        public int Deaths { get; set; }
        public string VaccinesAdministered { get; set; }

        public CovidMetrics(string districtName, int confirmedCases, int activeCases, int recoveredCases, int deaths, string vaccinesAdministered)
        {
            DistrictName = districtName;
            ConfirmedCases = confirmedCases;
            ActiveCases = activeCases;
            RecoveredCases = recoveredCases;
            Deaths = deaths;
            VaccinesAdministered = vaccinesAdministered;
        }
    }
}
