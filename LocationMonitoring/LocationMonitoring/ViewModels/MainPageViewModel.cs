using GalaSoft.MvvmLight;
using LocationMonitoring.BL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;
using Xamarin.Forms;

namespace LocationMonitoring.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private CancellationTokenSource cts;

        public MainPageViewModel()
        {

        }

        public Command StartStrackingCommand => new Command(this.StartTracking);

        public Command StopStrackingCommand => new Command(this.StopTracking);

        public ObservableCollection<string> LocationFeed { get; } = new ObservableCollection<string>();


        private void StartTracking()
        {
            this.cts = new CancellationTokenSource();
            DataCollection.CollectData(this.LocationFeed, cts.Token);
        }

        private void StopTracking()
        {
            try
            {
                this.cts.Cancel();
            }
            catch
            {
                // Already canceled.
            }
        }
    }
}
