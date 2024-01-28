using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Logisticsms.DAL;
using Logisticsms.DAL.ProviderFile;
using System.Collections.ObjectModel;

namespace Logisticsms.ViewModel
{
    public class CustomerViewModel : ViewModelBase
    {
        private CustomerProvider _customerProvider = new CustomerProvider();

        #region properties

        private ObservableCollection<Customer> customerList = new ObservableCollection<Customer>();
        public ObservableCollection<Customer> CustomerList
        {
            get { return customerList; }
            set { customerList = value; RaisePropertyChanged(); }
        }

        #endregion

        public AppData AppData { get; set; } = AppData.Instance;



        #region Command 

        public RelayCommand LoadedCommand
        {
            get
            {
                return new RelayCommand(() =>
                {

                });
            }
        }

        #endregion
    }
}
