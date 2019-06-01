using System;
using System.Windows.Forms;
using CurrencyExchangeReceiver.ViewModels;

namespace CurrencyExchangeReceiver
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new ReceiverForm( new ReceiverFormViewModel() ) );
        }
    }
}
