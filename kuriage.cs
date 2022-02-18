using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jetcoster
{
    public class Kuriage
    {
        public static int kuriage10(int j)
        {
            double i, k, p;
            int q;
            if (j >= 0)
            {

                i = (double)j;

                k = i / 10;

                p = Math.Ceiling(k);

                q = (int)p * 10;
            }
            else
            {
                i = (double)j;

                k = i / 10;

                p = Math.Floor(k);

                q = (int)p * 10;
            }

            return q;
        }
    }
}
