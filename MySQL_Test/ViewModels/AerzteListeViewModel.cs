using Caliburn.Micro;
using MySQL_Test.Events;
using MySQL_Test.Interfaces;
using MySQL_Test_EF6;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;

namespace MySQL_Test.ViewModels
{

    [Export(typeof(IAerzteListeViewModel))]
    public class AerzteListeViewModel : Screen, IAerzteListeViewModel, IHandle<Events.EventMessage>
    {
        GuesterModel db;
        private bool isDirty;
        private readonly IEventAggregator _events;
        private ObservableCollection<arzt> _AerzteListe;
        public ObservableCollection<arzt> AerzteListe
        {
            get { return _AerzteListe; }
            set
            {
                if (value != _AerzteListe)
                {
                    _AerzteListe = value;
                    NotifyOfPropertyChange(() => AerzteListe);
                    isDirty = true;
                }
            }
        }



        [ImportingConstructor]
        public AerzteListeViewModel(IEventAggregator Events)
        {
            this._events = Events;
            db = new GuesterModel();
            AerzteListe = new ObservableCollection<arzt>(db.arzts);

            //Display = "Kunden";
            //Name = "Init";
        }

        public AerzteListeViewModel()
        {

        }

        public void BtnSave()
        {
            db.SaveChanges();
        }

        public void Handle(EventMessage message)
        {
            throw new NotImplementedException();
        }
    }
}