﻿using Practical_for_BD.Pages;
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

namespace Practical_for_BD
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrmMain.Navigate(new Authorisation());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.GoBack();
        }

        private void FrmName_ContentRendered(object sender, EventArgs e)
        {
            if (FrmMain.CanGoBack)
            {
                BtnBack.Visibility = Visibility.Visible;
            }
            else
                BtnBack.Visibility = Visibility.Hidden;
        }
    }
}
