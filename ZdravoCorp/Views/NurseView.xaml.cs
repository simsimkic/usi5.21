﻿using System;
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

namespace ZdravoCorp.Views
{
    /// <summary>
    /// Interaction logic for Nurse.xaml
    /// </summary>
    public partial class NurseView : Window
    {
        public NurseView()
        {
            InitializeComponent();
        }

        void NurseForm_Closed(object sender, EventArgs e)
        {
            LoginView login = new LoginView();
            login.Show();
        }

        private void ButtonRegister_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            Close();
        }
    }
}
