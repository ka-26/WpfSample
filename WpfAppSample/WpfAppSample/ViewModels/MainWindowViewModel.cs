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
    class MainWindowViewModel
    {
        #region プロパティ・フィールド
        /// <summary>ナビボタン1タイトル</summary>
        public ReactiveProperty<string> naviButton1Content { get; set; } = new ReactiveProperty<string>();

        /// <summary>ナビボタン2タイトル</summary>
        public ReactiveProperty<string> naviButton2Content { get; set; } = new ReactiveProperty<string>();

        public ReactiveCollection<dummyClass> listList { get; set; } = new ReactiveCollection<dummyClass>();
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ1
        /// </summary>
        public MainWindowViewModel()
        {
            naviButton1Content.Value = "ページ１";
            naviButton2Content.Value = "ページ２";

            listList.Add(new dummyClass { value = "111" });
            listList.Add(new dummyClass { value = "222" });
            listList.Add(new dummyClass { value = "333" });
            listList.Add(new dummyClass { value = "444" });
            listList.Add(new dummyClass { value = "555" });
        }

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

        public class dummyClass{

            public string value { get; set; }
        }

    }
}
