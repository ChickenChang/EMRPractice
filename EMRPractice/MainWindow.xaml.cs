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
using HAMI.ModelLayer.UsrControl;
using System.Collections.ObjectModel;
using EMRPractice.Areas.Views;

namespace EMRPractice
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {        
        public MainWindow()
        {
            InitializeComponent();

            //this.MainFrame.Content = new OnServiceNote();
            this.MainFrame.Content = new ProgressNote();
        }
                        
     }

    
}
