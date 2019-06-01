using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace CurrencyExchangeReceiver.ViewModels
{
    public class ReceiverFormViewModel : INotifyPropertyChanged
    {
        private const string TimeUpdater = "timeUpdate";
        private const int CountsUpdater = 30;

        private readonly CurrencyExchangeReceiver currencyExchangeReceiver;
        private List<long> timeUpdate;

        public event PropertyChangedEventHandler PropertyChanged;

        public List<string> UpdateTimes => timeUpdate.ConvertAll( ut => $"{ut.ToString()} ms" );
        public string AvgUpdateTime => Math.Round( timeUpdate.DefaultIfEmpty( 0 ).Average( ut => ut ), 4 ).ToString();

        public ReceiverFormViewModel()
        {
            currencyExchangeReceiver = new CurrencyExchangeReceiver();
            timeUpdate = new List<long>();
            PropertyChanged += MainFormViewModel_PropertyChanged;
        }

        public void SaveCurrencyInfos( string currencyNamesPath, string updatePath )
        {
            timeUpdate.Clear();
            for ( int i = 0; i < CountsUpdater; i++ )
            {
                Stopwatch watch = Stopwatch.StartNew();
                currencyExchangeReceiver.Update( currencyNamesPath, updatePath );
                watch.Stop();
                long updateTime = watch.ElapsedMilliseconds;
                bool isCorrectTime = timeUpdate.TrueForAll( ut => updateTime < ut * 2 && updateTime > ut / 2 ) || !timeUpdate.Any();
                if ( isCorrectTime )
                {
                    timeUpdate.Add( watch.ElapsedMilliseconds );
                }
            }
            OnPropertyChanged( TimeUpdater );
        }

        public async Task SaveCurrencyInfosAsync( string currencyNamesPath, string updatePath )
        {
            timeUpdate.Clear();
            for ( int i = 0; i < CountsUpdater; i++ )
            {
                Stopwatch watch = Stopwatch.StartNew();
                await currencyExchangeReceiver.UpdateAsync( currencyNamesPath, updatePath );
                watch.Stop();
                long updateTime = watch.ElapsedMilliseconds;
                bool isCorrectTime = timeUpdate.TrueForAll( ut => updateTime < ut * 2 && updateTime > ut / 2 ) || !timeUpdate.Any();
                if ( isCorrectTime )
                {
                    timeUpdate.Add( watch.ElapsedMilliseconds );
                }
            }
            OnPropertyChanged( TimeUpdater );
        }

        private void MainFormViewModel_PropertyChanged( object sender, PropertyChangedEventArgs e )
        {
            if ( e.PropertyName == TimeUpdater )
            {
                OnPropertyChanged( "UpdateTimes" );
                OnPropertyChanged( "AvgUpdateTime" );
            }
        }

        private void OnPropertyChanged( [CallerMemberName] string property = "" )
        {
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( property ) );
        }
    }
}
