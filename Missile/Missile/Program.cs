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
            Misslelist missleList2 = new Misslelist();
            Misslelist missleList3 = new Misslelist();
            Misslelist missleList4 = new Misslelist();
            Misslelist missleList5 = new Misslelist();
            LongMissle newmissle = new LongMissle;

            Iaction addnewlaunch = new AddNewLaunch(missleList2);
            Iaction addNewMissle = new AddNewMissleAction(missleList);
            Iaction outofstock = new Add_Outoffstock(missleList3);
            Iaction cleanout = new Add_Cleanoutmissle(missleList4);
            Iaction exit = new Add_Exit(missleList5);

            var actionDictionary = new Dictionary<int, Iaction>
            {
                {1 , addNewMissle },
                {2 , addnewlaunch },
                {3 ,  outofstock },
                {4 ,  cleanout},
                {5, exit },
                
            };

            var numericMenu2 = new Numericalmenu(actionDictionary);

            

        }
    }
}
