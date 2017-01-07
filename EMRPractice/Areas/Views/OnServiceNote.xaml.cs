using EMRPractice.Areas.ViewModels;
using HAMI.ModelLayer.UsrControl;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using HAMI.ModelLayer.OnServiceNote;


namespace EMRPractice.Areas.Views
{
    /// <summary>
    /// OnServiceNote.xaml 的互動邏輯
    /// </summary>
    public partial class OnServiceNote : Page
    {
        public ObservableCollection<SurgeryDTO> MemberCollect = new ObservableCollection<SurgeryDTO>();

        #region Control Event

        public OnServiceNote()
        {
            InitializeComponent();

            btnPrevious.IsEnabled = false;
            lvSurgery.IsEnabled = false;
            this.KeyDown += new KeyEventHandler(MainWindow_KeyDown);

            OnServiceNoteModel model = new OnServiceNoteModel();
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
            model.Subject = Subject;
            var SourceUnit = new List<ucRadioButtonDTO>();
            SourceUnit.Add(new ucRadioButtonDTO { ItemNo = 1, DisplayName = "ER", Value = "val_1" });
            SourceUnit.Add(new ucRadioButtonDTO { ItemNo = 2, DisplayName = "OR", Value = "val_2" });
            SourceUnit.Add(new ucRadioButtonDTO { ItemNo = 3, DisplayName = "ICU", Value = "val_3" });
            SourceUnit.Add(new ucRadioButtonDTO { ItemNo = 4, DisplayName = "Ward", Value = "val_4" });
            model.SourceUnit = SourceUnit;
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
            model.ImportReason = ImportReason;
            var DiseaseHistory = new List<ucRadioButtonDTO>();
            DiseaseHistory.Add(new ucRadioButtonDTO { ItemNo = 1, DisplayName = "DM", Value = "val_1" });
            DiseaseHistory.Add(new ucRadioButtonDTO { ItemNo = 2, DisplayName = "HTN", Value = "val_2" });
            DiseaseHistory.Add(new ucRadioButtonDTO { ItemNo = 3, DisplayName = "CVA", Value = "val_3" });
            DiseaseHistory.Add(new ucRadioButtonDTO { ItemNo = 4, DisplayName = "CAD", Value = "val_4" });
            DiseaseHistory.Add(new ucRadioButtonDTO { ItemNo = 5, DisplayName = "HF", Value = "val_5" });
            DiseaseHistory.Add(new ucRadioButtonDTO { ItemNo = 6, DisplayName = "Arrhythmia", Value = "val_6" });
            DiseaseHistory.Add(new ucRadioButtonDTO { ItemNo = 7, DisplayName = "COPD", Value = "val_7" });
            DiseaseHistory.Add(new ucRadioButtonDTO { ItemNo = 8, DisplayName = "CRI", Value = "val_8" });
            DiseaseHistory.Add(new ucRadioButtonDTO { ItemNo = 9, DisplayName = "ESRD", Value = "val_9" });
            DiseaseHistory.Add(new ucRadioButtonDTO { ItemNo = 10, DisplayName = "Liver cirrhosis", Value = "val_10" });
            DiseaseHistory.Add(new ucRadioButtonDTO { ItemNo = 11, DisplayName = "Steroid use", Value = "val_11" });
            model.DiseaseHistory = DiseaseHistory;
            var Doctor = new List<ucRadioButtonDTO>();
            Doctor.Add(new ucRadioButtonDTO { ItemNo = 1, DisplayName = "醫師1", Value = "val_1" });
            Doctor.Add(new ucRadioButtonDTO { ItemNo = 2, DisplayName = "醫師2", Value = "val_2" });
            Doctor.Add(new ucRadioButtonDTO { ItemNo = 3, DisplayName = "醫師3", Value = "val_3" });
            Doctor.Add(new ucRadioButtonDTO { ItemNo = 4, DisplayName = "醫師4", Value = "val_4" });
            Doctor.Add(new ucRadioButtonDTO { ItemNo = 5, DisplayName = "醫師5", Value = "val_5" });
            Doctor.Add(new ucRadioButtonDTO { ItemNo = 6, DisplayName = "醫師6", Value = "val_6" });
            Doctor.Add(new ucRadioButtonDTO { ItemNo = 7, DisplayName = "醫師7", Value = "val_7" });
            Doctor.Add(new ucRadioButtonDTO { ItemNo = 8, DisplayName = "醫師8", Value = "val_8" });
            Doctor.Add(new ucRadioButtonDTO { ItemNo = 9, DisplayName = "醫師9", Value = "val_9" });
            Doctor.Add(new ucRadioButtonDTO { ItemNo = 10, DisplayName = "醫師10", Value = "val_10" });
            Doctor.Add(new ucRadioButtonDTO { ItemNo = 11, DisplayName = "醫師11", Value = "val_11" });

            this.rbDoctor_ImportInfoTab.ItemList = Doctor;
            this.rbDoctor_SurgeryTab.ItemList = Doctor;
            this.DataContext = model;

            //MemberCollect.Add(new Surgery()
            //{
            //    surgeryTime = "2017/01/01",
            //    surgeryName = "腦部手術",
            //    Division = "腦部外科",
            //    surgeryType = "開刀",
            //    surgeryDoctor = "丁勝利",
            //    diagnosis = "腦內出血，沒救了"
            //});
            ListViewItem_Refresh();
        }

