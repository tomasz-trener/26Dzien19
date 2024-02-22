using P06Shop.Shared.MessageBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04WeatherForecastWPF.Client.MessageBox
{
    internal class WpfMessageDialogService : IMessageDialogService
    {
        public void ShowMessage(string message)
        {
            System.Windows.MessageBox.Show(message);    
        }
    }
}
