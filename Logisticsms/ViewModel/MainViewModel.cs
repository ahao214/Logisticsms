using GalaSoft.MvvmLight;
using Logisticsms.DAL;
using System.Windows;

namespace Logisticsms.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            
        }

        public AppData AppData { get; set; } = AppData.Instance;
        
    }
}