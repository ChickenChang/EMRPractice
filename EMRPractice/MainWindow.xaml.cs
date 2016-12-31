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

        ViewModel vm;
        public MainWindow()
        {
            InitializeComponent();

            vm = new ViewModel();
<<<<<<< HEAD
            vm.Subject = new List<ucRadioButtonDTO>();
            vm.Subject.Add(new ucRadioButtonDTO { ItemNo = 1, DisplayName = "ㄧ般外科", Value = "val_1" });
            vm.Subject.Add(new ucRadioButtonDTO { ItemNo = 2, DisplayName = "婦產科", Value = "val_2" });
            vm.Subject.Add(new ucRadioButtonDTO { ItemNo = 3, DisplayName = "骨科", Value = "val_3" });
            vm.Subject.Add(new ucRadioButtonDTO { ItemNo = 4, DisplayName = "泌尿外科", Value = "val_4" });
            vm.Subject.Add(new ucRadioButtonDTO { ItemNo = 5, DisplayName = "神經外科", Value = "val_5" });
            vm.Subject.Add(new ucRadioButtonDTO { ItemNo = 6, DisplayName = "整形外科", Value = "val_6" });
            vm.Subject.Add(new ucRadioButtonDTO { ItemNo = 7, DisplayName = "口腔外科", Value = "val_7" });
            vm.Subject.Add(new ucRadioButtonDTO { ItemNo = 8, DisplayName = "大腸直腸外科", Value = "val_8" });
            vm.Subject.Add(new ucRadioButtonDTO { ItemNo = 9, DisplayName = "胸腔外科", Value = "val_9" });
            vm.Subject.Add(new ucRadioButtonDTO { ItemNo = 10, DisplayName = "耳鼻喉科", Value = "val_10" });
            vm.Subject.Add(new ucRadioButtonDTO { ItemNo = 11, DisplayName = "心血管外科", Value = "val_11" });
            //this.ucRB.ItemList = vm.Subject;
            //this.DataContext = this;
=======
             var Subject = new List<ucRadioButtonDTO>();
            Subject.Add(new ucRadioButtonDTO { ItemNo = 1, DisplayName = "ㄧ般外科", Value = "val_1" });
            Subject.Add(new ucRadioButtonDTO { ItemNo = 2, DisplayName = "婦產科", Value = "val_2" });
            Subject.Add(new ucRadioButtonDTO { ItemNo = 3, DisplayName = "骨科", Value = "val_3" });
            Subject.Add(new ucRadioButtonDTO { ItemNo = 4, DisplayName = "泌尿外科", Value = "val_4" });
            Subject.Add(new ucRadioButtonDTO { ItemNo = 5, DisplayName = "神經外科", Value = "val_5" });
            Subject.Add(new ucRadioButtonDTO { ItemNo = 6, DisplayName = "整形外科", Value = "val_6" });
            Subject.Add(new ucRadioButtonDTO { ItemNo = 7, DisplayName = "口腔外科", Value = "val_7" });
            Subject.Add(new ucRadioButtonDTO { ItemNo = 8, DisplayName = "大腸直腸外科", Value = "val_8" });
            Subject.Add(new ucRadioButtonDTO { ItemNo = 9, DisplayName = "胸腔外科", Value = "val_9" });
            Subject.Add(new ucRadioButtonDTO { ItemNo = 10, DisplayName = "耳鼻喉科", Value = "val_10" });
            Subject.Add(new ucRadioButtonDTO { ItemNo = 11, DisplayName = "心血管外科", Value = "val_11" });
            var SourceUnit = new List<ucRadioButtonDTO>();
            SourceUnit.Add(new ucRadioButtonDTO { ItemNo = 1, DisplayName = "ER", Value = "val_1" });
            SourceUnit.Add(new ucRadioButtonDTO { ItemNo = 2, DisplayName = "OR", Value = "val_2" });
            SourceUnit.Add(new ucRadioButtonDTO { ItemNo = 3, DisplayName = "ICU", Value = "val_3" });
            SourceUnit.Add(new ucRadioButtonDTO { ItemNo = 4, DisplayName = "Ward", Value = "val_4" });

            this.ucRB_Subect0.ItemList = Subject;
            this.ucRB_SourceUnit.ItemList = SourceUnit;
            //this.DataContext =  vm;
>>>>>>> origin/master

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.KeyDown += new KeyEventHandler(MainWindow_KeyDown);
            btnPrevious.IsEnabled = false;
        }

        void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.F1:
                    tcMain.SelectedIndex = 0;
                    break;
                case Key.F2:
                    tcMain.SelectedIndex = 1;
                    break;
                case Key.F3:
                    tcMain.SelectedIndex = 2;
                    break;
                case Key.F4:
                    tcMain.SelectedIndex = 3;
                    break;
                default:
                    break;
            }

            if (tcMain.SelectedIndex == 0)
            {
                btnPrevious.IsEnabled = false;
                btnNext.IsEnabled = true;
            }
            else if (tcMain.SelectedIndex == 3)
            {
                btnPrevious.IsEnabled = true;
                btnNext.IsEnabled = false;
            }
            else
            {
                btnPrevious.IsEnabled = true;
                btnNext.IsEnabled = true;
            }
        }

        private void btnClick(object sender, RoutedEventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "btnPrevious":
                    tcMain.SelectedIndex = tcMain.SelectedIndex - 1;
                    break;
                case "btnNext":
                    tcMain.SelectedIndex = tcMain.SelectedIndex + 1;
                    break;
                default:
                    break;
            }

            if(tcMain.SelectedIndex == 0)
            {
                btnPrevious.IsEnabled = false;
                btnNext.IsEnabled = true;
            }
            else if(tcMain.SelectedIndex == 3)
            {
                btnPrevious.IsEnabled = true;
                btnNext.IsEnabled = false;
            }
            else
            {
                btnPrevious.IsEnabled = true;
                btnNext.IsEnabled = true;
            }
        }
    }
}
