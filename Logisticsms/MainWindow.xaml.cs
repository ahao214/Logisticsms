using Logisticsms.View;
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
