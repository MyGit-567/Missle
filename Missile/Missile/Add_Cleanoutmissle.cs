using Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace Missile
{
    class Add_Cleanoutmissle : Iaction
    {
        Misslelist misslelist4;

        public Add_Cleanoutmissle(Misslelist misslelist)
        {
            this.misslelist4 = misslelist;
        }

        public void Action()
        {
            Statistic statistic4 = new Statistic(100);
            Misslebase newmissle4 = new Torpedo(statistic4);
            misslelist4.Removefromlist(3);

        }

        public string Description()
        {
            throw new NotImplementedException();
        }
    }
}
