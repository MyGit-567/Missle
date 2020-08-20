using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;

namespace Missile
{
    class Misslelist
    {
        Dictionary<string, List<Misslebase>> allMissles;


        public void Addtolist(Misslebase nameofmissle)
        {
            if (allMissles.ContainsKey(nameofmissle.name))
            {
                allMissles[nameofmissle.name].Add(nameofmissle);
            }
            else
            {
                List<Misslebase> onemissle = new List<Misslebase>();
                onemissle.Add(nameofmissle);

                allMissles.Add(nameofmissle.name, onemissle);
            }


        }

        public void FireMissles(string name, int number)
        {
            List<Misslebase> myMissleList = allMissles[name];
            int counter = 0;
            if (name == "TotalWar")
            {
                foreach (KeyValuePair<string, List<Misslebase>> entry in allMissles)
                {
                    foreach (Misslebase missle in entry.Value)
                    {
                        bool check2 = missle.Misslelaunch();
                        if (check2)
                        {
                            ToLaunch(check2);
                            counter += 1;
                            myMissleList.Remove(missle);
                        }

                    }


                }

            }
            else
            {
                for (int i = 0; i < number; i++)
                {
                    bool check = myMissleList[i].Misslelaunch();
                    if (check)
                    {
                        ToLaunch(check);
                        counter += 1;
                        myMissleList.Remove(myMissleList[i]);
                    }

                }
            }
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
