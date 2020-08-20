using System;
using System.Collections.Generic;
using System.Text;

namespace Missile
{
    public abstract class Misslebase
    {
        public string name;
        public Statistic _statistic;
        public Misslebase(Statistic statistic) //Constructor
        {
            _statistic = statistic;
        }


        public bool Misslelaunch() //check the launch percent 
        {
            bool percentlaunch = _statistic.calculateRate();                     
                return percentlaunch; 
        }

    }
}
