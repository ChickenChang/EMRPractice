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

namespace EMRPractice
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {

        ViewModel vm;

        public List<Surgery> MemberCollect = new List<Surgery>();

        public MainWindow()
        {
            InitializeComponent();

            btnPrevious.IsEnabled = false;
            this.KeyDown += new KeyEventHandler(MainWindow_KeyDown);

            vm = new ViewModel();
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

            MemberCollect.Add(new Surgery()
            {
                surgeryTime = "2017/01/01",
                surgeryName = "腦部手術",
                Division = "腦部外科",
                surgeryType = "開刀",
            });
            ListViewItem_Refresh();

    }
        void ListViewItem_Refresh()
        {
            lvSurgery.Items.Clear();
            foreach (Surgery m in MemberCollect)
            {
                lvSurgery.Items.Add(m);
            }
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
                case Key.F5:
                    MemberCollect.Add(new Surgery()
                    {
                        surgeryTime = "2017/01/02",
                        surgeryName = "腦部手術",
                        Division = "腦部外科",
                        surgeryType = "開刀",
                    });
                    ListViewItem_Refresh();
                    break;
                case Key.F6:
                    Surgery surgery = lvSurgery.SelectedItem as Surgery;
                    MemberCollect.Remove(surgery);
                    ListViewItem_Refresh();
                    lvSurgery.SelectedIndex = 0;
                    break;
                case Key.Enter:
                    lvSurgery.IsEnabled = false;
                    break;
                case Key.Escape:
                    lvSurgery.IsEnabled = true;
                    break;
                default:
                    break;
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

            
        }

        private void tcMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
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
    }

    public class Surgery
    {
        public string surgeryTime { get; set; }
        public string surgeryName { get; set; }
        public string Division { get; set; }
        public string surgeryType { get; set; }
    }
}
