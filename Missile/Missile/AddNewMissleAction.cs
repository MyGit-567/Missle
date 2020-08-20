using Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace Missile
{
    class AddNewMissleAction : Iaction
    {
        Misslelist misslelist;

        public AddNewMissleAction(Misslelist misslelist)
        {
            this.misslelist = misslelist;
        }

        public void Action()
        {
            Statistic statistic2 = new Statistic(100);
            Misslebase newmissle = new Torpedo(statistic2);
            misslelist.Addtolist(newmissle);
            
        }

        public string Description()
        {
            throw new NotImplementedException();
        }
    }
}
