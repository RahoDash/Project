/**
 * Author       : SILKA Besmir
 * Date         : 14.11.2017
 * Program      : Observers/Subject
 * Descripion   : Console exercie for practicing Observers/subject mecanism.
 *                (manual method without Interface nor event handler)
 **/
using System;
using System.Collections.Generic;

namespace ObserversSubject
{
    class Subject : Object
    {
        //Fields
        private double _rate;
        private List<Object> _observers;

        //Properties
        public double Rate {
            get => _rate;
            set {
                if (value != _rate)
                {
                    this.UpdateObservers();
                }
                _rate = value;
            }
        } 
        private List<object> Observers { get => _observers; set => _observers = value; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Subject()
        {
            this.Rate = new double();
            this.Observers = new List<object>();
            this.UpdateObservers();
        }

        /// <summary>
        /// Register an observer
        /// </summary>
        /// <param name="paramObserver">Observer to add</param>
        public void RegisterObserver(Object paramObserver)
        {
            this.Observers.Add(paramObserver);
        }

        /// <summary>
        /// Remove an observer
        /// </summary>
        /// <param name="paramObserver">Observer to remove</param>
        public void UnregisterObserver(Object paramObserver)
        {
            this.Observers.Remove(paramObserver);
        }

        /// <summary>
        /// Update the observer
        /// </summary>
        private void UpdateObservers()
        {
            foreach (Observer observer in this.Observers)
            {
                observer.UpdateObserver();
            }
        }
    }
}
