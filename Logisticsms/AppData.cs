using Logisticsms.DAL;
using System;

namespace Logisticsms
{
    /// <summary>
    /// 全局类
    /// </summary>
    public class AppData
    {
        public static AppData Instance { get; set; } = new Lazy<AppData>().Value;

        /// <summary>
        /// 当前用户
        /// </summary>
        public Member CurrentUser { get; set; } = null;
        /// <summary>
        /// 主窗体
        /// </summary>
        public MainWindow MainWindow { get; set; } = null;

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
