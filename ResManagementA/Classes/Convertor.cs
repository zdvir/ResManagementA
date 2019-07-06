using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This Class Handle Convert Types and Values
namespace ResManagement.Classes
{
    class Convertor
    {
        public Convertor()
        {

        }

        // Convert big Numbers to K,M(Miliion),Or B(Billion) Format.
        // 1,000,000 -> 1M , 100,000 -> 100K, and etc...
        public static string ToKMB(int num)
        {
            if (num > 999999999 || num < -999999999)
            {
                return num.ToString("0,,,.###B", CultureInfo.InvariantCulture);
            }
            else if (num > 999999 || num < -999999)
            {
                return num.ToString("0,,.##M", CultureInfo.InvariantCulture);
            }
            else if (num > 999 || num < -999)
            {
                return num.ToString("0,.#K", CultureInfo.InvariantCulture);
            }
            else
            {
                return num.ToString(CultureInfo.InvariantCulture);
            }
        }
    }
}
