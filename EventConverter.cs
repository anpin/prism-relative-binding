using System.Globalization;

namespace prism_relative_binding;

public class EventConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (parameter is Picker p)
        {
            return new CmdArgs(p);
        }

        throw new ArgumentOutOfRangeException(nameof(parameter));

    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}