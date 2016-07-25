﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace INotifyPropertyChangedDemo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        PersonalDetails Person = new PersonalDetails();
        public MainWindow() {
            InitializeComponent();
            //DataContext = new PersonalDetails();
            DataContext = Person;
        }

        private void button1_Click( object sender, RoutedEventArgs e ) {
            Person.FirstName = "Ian";
        }
    }
}
