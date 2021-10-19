using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Navigation;
using System.Windows;
using WpfAppSample;

namespace WpfAppSample.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        #region プロパティ・フィールド
        /// <summary>ナビボタン1タイトル</summary>
        public ReactiveProperty<string> naviButton1Content2 = new ReactiveProperty<string>();
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
        public ReactiveProperty<string> naviButton2Content2 = new ReactiveProperty<string>();
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

            naviButton1Content2.Value = "ページ１";
            naviButton2Content2.Value = "ページ２";
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
              o =>
              {
                  Uri uri;
                  if ((string)o == "Page1")
                  {
                      uri = new Uri("/Views/Page1.xaml", UriKind.RelativeOrAbsolute);
                  }
                  else
                  {
                      uri = new Uri("/Views/Page2.xaml", UriKind.RelativeOrAbsolute);
                  }
                  App.RootFrame.Source = uri;
              }));

            
        }
        #endregion
    }
}
