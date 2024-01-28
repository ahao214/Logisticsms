using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Logisticsms.DAL;
using Logisticsms.DAL.Helper;
using Logisticsms.DAL.ProviderFile;
using Logisticsms.Windows;
using System.Linq;
using System.Windows;

namespace Logisticsms.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        MemberProvider memberProvider = new MemberProvider();

        #region properties

        public AppData AppData { get; set; } = AppData.Instance;

        public Member member = new Member() { Name = "admin" };
        public Member Member
        {
            get { return member; }
            set { member = value; RaisePropertyChanged("Member"); }
        }


        #endregion

        #region commands

        public RelayCommand<LoginWindow> LoginCommand
        {
            get
            {
                var command = new RelayCommand<LoginWindow>((window) =>
                {
                    Member.PasswordChar = window._passwordBox.Password;
                    if (string.IsNullOrEmpty(Member.Name) || string.IsNullOrEmpty(Member.PasswordChar))
                    {
                        return;
                    }
                    var currentUser = memberProvider.GetAll().FirstOrDefault(t => t.Name == Member.Name);
                    if (currentUser == null)
                    {
                        MessageBox.Show("无此用户");
                        return;
                    }
                    string password = MDFiveHelper.GetMDFive(Member.PasswordChar);
                    if (currentUser.Password != password)
                    {
                        MessageBox.Show("密码错误");
                        return;
                    }
                    // 记录登录用户信息
                    AppData.CurrentUser = currentUser;

                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    window.Close();

                });

                return command;
            }
        }

        #endregion





    }
}
