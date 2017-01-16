using HAMI.ModelLayer.UsrControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace UsrControlTemplate
{
    /// <summary>
    /// ucRadioButton.xaml 的互動邏輯
    /// </summary>
    public partial class ucRadioButton : UserControl
    {
        #region Public Property

        /// <summary>
        /// 目前選取選項的Value
        /// </summary>
        public string SelectedValue { get; set; }

        /// <summary>
        /// 目前選取選項的Text
        /// </summary>
        public string SelectedText { get; set; }

        #endregion

        #region DependenyProperty (DP)

        /// <summary>
        /// Data Source
        /// </summary>
        public List<ucRadioButtonDTO> ItemList
        {
            get { return (List<ucRadioButtonDTO>)GetValue(ItemListProperty); }
            set
            {
                if (!object.Equals(ItemListProperty, value))
                {
                    SetValue(ItemListProperty, value);
                }
            }
        }
        public static readonly DependencyProperty ItemListProperty =
            DependencyProperty.Register("ItemList", typeof(List<ucRadioButtonDTO>), typeof(ucRadioButton), new PropertyMetadata(null, new PropertyChangedCallback(DataBind)));

        /// <summary>
        /// How many items in one row
        /// </summary>
        public int ItemsInRow
        {
            get { return (int)GetValue(ItemsInRowProperty); }
            set { SetValue(ItemsInRowProperty, value); }
        }
        public static readonly DependencyProperty ItemsInRowProperty =
            DependencyProperty.Register("ItemsInRow", typeof(int), typeof(ucRadioButton), new PropertyMetadata(5));

        /// <summary>
        /// 是否顯示其他選項
        /// </summary>
        public bool ShowOtherOption
        {
            get; set;
        }
        public static readonly DependencyProperty ShowOtherOptionProperty =
            DependencyProperty.Register("ShowOtherOption", typeof(bool), typeof(ucRadioButton), new PropertyMetadata(false, new PropertyChangedCallback(SetOtherOptionRegion)));

        #endregion
        
        #region ControlEvent

        /// <summary>
        /// TextBox只可輸入數字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        /// <summary>
        /// txtInput LostFocus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInput_LostFocus(object sender, RoutedEventArgs e)
        {
            var validator = this.InputValidate(txtInput.Text);
            if (!string.IsNullOrEmpty(validator))
            {
                //不合理的輸入值
            }
            else
            {
                // 取消上一次選項的反色
                if (this.SelectedValue != null)
                {
                    var previousLabel = (Label)LogicalTreeHelper.FindLogicalNode(this.ContentGrid, this.SelectedValue);
                    previousLabel.Background = Brushes.White;
                }

                var dto = ItemList.Find(x => x.ItemNo == Convert.ToInt32(txtInput.Text));
                var label = (Label)LogicalTreeHelper.FindLogicalNode(this.ContentGrid, dto.Value);
                this.SelectedValue = dto.Value;
                this.SelectedText = dto.DisplayName;
                label.Background = Brushes.LightGreen;
            }
        }

        /// <summary>
        /// 設定顯示其他選項區塊
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        private static void SetOtherOptionRegion(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            var instance = (ucRadioButton)obj;
            var visibility = (bool)e.NewValue == true ? Visibility.Visible : Visibility.Collapsed;

            instance.OtherOptionRegion.Visibility = visibility;
        }

        #endregion

        #region Private Function

        /// <summary>
        /// Bind RadioButton Data Source
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void DataBind(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            var thisRB = (ucRadioButton)obj;

            // Set Column
            for (int i = 0; i < (thisRB.ItemsInRow > thisRB.ItemList.Count ? thisRB.ItemList.Count : thisRB.ItemsInRow); i++)
            {
                var definition = new ColumnDefinition();
                definition.Width = new GridLength(1, GridUnitType.Auto);
                //definition.Width = GridLength.Auto;
                thisRB.ContentGrid.ColumnDefinitions.Add(definition);
            }

            //Set Row
            for (int i = 0; i < Convert.ToInt32(Math.Ceiling((decimal)thisRB.ItemList.Count / thisRB.ItemsInRow)); i++)
            {
                var definition = new RowDefinition();
                definition.Height = GridLength.Auto;
                thisRB.ContentGrid.RowDefinitions.Add(definition);
            }

            // 將選項Bind上Grid
            for (int i = 0; i < thisRB.ItemList.Count; i++)
            {
                Label label = new Label();
                label.Content = string.Format("{0}. {1}", thisRB.ItemList[i].ItemNo, thisRB.ItemList[i].DisplayName);
                label.Name = thisRB.ItemList[i].Value.ToString();
                //label.Style = (Style)FindResource("lbl");

                Grid.SetRow(label, Convert.ToInt32(Math.Floor((decimal)i / thisRB.ItemsInRow)));
                Grid.SetColumn(label, i % thisRB.ItemsInRow);
                thisRB.ContentGrid.Children.Add(label);
            }
        }

        /// <summary>
        /// 輸入驗證
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string InputValidate(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "未輸入選項!!";
            if (Convert.ToInt32(input) > ItemList.Count)
                return "超過選項範圍!!";

            return string.Empty;
        }

        #endregion

        #region Constructor

        public ucRadioButton()
        {
            InitializeComponent();
            
        }

        #endregion

    }
}
