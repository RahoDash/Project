/**
 * Author       : SILKA Besmir
 * Date         : 14.11.2017
 * Program      : Observers/Subject
 * Descripion   : Console exercie for practicing Observers/subject mecanism.
 *                (manual method without Interface nor event handler)
 **/
using System;

namespace ObserversSubject
{
    public class Observer : Object
    {
        //Const
        const int DEFAULT_ID = 1;

        //Fields
        private int _id;

        //Properties
        public int Id { get => _id; set => _id = value; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Observer() :this (DEFAULT_ID){}

        /// <summary>
        /// Constructor with and Id
        /// </summary>
        /// <param name="id">A int as Id</param>
        public Observer(int id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Show a message when the observer is updated
        /// </summary>
        public virtual void UpdateObserver()
        {
            Console.WriteLine("Observer "+Id.ToString()+" has received a notification");
        }
    }
}
