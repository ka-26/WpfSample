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
using System.Collections.ObjectModel;

namespace WpfAppSample.ViewModels
{
    class MainWindowViewModel
    {
        #region プロパティ・フィールド
        /// <summary>ナビボタン1タイトル</summary>
        public BindingProperty<string> naviButton1Content { get; set; } = new BindingProperty<string>();

        /// <summary>ナビボタン2タイトル</summary>
        public BindingProperty<string> naviButton2Content { get; set; } = new BindingProperty<string>();

        public ObservableCollection<dummyClass> listList { get; set; } = new ObservableCollection<dummyClass>();
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ1
        /// </summary>
        public MainWindowViewModel()
        {
            naviButton1Content.Value = "ページ１";
            naviButton2Content.Value = "ページ２";

            listList.Add(new dummyClass { value = new BindingProperty<string> { Value = "111" } });
            listList.Add(new dummyClass { value = new BindingProperty<string> { Value = "222" } });
            listList.Add(new dummyClass { value = new BindingProperty<string> { Value = "333" } });
            listList.Add(new dummyClass { value = new BindingProperty<string> { Value = "444" } });
            listList.Add(new dummyClass { value = new BindingProperty<string> { Value = "555" } });

            Task.Run(() =>
            {
                while (true)
                {
                    System.Threading.Thread.Sleep(1000);
                    int.TryParse(listList[4].value.Value, out var a);
                    listList[4].value.Value = (a + 1).ToString();
                }
            });
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
                      int.TryParse(listList[4].value.Value, out var a);
                      listList[4].value.Value = (a + 1).ToString();
                  }
                  App.RootFrame.Source = uri;
              }));


        }
        #endregion

        public class dummyClass{

            public BindingProperty<string> value { get; set; }
        }

    }
}
