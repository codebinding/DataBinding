using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows;
using System.Globalization;

namespace CustomValueConverterDemo {

    enum Status { Ok, Failed, Unknown };

    class InverseBooleanToVisibilityConverter : IValueConverter {

        public object Convert(
            object value, Type targetType, object parameter, CultureInfo culture ) {

                bool booleanValue = (bool)value;
                return booleanValue ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(
            object value, Type targetType, object parameter, CultureInfo culture ) {

                Visibility visibility = (Visibility)value;

                return visibility == Visibility.Visible;
        }
    }

    public class FlexibleBooleanToVisibilityConverter : IValueConverter {
        public object Convert(
                object value, Type targetType, object parameter, CultureInfo culture ) {
            bool booleanValue = (bool)value;
            return VisibilityFromParameter( parameter.ToString(), booleanValue );
        }

        public object ConvertBack(
            object value, Type targetType, object parameter, CultureInfo culture ) {
            Visibility visibility = (Visibility)value;
            Visibility trueVisibility = VisibilityFromParameter( parameter.ToString(), true );
            return visibility = trueVisibility;
        }

        private Visibility VisibilityFromParameter( string parameter, bool booleanValue ) {
            string[] visibilities = parameter.Split( '|' );
            string visibility = booleanValue ? visibilities[0] : visibilities[1];
            return (Visibility)Enum.Parse( typeof( Visibility ), visibility );
        }
    }

    public class StatusToVisibilityConverter : IValueConverter {

        public object Convert( object value, Type targetType, object parameter, CultureInfo culture ) {
            Status statusValue = (Status)value;
            return VisibilityFromParameter( parameter.ToString(), statusValue );
        }

        public object ConvertBack( object value, Type targetType, object parameter, CultureInfo culture ) {
            Visibility visibility = (Visibility)value;
            Visibility trueVisibility = VisibilityFromParameter( parameter.ToString(), Status.Ok );
            return visibility = trueVisibility;
        }

        private Visibility VisibilityFromParameter( string parameter, Status statusValue ) {
            string[] visibilities = parameter.Split( '|' );

            string visibility;
            switch( statusValue ) {
                case Status.Ok:
                    visibility = visibilities[0];
                    break;

                case Status.Failed:
                    visibility = visibilities[1];
                    break;

                default:
                    visibility = visibilities[1];
                    break;
            }
            return (Visibility)Enum.Parse( typeof( Visibility ), visibility );
        }
    }
}
