using Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace Missile
{
    class AddNewLaunch : Iaction
    {
        Misslelist misslelist2;

        public AddNewLaunch(Misslelist misslelist2)
        {
            this.misslelist2 = misslelist2;
        }
        public void Action()
        {
            Statistic statistic2 = new Statistic(100);
            Misslebase newmissle2 = new Torpedo(statistic2);
            misslelist2.ToLaunch(true);

        }

        public string Description()
        {
            throw new NotImplementedException();
        }
    }
}
