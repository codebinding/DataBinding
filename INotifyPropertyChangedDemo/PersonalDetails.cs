using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;

namespace INotifyPropertyChangedDemo {
    
    public class PersonalDetails : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;
        
        string _firstName = "Bob";
        string _lastName = "Smith";

        public string FirstName {
            get { return _firstName; }
            set {
                _firstName = value;
                OnPropertyChanged( "FullName" );
                OnPropertyChanged( "FirstName" );
            }
        }

        public string LastName {
            get { return _lastName; }
            set {
                _lastName = value;
                OnPropertyChanged( "FullName" );
            }
        }

        public string FullName {
            get { return string.Format( "{0} {1}", FirstName, LastName ); }
        }

        private void OnPropertyChanged( string property ) {
            if( PropertyChanged != null )
                PropertyChanged( this, new PropertyChangedEventArgs( property ) );
        }
    }
}
