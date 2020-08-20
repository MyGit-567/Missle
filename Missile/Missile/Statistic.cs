using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Missile
{
    public class Statistic : Iseccess //calculate the statistics(for all miseles)
    {
        int _sucessRate;

        public Statistic(int sucessRate) //Constructor
        {
            _sucessRate = sucessRate;
        }

        public bool calculateRate()
        {
            Random _random = new Random();
            int num1 = _random.Next(100);
            return _sucessRate>= num1; //we can use it if it's true
        }
    }
}
