using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfAppSample
{
    public class ReactiveProperty<T> : INotifyPropertyChanged
    {
        #region プロパティ・フィールド
        /// <summary>ナビボタン1タイトル</summary>
        T _Value;
        public T Value
        {
            get => _Value;
            set
            {
                _Value = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        #region INotifyPropertyChangedの実装
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
          => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion
    }
}
