using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardMultiViews
{
    class DashboardModel : Object
    {
        private const int MIN_VALUE = 0;
        private const int MAX_VALUE = 100;

        private int _level;
        private List<Object> _observers;

        private List<Object> Observers { get => _observers; set => _observers = value; }
        public int Level { get => _level; set { _level = value; this.NotifyObservers(); } }

        public DashboardModel(int paramLevel)
        {
            this.Observers = new List<Object>();
            this.Level = paramLevel;
        }

        public void RegisterObserver(Object paramObserver)
        {
            if (paramObserver != null)
                Observers.Add(paramObserver);
        }

        public void UnregisterObserver(Object paramObserver)
        {
                Observers.Remove(paramObserver);
        }

        private void NotifyObservers()
        {
            foreach (Object o in this.Observers)
            {
                (o as DashboardController).NotifyObserver();
            }
        }

        public override string ToString()
        {
            string sentence;
            switch (Level)
            {
                case MIN_VALUE:
                    sentence = "Le minimum est atteint !";
                    break;
                case MAX_VALUE:
                    sentence = "Le maximum est atteint !";
                    break;
                default:
                    sentence = "None";
                    break;
            }


            return sentence;
        }
    }
}
