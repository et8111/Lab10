﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Circle
    {
        private double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }
        public string CalculateFormattedCircumference()   //calcFormattedCirc() -> formatNumber( ->  calcCirc() ) return!
        {
            return FormatNumber(CalculateCircumference());
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public string CalculateFormattedArea()            //CalcFormattedArea() -> formatNumber( -> CalcArea() ) return!
        {
            return FormatNumber(CalculateArea());
        }

        private string FormatNumber(double x)
        {
            return Math.Round(x,2).ToString();
        }
    }
}
