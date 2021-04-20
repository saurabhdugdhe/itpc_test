using DisplayData.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DisplayData.Services;
using DisplayData.Command;
using System.Windows;
using System.Threading;

namespace DisplayData.ViewModel
{
    class MainWindowViewModel
    {
        private RelayCommand _getDataCommand;
        System.Windows.Visibility DataGridVisibility;

        public ObservableCollection<CovidMetrics> covidMetrics { get; set; }
        public ICommand GetDataCommand => _getDataCommand;
        public IWindowManager WindowManager { get; set; }
        public MainWindowViewModel()
        {
            covidMetrics = new ObservableCollection<CovidMetrics>();
            _getDataCommand = new RelayCommand(OnDisplayDataClick);
            DataGridVisibility = System.Windows.Visibility.Hidden;
        }

        private async void OnDisplayDataClick()
        {
            try
            {
                SpinnerService spinnerService = new SpinnerService();
                await spinnerService.StartSpinner(WindowManager.GetWindow()).ConfigureAwait(false);

                await Task.Delay(60000);
                await spinnerService.StopSpinner();
                string csvfilename = @"Data\CovidCasesInMajorMetroCitiesIndia.csv";
                DataTable covidDataTable = CSVReaderService.GetDataTableFromCSVFile(csvfilename);
                foreach (DataRow covidRow in covidDataTable.Rows)
                {
                    CovidMetrics covidMetricRow = new CovidMetrics(covidRow.ItemArray[0].ToString(), int.Parse(covidRow.ItemArray[1].ToString()), int.Parse(covidRow.ItemArray[2].ToString()), int.Parse(covidRow.ItemArray[3].ToString()), int.Parse(covidRow.ItemArray[4].ToString()), covidRow.ItemArray[5].ToString());
                    covidMetrics.Add(covidMetricRow);
                }
                DataGridVisibility = System.Windows.Visibility.Visible;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
