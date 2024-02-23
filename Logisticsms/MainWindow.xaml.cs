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
        private MainViewModel vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = DataContext as MainViewModel;
            //MDFiveHelper.GetMDFive("1");
            AppData.Instance.MainWindow = this;
            this.marker.Visibility = Visibility.Collapsed;
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (!(sender is RadioButton button))
                return;
            if (string.IsNullOrEmpty(button.Name))
                return;

            if (!(container.Content is null))
            {
                vm?.Save(container.Content); // 保存当前页面的数据
            }

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


    }
}
