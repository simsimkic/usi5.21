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
using ZdravoCorp.Model;
using ZdravoCorp.Repository;
using ZdravoCorp.Users;

namespace ZdravoCorp.Views
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
            InitializeDatePicker();
            AddGendersToComboBox();
            AddRolesToComboBox();
            userRepository = new UserRepository();
        }
        UserRepository userRepository;
        private void InitializeDatePicker()
        {
            datePickerBirthDate.DisplayDateEnd = DateTime.Today;
        }

        private void ButtonSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (IsRegistrationDataIncomplete())
            {
                MessageBox.Show("Fill out all fields first!");
            }
            else
            {
                RegisterUser();
            }
        }

        private bool IsRegistrationDataIncomplete()
        {
            return string.IsNullOrEmpty(textBoxName.Text) ||
                   string.IsNullOrEmpty(textBoxSurname.Text) ||
                   string.IsNullOrEmpty(textBoxPassword.Text) ||
                   string.IsNullOrEmpty(textBoxUsername.Text) ||
                   datePickerBirthDate.SelectedDate == null ||
                   comboBoxGender.SelectedItem == null ||
                   comboBoxRole.SelectedItem == null;
        }

        private void RegisterUser()
        {
            int newId = userRepository.GetLastID() + 1;
            User user = CreateUser(newId);
            UserRepository.users.Add(user);
            userRepository.AddUser(user.GetId());
            CreatePatientChart(user);
        }

        private User CreateUser(int newId)
        {
            return new User(
                newId,
                textBoxName.Text,
                textBoxSurname.Text,
                textBoxUsername.Text,
                textBoxPassword.Text,
                datePickerBirthDate.SelectedDate.Value,
                (Gender)comboBoxGender.SelectedItem,
                (Role)comboBoxRole.SelectedItem
            );
        }

        private void CreatePatientChart(User user)
        {
            if (user.GetRole() == Role.Patient)
            {
                Chart chart = new Chart(user);
                ChartRepository.charts.Add(chart);
            }
        }

        private void AddGendersToComboBox()
        {
            foreach (var gender in Enum.GetNames(typeof(Gender)))
            {
                comboBoxGender.Items.Add(gender);
            }
        }
        private void AddRolesToComboBox()
        {
            comboBoxRole.Items.Add(Role.Patient);
            if (UserRepository.loggedUser.GetRole() == Role.Admin)
            {
                comboBoxRole.Items.Add(Role.Admin);
                comboBoxRole.Items.Add(Role.Doctor);
                comboBoxRole.Items.Add(Role.Nurse);
            }
        }

        private void ButtonMenu_Click(object sender, RoutedEventArgs e)
        {
            if(UserRepository.loggedUser.GetRole() == Role.Nurse)
            {
                NurseView nurse =  new NurseView();
            }
            else if(UserRepository.loggedUser.GetRole() == Role.Admin)
            {
                Views.AdminView admin = new AdminView();
                admin.Show();
                Close();
            }
        }
    }
}
