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
using EMRPractice.Areas.ViewModels;
using HAMI.ModelLayer.UsrControl;
using HAMI.ModelLayer.ProgressNote;
using System.Collections.ObjectModel;


namespace EMRPractice.Areas.Views
{
    /// <summary>
    /// ProgressNote.xaml 的互動邏輯
    /// </summary>
    public partial class ProgressNote : Page
    {
        public ObservableCollection<TubeDTO> TubeCollect = new ObservableCollection<TubeDTO>();

        public ProgressNote()
        {
            InitializeComponent();

            var model = new ProgressNoteModel();

            var RespiratoryMode = new List<ucRadioButtonDTO>();
            RespiratoryMode.Add(new ucRadioButtonDTO { ItemNo = 1, DisplayName = "SB without MV", Value = "val_1" });
            RespiratoryMode.Add(new ucRadioButtonDTO { ItemNo = 2, DisplayName = "NIPPV", Value = "val_2" });
            RespiratoryMode.Add(new ucRadioButtonDTO { ItemNo = 3, DisplayName = "MV", Value = "val_3" });
            model.RespiratoryMode = RespiratoryMode;
            var CoughReflex = new List<ucRadioButtonDTO>();
            CoughReflex.Add(new ucRadioButtonDTO { ItemNo = 1, DisplayName = "nil", Value = "val_1" });
            CoughReflex.Add(new ucRadioButtonDTO { ItemNo = 2, DisplayName = "Well", Value = "val_2" });
            CoughReflex.Add(new ucRadioButtonDTO { ItemNo = 3, DisplayName = "Fair", Value = "val_3" });
            CoughReflex.Add(new ucRadioButtonDTO { ItemNo = 4, DisplayName = "Poor", Value = "val_4" });
            model.CoughReflex = CoughReflex;
            var CoughStrength = new List<ucRadioButtonDTO>();
            CoughStrength.Add(new ucRadioButtonDTO { ItemNo = 1, DisplayName = "nil", Value = "val_1" });
            CoughStrength.Add(new ucRadioButtonDTO { ItemNo = 2, DisplayName = "Well", Value = "val_2" });
            CoughStrength.Add(new ucRadioButtonDTO { ItemNo = 3, DisplayName = "Fair", Value = "val_3" });
            CoughStrength.Add(new ucRadioButtonDTO { ItemNo = 4, DisplayName = "Poor", Value = "val_4" });
            model.CoughStrength = CoughStrength;
            var SputumAmount = new List<ucRadioButtonDTO>();
            SputumAmount.Add(new ucRadioButtonDTO { ItemNo = 1, DisplayName = "nil", Value = "val_1" });
            SputumAmount.Add(new ucRadioButtonDTO { ItemNo = 2, DisplayName = "Scanty", Value = "val_2" });
            SputumAmount.Add(new ucRadioButtonDTO { ItemNo = 3, DisplayName = "Mild", Value = "val_3" });
            SputumAmount.Add(new ucRadioButtonDTO { ItemNo = 4, DisplayName = "Moderate", Value = "val_4" });
            SputumAmount.Add(new ucRadioButtonDTO { ItemNo = 5, DisplayName = "Large", Value = "val_5" });
            SputumAmount.Add(new ucRadioButtonDTO { ItemNo = 6, DisplayName = "Massive", Value = "val_6" });
            model.SputumAmount = SputumAmount;
            var SputumCharacteristics = new List<ucRadioButtonDTO>();
            SputumCharacteristics.Add(new ucRadioButtonDTO { ItemNo = 1, DisplayName = "Mucoid", Value = "val_1" });
            SputumCharacteristics.Add(new ucRadioButtonDTO { ItemNo = 2, DisplayName = "Mucopurulent", Value = "val_2" });
            SputumCharacteristics.Add(new ucRadioButtonDTO { ItemNo = 3, DisplayName = "Purulent", Value = "val_3" });
            SputumCharacteristics.Add(new ucRadioButtonDTO { ItemNo = 4, DisplayName = "Pink Frothy", Value = "val_4" });
            SputumCharacteristics.Add(new ucRadioButtonDTO { ItemNo = 5, DisplayName = "Hemoptysis", Value = "val_5" });
            SputumCharacteristics.Add(new ucRadioButtonDTO { ItemNo = 6, DisplayName = "Blood clots", Value = "val_6" });
            SputumCharacteristics.Add(new ucRadioButtonDTO { ItemNo = 7, DisplayName = "Blood Streaked", Value = "val_7" });
            SputumCharacteristics.Add(new ucRadioButtonDTO { ItemNo = 8, DisplayName = "Rusty", Value = "val_8" });
            model.SputumCharacteristics = SputumCharacteristics;
            var UrineColor = new List<ucRadioButtonDTO>();
            UrineColor.Add(new ucRadioButtonDTO { ItemNo = 1, DisplayName = "Transparent", Value = "val_1" });
            UrineColor.Add(new ucRadioButtonDTO { ItemNo = 2, DisplayName = "Straw", Value = "val_2" });
            UrineColor.Add(new ucRadioButtonDTO { ItemNo = 3, DisplayName = "Amber", Value = "val_3" });
            UrineColor.Add(new ucRadioButtonDTO { ItemNo = 4, DisplayName = "Dark Orange", Value = "val_4" });
            UrineColor.Add(new ucRadioButtonDTO { ItemNo = 5, DisplayName = "Red", Value = "val_5" });
            UrineColor.Add(new ucRadioButtonDTO { ItemNo = 6, DisplayName = "Fresh Blood", Value = "val_6" });
            UrineColor.Add(new ucRadioButtonDTO { ItemNo = 7, DisplayName = "Dark Brown", Value = "val_7" });
            UrineColor.Add(new ucRadioButtonDTO { ItemNo = 8, DisplayName = "Cloudy", Value = "val_8" });
            model.UrineColor = UrineColor;
            var SedimentsAmount = new List<ucRadioButtonDTO>();
            SedimentsAmount.Add(new ucRadioButtonDTO { ItemNo = 1, DisplayName = "Clear", Value = "val_1" });
            SedimentsAmount.Add(new ucRadioButtonDTO { ItemNo = 2, DisplayName = "Mild", Value = "val_2" });
            SedimentsAmount.Add(new ucRadioButtonDTO { ItemNo = 3, DisplayName = "Moderate", Value = "val_3" });
            SedimentsAmount.Add(new ucRadioButtonDTO { ItemNo = 4, DisplayName = "Large", Value = "val_4" });
            model.SedimentsAmount = SedimentsAmount;
            var InPastTime = new List<ucRadioButtonDTO>();
            InPastTime.Add(new ucRadioButtonDTO { ItemNo = 1, DisplayName = "24hr", Value = "val_1" });
            InPastTime.Add(new ucRadioButtonDTO { ItemNo = 2, DisplayName = "8hr", Value = "val_2" });
            model.InPastTime = InPastTime;
            var Binary = new List<ucRadioButtonDTO>();
            Binary.Add(new ucRadioButtonDTO { ItemNo = 1, DisplayName = "nil", Value = "val_1" });
            Binary.Add(new ucRadioButtonDTO { ItemNo = 2, DisplayName = "negative", Value = "val_2" });
            Binary.Add(new ucRadioButtonDTO { ItemNo = 3, DisplayName = "positive", Value = "val_3" });
            model.Binary = Binary;
            var DRRLLP = new List<ucRadioButtonDTO>();
            DRRLLP.Add(new ucRadioButtonDTO { ItemNo = 1, DisplayName = "nil", Value = "val_1" });
            DRRLLP.Add(new ucRadioButtonDTO { ItemNo = 2, DisplayName = "Diffuse", Value = "val_2" });
            DRRLLP.Add(new ucRadioButtonDTO { ItemNo = 3, DisplayName = "RUQ", Value = "val_3" });
            DRRLLP.Add(new ucRadioButtonDTO { ItemNo = 4, DisplayName = "RLQ", Value = "val_4" });
            DRRLLP.Add(new ucRadioButtonDTO { ItemNo = 5, DisplayName = "LUQ", Value = "val_5" });
            DRRLLP.Add(new ucRadioButtonDTO { ItemNo = 6, DisplayName = "LLQ", Value = "val_6" });
            DRRLLP.Add(new ucRadioButtonDTO { ItemNo = 7, DisplayName = "Periumbilical", Value = "val_7" });
            model.DRRLLP = DRRLLP;
            var HNH = new List<ucRadioButtonDTO>();
            HNH.Add(new ucRadioButtonDTO { ItemNo = 1, DisplayName = "nil", Value = "val_1" });
            HNH.Add(new ucRadioButtonDTO { ItemNo = 2, DisplayName = "Hypoactive", Value = "val_2" });
            HNH.Add(new ucRadioButtonDTO { ItemNo = 3, DisplayName = "Normoactive", Value = "val_3" });
            HNH.Add(new ucRadioButtonDTO { ItemNo = 4, DisplayName = "Hyperactive", Value = "val_4" });
            model.HNH = HNH;
            var D14 = new List<ucRadioButtonDTO>();
            D14.Add(new ucRadioButtonDTO { ItemNo = 1, DisplayName = "nil", Value = "val_1" });
            D14.Add(new ucRadioButtonDTO { ItemNo = 2, DisplayName = "1-3 times", Value = "val_2" });
            D14.Add(new ucRadioButtonDTO { ItemNo = 3, DisplayName = "4-6 times", Value = "val_3" });
            D14.Add(new ucRadioButtonDTO { ItemNo = 4, DisplayName = "Diarrhea", Value = "val_4" });
            model.D14 = D14;
            var AbdominalColor = new List<ucRadioButtonDTO>();
            AbdominalColor.Add(new ucRadioButtonDTO { ItemNo = 1, DisplayName = "Normal", Value = "val_1" });
            AbdominalColor.Add(new ucRadioButtonDTO { ItemNo = 2, DisplayName = "Dark red", Value = "val_2" });
            AbdominalColor.Add(new ucRadioButtonDTO { ItemNo = 3, DisplayName = "Tarry", Value = "val_3" });
            AbdominalColor.Add(new ucRadioButtonDTO { ItemNo = 4, DisplayName = "Fresh blood", Value = "val_4" });
            AbdominalColor.Add(new ucRadioButtonDTO { ItemNo = 5, DisplayName = "Clay", Value = "val_5" });
            model.AbdominalColor = AbdominalColor;
            var TubeCategory = new List<ucRadioButtonDTO>();
            TubeCategory.Add(new ucRadioButtonDTO { ItemNo = 1, DisplayName = "Endotracheal tube", Value = "val_1" });
            TubeCategory.Add(new ucRadioButtonDTO { ItemNo = 2, DisplayName = "Tracheaostomy", Value = "val_2" });
            TubeCategory.Add(new ucRadioButtonDTO { ItemNo = 3, DisplayName = "Urinary catheter", Value = "val_3" });
            TubeCategory.Add(new ucRadioButtonDTO { ItemNo = 4, DisplayName = "CVC/Swan-Ganz", Value = "val_4" });
            TubeCategory.Add(new ucRadioButtonDTO { ItemNo = 5, DisplayName = "Double-lumen catheter for H/D", Value = "val_5" });
            TubeCategory.Add(new ucRadioButtonDTO { ItemNo = 6, DisplayName = "NG tube", Value = "val_6" });
            TubeCategory.Add(new ucRadioButtonDTO { ItemNo = 7, DisplayName = "Chest Pigtail/Chest tube", Value = "val_7" });
            TubeCategory.Add(new ucRadioButtonDTO { ItemNo = 8, DisplayName = "Pericardial Pigtail/Chest tube", Value = "val_8" });
            TubeCategory.Add(new ucRadioButtonDTO { ItemNo = 9, DisplayName = "Abdomen Pigtail", Value = "val_9" });
            TubeCategory.Add(new ucRadioButtonDTO { ItemNo = 10, DisplayName = "V/B", Value = "val_10" });
            TubeCategory.Add(new ucRadioButtonDTO { ItemNo = 11, DisplayName = "Panrose drain", Value = "val_11" });
            TubeCategory.Add(new ucRadioButtonDTO { ItemNo = 12, DisplayName = "EVD", Value = "val_12" });
            TubeCategory.Add(new ucRadioButtonDTO { ItemNo = 13, DisplayName = "ICP monitor", Value = "val_13" });
            model.TubeCategory = TubeCategory;

            this.DataContext = model;
        }
        
