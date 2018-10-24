﻿using NextCar.Controller;
using NextCar.Model;
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
using System.Windows.Shapes;

namespace NextCar
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            LoginController loginController = new LoginController(textBox.Text, passBox.Text);
            this.Close();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
