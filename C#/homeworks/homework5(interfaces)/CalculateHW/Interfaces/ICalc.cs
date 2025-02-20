using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateHW.Interfaces
{
    internal interface ICalc
    {
        int Less(int valueToCompare);

        int Greater(int valueToCompare);

        int CountDistinct();

        int EqualToValue(int valueToCompare);
    }
}