        void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            TubeDTO tube = (TubeDTO)lvTube.SelectedItem;
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
                    TubeCollect.Add(new TubeDTO()
                    {
                        Status="1",
                        Category="2",
                        Location="3",
                        SetDate="4"
                    });
                    lvTube.ItemsSource = TubeCollect;
                    break;
                case Key.Delete:
                    TubeCollect.Remove(tube);
                    lvTube.ItemsSource = TubeCollect;
                    lvTube.SelectedIndex = 0;
                    lvTube.Focus();
                    break;
                case Key.Enter:
                    if (tube.SetDate.Equals("新增"))
                    {
                        //新增
                        lvTube.IsEnabled = false;
                        pgSurgeryModify.IsEnabled = true;

                        ////dpSurgeryTime.Text = "";
                        //tvDignosis.Text = "";
                        //tvSurgeryName.Text = "";
                        //tvSurgeryEvaluation.Text = "";
                    }
                    else
                    {
                        //修改
                        lvTube.IsEnabled = false;
                        pgSurgeryModify.IsEnabled = true;

                        tube = (TubeDTO)lvTube.SelectedItem;
                    }
                    break;
                case Key.Escape:
                    //離開
                    if (pgSurgeryModify.IsEnabled == true && tcMain.SelectedIndex == 1)
                    {
                        lvTube.IsEnabled = true;
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
                                int index = lvTube.SelectedIndex;
                                var value = lvTube.SelectedValue;
                                TubeDTO obj = new TubeDTO
                                {
                                    //surgeryTime = dpSurgeryTime.Text,
                                    //diagnosis = tvDignosis.Text,
                                    //surgeryName = tvSurgeryName.Text,
                                    //surgeryEvaluation = tvSurgeryEvaluation.Text
                                };
                                this.TubeCollect[index] = obj;
                                this.lvTube.ItemsSource = TubeCollect;
                                break;
                            case MessageBoxResult.No:

                                break;
                        }
                        lvTube.SelectedIndex = 0;
                        lvTube.Focus();
                    }

                    break;
                default:
                    break;
            }
        }

        private void lvTube_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TubeDTO tube = (TubeDTO)lvTube.SelectedItem;
            if (tube != null)
            {
                this.txtLocation.Text = tube.Location;
                this.txtStatus.Text = tube.Status;
            }
        }


    }
}
