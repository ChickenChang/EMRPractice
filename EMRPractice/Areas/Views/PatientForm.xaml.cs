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

namespace EMRPractice.Areas.Views
{
    /// <summary>
    /// PatientForm.xaml 的互動邏輯
    /// </summary>
    public partial class PatientForm : Page
    {
        public PatientForm()
        {
            InitializeComponent();
        }

        private void OnService_Edit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OnServiceNote());
        }

        private void OnService_View_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Progress_Add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProgressNote());

        }

        private void Progress_Edit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProgressNote());

        }

        private void Progress_View_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