        void ListViewItem_Refresh()
        {
            //lvSurgery.Items.Clear();
            //foreach (Surgery m in MemberCollect)
            //{
            //    lvSurgery.Items.Add(m);
            //}
            //Surgery s = new Surgery();
            //s.surgeryTime = "新增";
            //lvSurgery.Items.Add(s);
            lvSurgery.ItemsSource = this.MemberCollect;

        }

        void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            SurgeryDTO surgery = (SurgeryDTO)lvSurgery.SelectedItem;
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
                    tcMain.SelectedIndex = 4;
                    break;
                case Key.F6:
                    MemberCollect.Add(new SurgeryDTO()
                    {
                        surgeryTime = "2017/01/02",
                        surgeryName = "腦部手術",
                        Division = "腦部外科",
                        surgeryType = "開刀",
                        surgeryDoctor = "丁勝利",
                        diagnosis = "腦內出血，沒救了"
                    });
                    ListViewItem_Refresh();
                    break;
                case Key.Delete:
                    MemberCollect.Remove(surgery);
                    ListViewItem_Refresh();
                    lvSurgery.SelectedIndex = 0;
                    lvSurgery.Focus();
                    break;
                case Key.Enter:
                    if (surgery.surgeryTime.Equals("新增"))
                    {
                        //新增
                        lvSurgery.IsEnabled = false;
                        pgSurgeryModify.IsEnabled = true;

                        //dpSurgeryTime.Text = "";
                        tvDignosis.Text = "";
                        tvSurgeryName.Text = "";
                        tvSurgeryEvaluation.Text = "";
                    }
                    else
                    {
                        //修改
                        lvSurgery.IsEnabled = false;
                        pgSurgeryModify.IsEnabled = true;

                        surgery = (SurgeryDTO)lvSurgery.SelectedItem;
                    }
                    break;
                case Key.Escape:
                    //離開
                    if (pgSurgeryModify.IsEnabled == true && tcMain.SelectedIndex == 1)
                    {
                        lvSurgery.IsEnabled = true;
                        pgSurgeryModify.IsEnabled = false;
                        MessageBoxResult result = MessageBox.Show("是否要存檔?", "警告", MessageBoxButton.YesNo);
                        switch (result)
                        {
                            case MessageBoxResult.Yes:
                                //surgery = lvSurgery.SelectedItem as Surgery;
                                //int surgeryIndex = MemberCollect.FindIndex(x => x.surgeryName.Contains(surgery.surgeryName));
                                //surgery.surgeryTime = dpSurgeryTime.Text;
                                //surgery.diagnosis = tvDignosis.Text;
                                //surgery.surgeryName = tvSurgeryName.Text;
                                //surgery.surgeryEvaluation = tvSurgeryEvaluation.Text;
                                //MemberCollect[surgeryIndex] = surgery;
                                int index = lvSurgery.SelectedIndex;
                                var value = lvSurgery.SelectedValue;
                                SurgeryDTO obj = new SurgeryDTO
                                {
                                    //surgeryTime = dpSurgeryTime.Text,
                                    diagnosis = tvDignosis.Text,
                                    surgeryName = tvSurgeryName.Text,
                                    surgeryEvaluation = tvSurgeryEvaluation.Text
                                };
                                this.MemberCollect[index] = obj;
                                ListViewItem_Refresh();
                                break;
                            case MessageBoxResult.No:

                                break;
                        }
                        lvSurgery.SelectedIndex = 0;
                        lvSurgery.Focus();
                    }

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
            else if (tcMain.SelectedIndex == 4)
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

        private void lvSurgery_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SurgeryDTO surgery = (SurgeryDTO)lvSurgery.SelectedItem;
            if (surgery != null)
            {
                //dpSurgeryTime.Text = surgery.surgeryTime;
                tvDignosis.Text = surgery.diagnosis;
                tvSurgeryName.Text = surgery.surgeryName;
                tvSurgeryEvaluation.Text = surgery.surgeryEvaluation;
            }
        }

        #endregion
    }
}
