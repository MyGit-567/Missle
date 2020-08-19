using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Missile
{
    class Misslelist
    {
        List<string> allthemissle = new List<string> ();
        public void Addtolist(string nameofmissle)
        {
            allthemissle.Add(nameofmissle);
            int countoflist = allthemissle.Count;
            Console.WriteLine(allthemissle + "misseles in the list");
        }

      
        /*
        Queue _missleQueue;

        public Misslequeue(Queue missleQueue)  //constructor
        {
            _missleQueue = missleQueue;
        }

        public void Add(Fire missle) //add to the queue
        {
            
            _missleQueue.Enqueue(missle);
        }

        public void Remove(Fire missle) //add to the queue
        {

            _missleQueue.Dequeue(missle);
        }*/
    }
}
