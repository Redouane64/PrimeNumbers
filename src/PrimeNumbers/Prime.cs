using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    public static class Prime
    {
        public static uint[] GetPrimeNumbers(int max)
        {
            int total = max < 4 ? 4 : max;
            uint[] primes = new uint[total];
            primes[0] = 2;
            primes[1] = 3;
            primes[2] = 5;

            bool found = false;
            uint trial = 5;
            int count = 3;

            while (count < total)
            {
                trial += 2;
                for (int i = 0; i < count; i++)
                {
                    found = (trial % primes[i] != 0);
                    if (!found)
                    {
                        break;
                    }
                }

                if (found)
                {
                    primes[count++] = trial;
                }
            }

            return primes;
        }
    }
}
