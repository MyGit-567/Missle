using Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace Missile
{
    class Add_Exit
    {
        Misslelist misslelist5;

        public Add_Exit(Misslelist misslelist)
        {
            this.misslelist5 = misslelist;
        }

        public void Action()
        {
            Statistic statistic2 = new Statistic(100);
            Misslebase newmissle5 = new Torpedo(statistic2);
            misslelist5.Exit(newmissle5);

        }

        public string Description()
        {
            throw new NotImplementedException();
        }
    }
}
}
