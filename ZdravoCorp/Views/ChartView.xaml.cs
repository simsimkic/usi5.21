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
using ZdravoCorp.Repository;

namespace ZdravoCorp.Views
{
    /// <summary>
    /// Interaction logic for Chart.xaml
    /// </summary>
    public partial class ChartView : Window
    {
        public ChartView()
        {
            InitializeComponent();
        }
        ChartRepository repository;
        private void buttonInsert_Click(object sender, RoutedEventArgs e)
        {
            Model.Chart chart = repository.GetLastChart();
            chart.SetHeight(Convert.ToDouble(textBoxHeight.Text));
            chart.SetWeight(Convert.ToDouble(textBoxWeight.Text));

            MessageBox.Show($"Patient {chart.GetPatient().GetName()} {chart.GetPatient().GetSurname()} has height of {chart.GetHeight()} and weight of {chart.GetWeight()}");
        }
    }
}
