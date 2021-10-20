using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WpfAppSample;
using System.Windows.Media;

namespace WpfAppSample.ViewModels
{
    public class Page1ViewModel
    {
        public ObservableCollection<ColumnDefinition> listList { get; set; } = new ObservableCollection<ColumnDefinition>();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Page1ViewModel()
        {
            listList.Add(new ColumnDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.Red  }, text = new BindingProperty<string> { Value = "充放電棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });
            listList.Add(new ColumnDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.Blue }, text = new BindingProperty<string> { Value = "180A棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });
            listList.Add(new ColumnDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.Green }, text = new BindingProperty<string> { Value = "120A棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });
            listList.Add(new ColumnDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.White }, text = new BindingProperty<string> { Value = "休止棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });
            listList.Add(new ColumnDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.Gray }, text = new BindingProperty<string> { Value = "DCIR棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });
        }
    }

    /// <summary>
    /// datagrid 列定義
    /// </summary>
    public class ColumnDefinition
    {
        public BindingProperty<string> text { get; set; } = new BindingProperty<string>();
        public BindingProperty<Brush> backColor { get; set; } = new BindingProperty<Brush>();
    }
}
