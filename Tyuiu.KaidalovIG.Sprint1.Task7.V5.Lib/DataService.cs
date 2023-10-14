﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KaidalovIG.Sprint1.Task7.V5.Lib
{
    public class DataService : ISprint1Task7V21
    {
        public double Calculate(double x, double y)
        {
            double a;
            double action1 = (Math.Pow(y, x)) / (Math.Cos(x) - x / 3);
            double action2 = (Math.Sin(x * x) + Math.Cos(y)) / (Math.Cos(x) - Math.Sin(y));
            a = action1 + (action2 * Math.Tan(x * y));
            return a;
        }
    }
}
