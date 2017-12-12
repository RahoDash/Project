using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardMultiViews
{
    internal class DashboardController : IDisposable
    {
        private DashboardModel _model;
        private DashboardView _view;

        public DashboardView View { get => _view; set => _view = value; }
        public DashboardModel Model { get => _model; set => _model = value; }

        public DashboardController(DashboardView paramView, DashboardModel paramModel)
        {
            this.View = paramView;
            this.Model = paramModel;

            //
            this.Model.RegisterObserver(this);
        }


        public int GetLevel()
        {
            return this.Model.Level;
        }

        public void SetLevel(int paramLevel)
        {
            this.Model.Level = paramLevel;
        }

        public string GetStatus()
        {
            return this.Model.ToString();
        }

        public void NotifyObserver()
        {
            this.View.UpdateView();
        }

        public void Dispose()
        {
            this.Model.UnregisterObserver(this);
        }
    }
}
