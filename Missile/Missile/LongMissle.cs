using System;
using System.Collections.Generic;
using System.Text;

namespace Missile
{
    class LongMissle : Misslebase
    {
        public LongMissle(Statistic statistic) : base(statistic) //Constructor
        {
            maxdistance = 1500;
        }
    }
}
