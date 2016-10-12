using Caliburn.Micro;
using MySQL_Test.Events;
using MySQL_Test.Interfaces;
using System;
using System.ComponentModel.Composition;

namespace MySQL_Test.ViewModels
{
    [Export(typeof(IPatientenViewModel))]
    public class PatientenViewModel : Screen, IPatientenViewModel, IHandle<Events.EventMessage>
    {
        private string _TestPatienten;
        public string TestPatienten
        {
            get { return "Dies ist ein Test"; }

            set
            {
                if (value != _TestPatienten)
                {
                    _TestPatienten = value;
                    NotifyOfPropertyChange(() => TestPatienten);
                    //  isDirty = true;
                }
            }
        }

        public void Handle(EventMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
