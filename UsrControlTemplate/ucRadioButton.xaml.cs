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
    public partial class ucRadioButton : UserControl, INotifyPropertyChanged
    {

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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemList"));
                }
            }
        }
        public static readonly DependencyProperty ItemListProperty =
            DependencyProperty.Register("ItemList", typeof(List<ucRadioButtonDTO>), typeof(ucRadioButton), new PropertyMetadata(null));

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
            get;set;
        }
        public static readonly DependencyProperty ShowOtherOptionProperty =
            DependencyProperty.Register("ShowOtherOption", typeof(bool), typeof(ucRadioButton), new PropertyMetadata(true, new PropertyChangedCallback(SetOtherOptionRegion)));

        #endregion

        #region EventHandler

        /// <summary>
        /// 用來控制DataSource改變時重Bind User Control
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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
            int inputIndex = Convert.ToInt32(txtInput.Text);
            if (inputIndex > ItemList.Count)
            {
                //不合理的輸入值
            }
            else
            {
                var dto = ItemList.Find(x => x.ItemNo == inputIndex);
                var label = (Label)LogicalTreeHelper.FindLogicalNode(this.ContentGrid, dto.Value);
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
        private void DataBind(object sender, EventArgs e)
        {
            // Set Column
            for (int i = 0; i < this.ItemsInRow; i++)
            {
                var definition = new ColumnDefinition();
                definition.Width = new GridLength(1, GridUnitType.Star);
                this.ContentGrid.ColumnDefinitions.Add(definition);
            }

            //Set Row
            for (int i = 0; i < Convert.ToInt32(Math.Ceiling((decimal)ItemList.Count / ItemsInRow)); i++)
            {
                var definition = new RowDefinition();
                definition.Height = GridLength.Auto;
                this.ContentGrid.RowDefinitions.Add(definition);
            }

            // 將選項Bind上Grid
            for (int i = 0; i < ItemList.Count; i++)
            {
                Label label = new Label();
                label.Content = string.Format("{0}. {1}", ItemList[i].ItemNo, ItemList[i].DisplayName);
                label.Name = ItemList[i].Value.ToString();
                //label.Style = (Style)FindResource("lbl");

                Grid.SetRow(label, Convert.ToInt32(Math.Floor((decimal)i / ItemsInRow)));
                Grid.SetColumn(label, i % ItemsInRow);
                this.ContentGrid.Children.Add(label);
            }
        }

        #endregion

        #region Constructor

        public ucRadioButton()
        {
            InitializeComponent();

            // 事件註冊
            PropertyChanged += DataBind;
        }

        #endregion

    }
}
