using Menu;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Missile
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Statistic statistic = new Statistic(100);
            Torpedo torpedo = new Torpedo(statistic);
            torpedo.Misslelaunch();


            //  Create a dictionary
            Misslelist missleList = new Misslelist();
            Iaction becktomenu = new Becktomenu();
            Iaction addNewMissle = new AddNewMissleAction(missleList);

            var actionDictionary = new Dictionary<int, Iaction>
            {
                {1 , addNewMissle },
                {2, becktomenu }
            };

            var numericMenu = new Numericalmenu(actionDictionary);

            var freemenu = new Freemenu(secondDictionary);
            numericMenu.Print();

        }
    }
}
