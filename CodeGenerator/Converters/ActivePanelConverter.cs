using Avalonia.Automation.Provider;
using Avalonia.Data.Converters;
using CodeGenerator.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Converters
{
    public class ActivePanelConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is ActivePanel activePanel)
            {
                if (parameter is string param)
                {
                    if (Enum.TryParse<ActivePanel>(param, out var panel))
                    {
                        return activePanel == panel;
                    }
                }
            }

            return false;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
