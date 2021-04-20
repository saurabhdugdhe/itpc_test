using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace DisplayData.Services
{
    class SpinnerService
    {
        Spinner Spinner;

        public async Task StartSpinner(Window owner)
        {
            Spinner = new Spinner();
            Spinner.Owner = owner;
            Spinner.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            Spinner.Topmost = true;
            Spinner.Width = owner.Width;
            Spinner.Height = owner.Height;
            Spinner.Show();
        }
        public async Task StopSpinner()
        {
            Spinner.Close();
        }
    }
}
