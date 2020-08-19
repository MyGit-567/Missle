using System;
using System.Collections.Generic;
using System.Text;

namespace Missile
{
    class MissleLaunch : Fire
    {
        int count = 0;
        public void Misslelaunch(bool success)//add the type of the missle?
        {
            if (success == true)
               Console.WriteLine("Launch");
            count += 1;
            Console.WriteLine("Launched missiles:" + count );
            Console.WriteLine()
        }
    }
}
