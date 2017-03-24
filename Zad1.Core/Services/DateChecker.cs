using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1.Core.Services
{
    public class DateChecker : IDateChecker
    {
        public TimeSpan ShowDifference(DateTime firstDate, DateTime secondDate)
        {
            return firstDate - secondDate;
        }
    }
}
