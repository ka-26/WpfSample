using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppSample.Views
{
    /// <summary>
    /// Page2.xaml の相互作用ロジック
    /// </summary>
    public partial class Page2 : Page
    {
        public int ROW_NUM = 10;
        public int COL_NUM = 10;

        public Page2()
        {
            InitializeComponent();

            DataTemplate dt = this.FindResource("StageJoutai") as DataTemplate;

            GRID_DATA.Columns.Add(new DataGridTemplateColumn() { CellTemplate = dt });
            GRID_DATA.Columns.Add(new DataGridTemplateColumn() { CellTemplate = dt });
            GRID_DATA.Columns.Add(new DataGridTemplateColumn() { CellTemplate = dt });
        }

    }
}
