using System;
using System.Collections.Generic;
using System.Text;

namespace Missile
{
    public abstract class Misslebase
    {
        string name;
        public Statistic statistic;
        public Misslebase(int sucessRate) //Constructor
        {
            statistic = new Statistic(sucessRate);
        }

        
        public bool Misslelaunch() //check the launch percent 
        {
            bool percentlaunch = statistic.calculateRate();                     
                return percentlaunch; 
        }

    }
}
