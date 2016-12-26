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

            List<ucRadioButtonDTO> list = new List<ucRadioButtonDTO>();
            list.Add(new ucRadioButtonDTO { ItemNo = 1, DisplayName = "test", Value = "test_val" });
            this.ucRB.ItemList = list;
        }
    }
}
