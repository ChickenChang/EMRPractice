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
            var ImportReason = new List<ucRadioButtonDTO>();
            ImportReason.Add(new ucRadioButtonDTO { ItemNo = 1, DisplayName = "Servere sepsis / Septic shock", Value = "val_1" });
            ImportReason.Add(new ucRadioButtonDTO { ItemNo = 2, DisplayName = "Acute conscious deterioration", Value = "val_2" });
            ImportReason.Add(new ucRadioButtonDTO { ItemNo = 3, DisplayName = "Hemorrhangic shock", Value = "val_3" });
            ImportReason.Add(new ucRadioButtonDTO { ItemNo = 4, DisplayName = "Post-CPCR", Value = "val_4" });
            ImportReason.Add(new ucRadioButtonDTO { ItemNo = 5, DisplayName = "Heart failure", Value = "val_5" });
            ImportReason.Add(new ucRadioButtonDTO { ItemNo = 6, DisplayName = "High risk major operation", Value = "val_6" });
            ImportReason.Add(new ucRadioButtonDTO { ItemNo = 7, DisplayName = "Respiratory failure", Value = "val_7" });
            ImportReason.Add(new ucRadioButtonDTO { ItemNo = 8, DisplayName = "Scheduled for major operation", Value = "val_8" });
            ImportReason.Add(new ucRadioButtonDTO { ItemNo = 9, DisplayName = "Major trauma", Value = "val_9" });
            ImportReason.Add(new ucRadioButtonDTO { ItemNo = 10, DisplayName = "Unstable vital sign", Value = "val_10" });

            this.ucRB_Subect0.ItemList = Subject;
            this.ucRB_SourceUnit.ItemList = SourceUnit;
            //this.DataContext =  vm;

        }
    }
}
