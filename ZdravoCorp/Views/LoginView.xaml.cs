using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
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
using ZdravoCorp.Users;
using ZdravoCorp.Repository;
using ZdravoCorp.Views;

namespace ZdravoCorp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }
        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Fill out all fields first!");
            }
            else
            {
                ValidateLogin();
            }
        }

        private void ValidateLogin()
        {
            User loggedInUser = UserRepository.users.FirstOrDefault(user =>
            user.GetUsername() == textBoxUsername.Text && user.GetPassword() == textBoxPassword.Text);

            if (loggedInUser != null)
            {
                MessageBox.Show($"Welcome {loggedInUser.GetName} {loggedInUser.GetSurname}");
                UserRepository.loggedUser = loggedInUser;
                OpenRoleMenu(loggedInUser);
            }
            else
            {
                MessageBox.Show("Sorry, wrong credentials.");
                textBoxPassword.Clear();
                textBoxUsername.Clear();
            }
        }

        private void OpenRoleMenu(User user)
        {
            if (user.GetRole() == Role.Doctor)
            {
                //Send to Doctor form

                throw new NotImplementedException();
            }
            else if (user.GetRole() == Role.Nurse)
            {
                NurseView nurse = new NurseView();
                nurse.Show();
                Close();
            }
            else if (user.GetRole() == Role.Patient)
            {
                PatientView patient = new PatientView();
                patient.Show();
                Close();

            }
            else if (user.GetRole() == Role.Admin)
            {
                AdminView admin = new AdminView();
                admin.Show();
                Close();
            }
        }

        private void LoginForm_Loaded(object sender, RoutedEventArgs e)
        {
            UserRepository.loggedUser = null;
        }

        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            // Temporary for showing purposes until file system is implemented.
            User admin = new User(1, "Admin", "Admin", "admin", "123", DateTime.Today, Gender.Other, Role.Admin);
            UserRepository.users.Add(admin);
        }
    }
}
