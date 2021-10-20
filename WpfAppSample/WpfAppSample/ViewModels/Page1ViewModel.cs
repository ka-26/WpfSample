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
        public ObservableCollection<CellDefinition> ColumnDefinition { get; set; } = new ObservableCollection<CellDefinition>();

        public ColDefinitions colDefinitions { get; set; } = new ColDefinitions();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Page1ViewModel()
        {
            ColumnDefinition.Add(new CellDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.Red  }, text = new BindingProperty<string> { Value = "充放電棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });
            ColumnDefinition.Add(new CellDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.Blue }, text = new BindingProperty<string> { Value = "180A棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });
            ColumnDefinition.Add(new CellDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.Green }, text = new BindingProperty<string> { Value = "120A棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });
            ColumnDefinition.Add(new CellDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.White }, text = new BindingProperty<string> { Value = "休止棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });
            ColumnDefinition.Add(new CellDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.Gray }, text = new BindingProperty<string> { Value = "DCIR棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });

            colDefinitions.ColumnDefinition01.Add(new CellDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.Red }, text = new BindingProperty<string> { Value = "充放電棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });
            colDefinitions.ColumnDefinition01.Add(new CellDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.Blue }, text = new BindingProperty<string> { Value = "180A棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });
            colDefinitions.ColumnDefinition01.Add(new CellDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.Green }, text = new BindingProperty<string> { Value = "120A棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });
            colDefinitions.ColumnDefinition01.Add(new CellDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.White }, text = new BindingProperty<string> { Value = "休止棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });
            colDefinitions.ColumnDefinition01.Add(new CellDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.Gray }, text = new BindingProperty<string> { Value = "DCIR棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });

            colDefinitions.ColumnDefinition02.Add(new CellDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.Red }, text = new BindingProperty<string> { Value = "充放電棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });
            colDefinitions.ColumnDefinition02.Add(new CellDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.Blue }, text = new BindingProperty<string> { Value = "180A棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });
            colDefinitions.ColumnDefinition02.Add(new CellDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.Green }, text = new BindingProperty<string> { Value = "120A棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });
            colDefinitions.ColumnDefinition02.Add(new CellDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.White }, text = new BindingProperty<string> { Value = "休止棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });
            colDefinitions.ColumnDefinition02.Add(new CellDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.Gray }, text = new BindingProperty<string> { Value = "DCIR棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });

            colDefinitions.ColumnDefinition03.Add(new CellDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.Red }, text = new BindingProperty<string> { Value = "充放電棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });
            colDefinitions.ColumnDefinition03.Add(new CellDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.Blue }, text = new BindingProperty<string> { Value = "180A棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });
            colDefinitions.ColumnDefinition03.Add(new CellDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.Green }, text = new BindingProperty<string> { Value = "120A棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });
            colDefinitions.ColumnDefinition03.Add(new CellDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.White }, text = new BindingProperty<string> { Value = "休止棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });
            colDefinitions.ColumnDefinition03.Add(new CellDefinition { backColor = new BindingProperty<Brush> { Value = Brushes.Gray }, text = new BindingProperty<string> { Value = "DCIR棚\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" } });



        }
    }

    /// <summary>
    /// datagrid 列定義
    /// </summary>
    public class CellDefinition
    {
        public BindingProperty<string> text { get; set; } = new BindingProperty<string>();
        public BindingProperty<Brush> backColor { get; set; } = new BindingProperty<Brush>();
    }

    public class ColDefinitions
    {
        public ObservableCollection<CellDefinition> ColumnDefinition01 { get; set; } = new ObservableCollection<CellDefinition>();
        public ObservableCollection<CellDefinition> ColumnDefinition02 { get; set; } = new ObservableCollection<CellDefinition>();
        public ObservableCollection<CellDefinition> ColumnDefinition03 { get; set; } = new ObservableCollection<CellDefinition>();
    }
}
