﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Xceed.Wpf.Toolkit;


namespace ThreadedWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       

        Action Action;

        public MainWindow()
        {
            _busyIndicator = new BusyIndicator();
            Action = new Action();

            InitializeComponent();
        }

        private void Run_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BackgroundWorker();
            bw.DoWork += (s, o) =>
            {
                Action.Add();
            };
            bw.RunWorkerCompleted += (s, o) => { _busyIndicator.IsBusy = false; };
            bw.RunWorkerAsync();
            _busyIndicator.IsBusy = true;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var bw = new BackgroundWorker();
            bw.DoWork += (s, o) =>
            {
                Action.Add(5);
            };
            bw.RunWorkerAsync();
        }
    }
}
