using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR1
{
    internal class PrintService
    {
         double PapersPerHour;
         int PricePerPaper;
         int PapersToPrint;

        public PrintService()
        {
            PapersPerHour = 500;
            PricePerPaper = 12;
        }
        public void setPapersToPrint(int papersToPrint)
        {
            this.PapersToPrint = papersToPrint;
        }

        public double CalculatePrintingTime()
        {
            double hours = PapersToPrint / PapersPerHour;
            return hours;
        }

        public double CalculatePrintingCost()
        {
            double cost = PapersToPrint * PricePerPaper;
            return cost;
        }
    }
}
