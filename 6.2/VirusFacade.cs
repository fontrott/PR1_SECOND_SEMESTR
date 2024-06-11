using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _6._2.VirusFacade;

namespace _6._2
{
    public class VirusFacade
    {
        private VirusResearcher virusResearcher;
        private VirusLab virusLab;

        public VirusFacade()
        {
            virusResearcher = new VirusResearcher();
            virusLab = new VirusLab();
        }

        public void StartResearchProcess()
        {
            virusResearcher.PrepareResearch();
            virusResearcher.PerformTests();
            virusLab.AnalyzeResults();
        }
        public string DetermineVirusType(string VirusInfectionCount, string RateInfection, string VirusName)
        {
            return virusResearcher.DetermineVirusType(Convert.ToInt32(VirusInfectionCount), Convert.ToInt32(RateInfection), VirusName);
        }
    }
}
