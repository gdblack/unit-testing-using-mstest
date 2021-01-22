using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeService
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }
            return true;
        }
    }
}
