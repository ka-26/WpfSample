using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Navigation;
using System.Windows;

namespace WpfAppSample.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        #region プロパティ・フィールド
        /// <summary>ナビボタン1タイトル</summary>
        string _naviButton1Content;
        public string naviButton1Content
        {
            get => _naviButton1Content;
            set
            {
                if (_naviButton1Content != value)
                {
                    _naviButton1Content = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>ナビボタン2タイトル</summary>
        string _naviButton2Content;
        public string naviButton2Content
        {
            get => _naviButton2Content;
            set
            {
                if (_naviButton2Content != value)
                {
                    _naviButton2Content = value;
                    RaisePropertyChanged();
                }
            }
        }
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ1
        /// </summary>
        public MainWindowViewModel()
        {
            naviButton1Content = "ページ１";
            naviButton2Content = "ページ２";
        }

        #endregion

        #region INotifyPropertyChangedの実装
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
          => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion

        #region デリゲートコマンド
        private DelegateCommand _navigation;
        public DelegateCommand navigation
        {
            get => this._navigation ?? (this._navigation = new DelegateCommand(
              _ =>
              {
                  var navigationWindow = (NavigationWindow)Application.Current.MainWindow;
                  navigationWindow.Navigate(new Views.Page2());
              }));
        }
        #endregion
    }
}
