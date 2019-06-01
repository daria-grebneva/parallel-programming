using System;
using System.Windows.Forms;
using CurrencyExchangeReceiver.ViewModels;

namespace CurrencyExchangeReceiver
{
    public partial class ReceiverForm : Form
    {
        private readonly ReceiverFormViewModel _viewModel;

        public ReceiverForm( ReceiverFormViewModel mainFormViewModel )
        {
            InitializeComponent();
            _viewModel = mainFormViewModel;
            timesList.DataBindings.Add( "DataSource", _viewModel, "UpdateTimes", true, DataSourceUpdateMode.OnPropertyChanged );
            label2.DataBindings.Add( "Text", _viewModel, "AvgUpdateTime", true, DataSourceUpdateMode.OnPropertyChanged );
            asyncRadioButton.Checked = true;
        }

        private void _asyncUsingRadioButton_CheckedChanged( object sender, System.EventArgs e )
        {
            processButton.Click -= _saveCurrenciesButton_ClickAsync;
            processButton.Click -= _saveCurrenciesButton_Click;
            processButton.Click += new EventHandler( _saveCurrenciesButton_ClickAsync );
        }

        private void _syncUsingRadioButton_CheckedChanged( object sender, EventArgs e )
        {
            processButton.Click -= _saveCurrenciesButton_ClickAsync;
            processButton.Click -= _saveCurrenciesButton_Click;
            processButton.Click += new EventHandler( _saveCurrenciesButton_Click );
        }

        private async void _saveCurrenciesButton_ClickAsync( object sender, EventArgs e )
        {
            processButton.Enabled = false;
            await _viewModel.SaveCurrencyInfosAsync( inputFileBox.Text, outputFileBox.Text );
            processButton.Enabled = true;
        }

        private void _saveCurrenciesButton_Click( object sender, EventArgs e )
        {
            processButton.Enabled = false;
            _viewModel.SaveCurrencyInfos( inputFileBox.Text, outputFileBox.Text );
            processButton.Enabled = true;
        }

        private void _saveCurrenciesButton_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
