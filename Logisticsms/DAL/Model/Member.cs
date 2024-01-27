using GalaSoft.MvvmLight;
using System.Windows.Markup;

namespace Logisticsms.DAL
{
    public partial class Member : ObservableObject
    {
        private string passwordChar = string.Empty;

        public string PasswordChar
        {
            get { return passwordChar; }
            set { passwordChar = value; RaisePropertyChanged(); }
        }

    }

}
