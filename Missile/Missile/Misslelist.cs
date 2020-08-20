using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace Missile
{
    class Misslelist
    {
        List<Misslebase> allthemissle = new List<Misslebase> ();
        public void Addtolist(Misslebase nameofmissle)
        {
            allthemissle.Add(nameofmissle);
            int countoflist = allthemissle.Count;
            Console.WriteLine(countoflist + "misseles in the list");
            Console.WriteLine("List of missles:" + allthemissle);
        }

        public void Removefromlist(Misslebase nameofmissle)
        {
            if(הקלט מספר)
            {
                allthemissle.Remove(nameofmissle);
            }
            allthemissle.Remove(nameofmissle);
            int countoflist = allthemissle.Count;
            Console.WriteLine(countoflist + "misseles in the list");
            Console.WriteLine("List of missles:" + allthemissle);
        }

        public void ToLaunch(bool percentlaunch)
        {
            int counter = 0;
            if (percentlaunch)
            {
                Console.WriteLine("Launch");
                counter += 1;
                Console.WriteLine(counter + "Launches");
            }
            else
                Console.WriteLine("The Launch failed");
        }
        
    }
}
