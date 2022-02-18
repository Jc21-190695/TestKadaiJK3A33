using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jetcoster
{
    public class JetCoaster
    {
        public static int Ride
            (int k, int[] g, int r)
        {
            int[] vs = new int[g.Length];
            Array.Copy(g, vs, g.Length);

            int add = 0;
            int limit = k;

            for (int w = 0; w < r; w++)
            {
                k = limit;
                int count = 0;

                for (int i = 0; i < g.Length; i++)
                {
                    if (k >= g[i])
                    {
                        k = k - g[i];
                        add = add + g[i];
                        count = count + 1;
                    }
                    else
                    {
                        break;
                    }
                }

                for (int j = 0; j < count; j++)
                {
                    int space = g[0];
                    for (int q = 0; q < g.Length; q++)
                    {
                        if (q == g.Length - 1)
                        {
                            g[q] = space;
                        }
                        else
                        {
                            g[q] = g[q + 1];
                        }
                    }
                }
            }
            Array.Copy(vs, g, vs.Length);
            return add;
        }
    }
}
