﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dubbelknapparna
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            // första knappen
            btnSecond.Content = "Oklickad";
            btnFirst.Content = "Klickad";
        }

        private void btnSecond_Click(object sender, RoutedEventArgs e)
        {
            btnSecond.Content = "Klickad";
            btnFirst.Content = "Oklickad";
        }
       
    }
}