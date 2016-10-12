using Caliburn.Micro;
using MySQL_Test.Events;
using MySQL_Test.Interfaces;
using System;
using System.ComponentModel.Composition;

namespace MySQL_Test.ViewModels
{
    [Export(typeof(IShellViewModel))]
    public class ShellViewModel : Conductor<Object>, IShellViewModel, IHandle<Events.EventMessage>
    {

        private readonly IEventAggregator _events;
        //KundenViewModel kdViewModel;
        //TermineViewModel tViewModel;
        //TabsViewModel tabsViewModel;

        //TestViewModel testVM;
        private readonly IAerzteListeViewModel AerzteListeVModel;
        private IPatientenViewModel PatientenVModel;



        //[ImportingConstructor]
        //public ShellViewModel(TermineViewModel TermineVM, KundenViewModel kdViewModel, TestViewModel tvm, TabsViewModel _tabsViewModel, IEventAggregator Events)
        //{
        //    _events = Events;
        //    testVM = tvm;
        //    tViewModel = TermineVM;
        //    tabsViewModel = _tabsViewModel;
        //    this.kdViewModel = kdViewModel;
        //    ActivateItem(kdViewModel);
        //    Events.Subscribe(this);

        //}

        [ImportingConstructor]
        public ShellViewModel(IAerzteListeViewModel aerzteListeVm, IPatientenViewModel PatientenVM, IEventAggregator events)
        {
            _events = events;
            AerzteListeVModel = aerzteListeVm;
            PatientenVModel = PatientenVM;
            ActivateItem(PatientenVModel);
            events.Subscribe(this);

        }

        public ShellViewModel()
        {

        }


        public void Aerzte()
        {
            ActivateItem(AerzteListeVModel);
        }

        public void Patienten()
        {
            ActivateItem(PatientenVModel);
        }

        //public void Kunden()
        //{
        //    ActivateItem(kdViewModel);
        //}
        //public void Termine()
        //{
        //    ActivateItem(tViewModel);
        //}
        //public void Tabs()
        //{
        //    ActivateItem(tabsViewModel);
        //}

        public void Handle(EventMessage message)
        {
            throw new NotImplementedException();
        }
    }
}