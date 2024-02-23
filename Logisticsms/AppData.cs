using GalaSoft.MvvmLight;
using Logisticsms.DAL;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Logisticsms
{
    /// <summary>
    /// 全局类
    /// </summary>
    public class AppData : ObservableObject
    {
        public AppData()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    Thread.Sleep(1000);
                    SystemTime = DateTime.Now;
                }
            });
        }


        public static AppData Instance { get; set; } = new Lazy<AppData>().Value;

        /// <summary>
        /// 当前用户
        /// </summary>
        public Member CurrentUser { get; set; } = null;
        /// <summary>
        /// 主窗体
        /// </summary>
        public MainWindow MainWindow { get; set; } = null;

        private DateTime systemTime = DateTime.Now;
        public DateTime SystemTime
        {
            get { return systemTime; }
            set { systemTime = value; RaisePropertyChanged(); }
        }

        public void ShowMarker()
        {
            if (MainWindow == null)
                return;
            MainWindow.marker.Visibility = System.Windows.Visibility.Visible;
        }

        public void HideMarker()
        {
            if (MainWindow == null)
                return;
            MainWindow.marker.Visibility = System.Windows.Visibility.Collapsed;
        }
    }
}
