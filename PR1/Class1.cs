﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1
{
    internal class Class1
    {
        private double papersPerHour = 500;
        private int pricePerPaper = 12;

        public double CalculatePrintingTime(int papersToPrint)
        {
            double hours = papersToPrint / papersPerHour;
            return hours;
        }

        public double CalculatePrintingCost(int papersToPrint)
        {
            double cost = papersToPrint * pricePerPaper;
            return cost;
        }   
    }
}
