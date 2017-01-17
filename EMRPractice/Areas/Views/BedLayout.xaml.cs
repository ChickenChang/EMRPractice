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
    /// BedLayout.xaml 的互動邏輯
    /// </summary>
    public partial class BedLayout : Page
    {
        public BedLayout()
        {
            InitializeComponent();

            for (int i = 0; i < 20; i++)
            {
                Button btn = new Button();
                btn.Content = "BedID-" + i.ToString() + Environment.NewLine + "空床";
                btn.Click += new RoutedEventHandler(this.BtnClickEvent);
                this.WrapContainer.Children.Add(btn);
            }

        }

        private void BtnClickEvent(object sender, EventArgs e)
        {
            NavigationService.Navigate(new PatientForm());
        }
    }
}
