using Logisticsms.View;
using Logisticsms.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace Logisticsms
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //MDFiveHelper.GetMDFive("1");
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (!(sender is RadioButton button))
                return;
            if (string.IsNullOrEmpty(button.Name))
                return;

            Save(container.Content); // 保存当前页面的数据


            switch (button.Name)
            {
                case "AirTransportView":
                    container.Content = new AirTransportView();
                    break;
                case "CustomerView":
                    container.Content = new CustomerView();
                    break;
                default:
                    break;
            }
        }



        private void Save(object content)
        {
            var name = container.GetType().Name;
            switch (name)
            {
                case "AirTransportView":
                    if(!(content is AirTransportView airTransportView))
                    {
                        return;
                    }
                    if(!(airTransportView .DataContext  is AirTransportViewModel airTransportViewModel))
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
                    if (!(customerView.DataContext is CustomerViewModel customerViewModel ))
                    {
                        return;
                    }
                    customerViewModel.Save();
                    break;
                default:
                    break;
            }
        }

    }
}
