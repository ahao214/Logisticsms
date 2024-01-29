using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Logisticsms.DAL;
using Logisticsms.View;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

        #region Commands

        public RelayCommand <MainWindow > ClosingCommand
        {
            get
            {
                return new RelayCommand<MainWindow>((window) =>
                {
                    Save(window.container.Content); // 保存当前页面的数据
                });
            }
        }

        #endregion

        #region Methods

        public void Save(object content)
        {
            var name = content.GetType().Name;
            switch (name)
            {
                case "AirTransportView":
                    if (!(content is AirTransportView airTransportView))
                    {
                        return;
                    }
                    if (!(airTransportView.DataContext is AirTransportViewModel airTransportViewModel))
                    {
                        return;
                    }
                    airTransportViewModel.Save();

                    break;
                case "CustomerView":
                    if (!(content is CustomerView customerView))
                    {
                        return;
                    }
                    if (!(customerView.DataContext is CustomerViewModel customerViewModel))
                    {
                        return;
                    }
                    customerViewModel.Save();
                    break;
                default:
                    break;
            }
        }

        #endregion

    }
}