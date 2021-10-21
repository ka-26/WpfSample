using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using WpfAppSample.ViewModels;
using System.Collections.ObjectModel;

namespace WpfAppSample.Views.Converter
{
    public class ChangeToTextConverter : IMultiValueConverter
    {
        object IMultiValueConverter.Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            ViewModels.RowDefinition data;
            DataGridCell cell;

            try
            {
                data = (ViewModels.RowDefinition)values[0];
                cell = (DataGridCell)values[1];
            }
            catch (InvalidCastException e)
            {
                return DependencyProperty.UnsetValue;
            }

            return data.columns[cell.Column.DisplayIndex].text.Value;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
