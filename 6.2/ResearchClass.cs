using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._2
{
    public class VirusResearcher
    {
        public void PrepareResearch()
        {
            // Реализация подготовки к исследованию
        }

        public void PerformTests()
        {
            // Реализация проведения тестов
        }

        public string DetermineVirusType(int VirusInfectionCount, int RateInfection, string VirusName)
        {
            if (VirusInfectionCount > 100000 && RateInfection > 2000)
            {
                return $"Вирус {VirusName} является пандемией.";
            }
            else
            {
                return $"Вирус {VirusName} является эпидемией.";
            }
        }
    }
}
