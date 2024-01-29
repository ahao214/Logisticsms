using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Logisticsms.DAL;
using Logisticsms.DAL.ProviderFile;
using System;
using System.Collections.ObjectModel;
using System.Windows;

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

        /// <summary>
        /// 加载窗体
        /// </summary>
        public RelayCommand LoadedCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    var list = _customerProvider.GetAll();
                    CustomerList.Clear();
                    foreach (var item in list)
                    {
                        CustomerList.Add(item);
                    }
                });
            }
        }

        /// <summary>
        /// 新增客户
        /// </summary>
        public RelayCommand InsertCustomerCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    Customer customer = new Customer()
                    {
                        Name = "新客户",
                        InsertDate = DateTime.Now
                    };
                    var count = _customerProvider.Insert(customer);
                    if (count > 0)
                    {
                        CustomerList.Add(customer);
                    }
                    else
                    {
                        MessageBox.Show("插入失败");
                    }
                });
            }

        }


        #endregion
    }
}
