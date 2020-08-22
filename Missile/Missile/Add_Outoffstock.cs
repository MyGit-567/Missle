using Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace Missile
{
    class Add_Outoffstock : IPrint
    {
        Misslelist misslelist3;

        public Add_Outoffstock(Misslelist misslelist3)
        {
            this.misslelist3 = misslelist3;
        }

        public void Print()
        {
            Statistic statistic3 = new Statistic(100);
            Misslebase newmissle3 = new Torpedo(statistic3);
            misslelist3.printstock;

        }

        public string Description()
        {
            throw new NotImplementedException();
        }

       
    }
}
