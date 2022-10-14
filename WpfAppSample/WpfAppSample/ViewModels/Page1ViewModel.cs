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
        public ObservableCollection<RowDefinition> rows { get; set; } = new ObservableCollection<RowDefinition>();

        public RowDefinition colDefinitions { get; set; } = new RowDefinition();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Page1ViewModel()
        {
            rows.Add(new RowDefinition { columns = new ObservableCollection<CellDefinition>() });
            rows.Add(new RowDefinition { columns = new ObservableCollection<CellDefinition>() });
            rows.Add(new RowDefinition { columns = new ObservableCollection<CellDefinition>() });
            rows.Add(new RowDefinition { columns = new ObservableCollection<CellDefinition>() });
            rows.Add(new RowDefinition { columns = new ObservableCollection<CellDefinition>() });

            rows[0].columns.Add(new CellDefinition { text = new BindingProperty<string> { Value = "充放電棚1\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" }, backColor = new BindingProperty<Brush> { Value = Brushes.Red } });
            rows[0].columns.Add(new CellDefinition { text = new BindingProperty<string> { Value = "充放電棚2\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" }, backColor = new BindingProperty<Brush> { Value = Brushes.Yellow } });
            rows[0].columns.Add(new CellDefinition { text = new BindingProperty<string> { Value = "充放電棚3\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" }, backColor = new BindingProperty<Brush> { Value = Brushes.Blue } });

            rows[1].columns.Add(new CellDefinition { text = new BindingProperty<string> { Value = "180A棚1\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" }, backColor = new BindingProperty<Brush> { Value = Brushes.Magenta } });
            rows[1].columns.Add(new CellDefinition { text = new BindingProperty<string> { Value = "180A棚2\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" }, backColor = new BindingProperty<Brush> { Value = Brushes.LightYellow } });
            rows[1].columns.Add(new CellDefinition { text = new BindingProperty<string> { Value = "180A棚3\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" }, backColor = new BindingProperty<Brush> { Value = Brushes.LightBlue } });

            rows[2].columns.Add(new CellDefinition { text = new BindingProperty<string> { Value = "120A棚1\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" }, backColor = new BindingProperty<Brush> { Value = Brushes.White } });
            rows[2].columns.Add(new CellDefinition { text = new BindingProperty<string> { Value = "120A棚2\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" }, backColor = new BindingProperty<Brush> { Value = Brushes.Green } });
            rows[2].columns.Add(new CellDefinition { text = new BindingProperty<string> { Value = "120A棚3\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" }, backColor = new BindingProperty<Brush> { Value = Brushes.Brown } });

            rows[3].columns.Add(new CellDefinition { text = new BindingProperty<string> { Value = "休止棚1\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" }, backColor = new BindingProperty<Brush> { Value = Brushes.Gray } });
            rows[3].columns.Add(new CellDefinition { text = new BindingProperty<string> { Value = "休止棚2\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" }, backColor = new BindingProperty<Brush> { Value = Brushes.LightCyan } });
            rows[3].columns.Add(new CellDefinition { text = new BindingProperty<string> { Value = "休止棚3\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" }, backColor = new BindingProperty<Brush> { Value = Brushes.Transparent } });

            rows[4].columns.Add(new CellDefinition { text = new BindingProperty<string> { Value = "DCIR棚1\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" }, backColor = new BindingProperty<Brush> { Value = Brushes.Red } });
            rows[4].columns.Add(new CellDefinition { text = new BindingProperty<string> { Value = "DCIR棚2\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" }, backColor = new BindingProperty<Brush> { Value = Brushes.Yellow } });
            rows[4].columns.Add(new CellDefinition { text = new BindingProperty<string> { Value = "DCIR棚3\n---(4.3℃)\n待受(待機中)\nStep1/0(00:00:00)" }, backColor = new BindingProperty<Brush> { Value = Brushes.Blue } });
        }
    }

    /// <summary>
    /// datagrid 列定義
    /// </summary>
    public class RowDefinition
    {
        public BindingProperty<double> height;
        public ObservableCollection<CellDefinition> columns = new ObservableCollection<CellDefinition>();
    }

    public class CellDefinition
    {
        public BindingProperty<string> text { get; set; } = new BindingProperty<string>();
        public BindingProperty<Brush> backColor { get; set; } = new BindingProperty<Brush>();
        public BindingProperty<double> left { get; set; } = new BindingProperty<double>();
        public BindingProperty<double> top { get; set; } = new BindingProperty<double>();
        public BindingProperty<double> height { get; set; } = new BindingProperty<double>();
        public BindingProperty<double> width { get; set; } = new BindingProperty<double>();
    }
}
