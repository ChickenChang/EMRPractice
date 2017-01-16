using System.Windows.Controls;
using System.Windows.Input;
using System.Text.RegularExpressions;
using System.Windows;
using System;

namespace UsrControlTemplate
{
    /// <summary>
    /// DateTimeBlock.xaml 的互動邏輯
    /// </summary>
    public partial class DateTimeBlock : UserControl
    {
        #region Public Property

        /// <summary>
        /// 日期時間
        /// </summary>
        public DateTime Date
        {
            get
            {
                return GetDateTime();
            }
            set
            {
                this.txtYear.Text = value.Year.ToString();
                this.txtMonth.Text = value.Month.ToString();
                this.txtDay.Text = value.Day.ToString();
                if (ShowTimeRegion)
                {
                    this.txtHour.Text = value.Hour.ToString();
                    this.txtMinute.Text = value.Minute.ToString();
                }
            }
        }

        /// <summary>
        /// 是否通過驗證
        /// </summary>
        public bool Validated
        {
            get { return this.Validation(); }
        }

        #endregion

        #region DependenyProperty (DP)

        /// <summary>
        /// 是否顯示時間區塊
        /// </summary>
        public bool ShowTimeRegion
        {
            get { return (bool)GetValue(ShowTimeRegionProperty); }
            set { SetValue(ShowTimeRegionProperty, value); }
        }
        public static readonly DependencyProperty ShowTimeRegionProperty =
            DependencyProperty.Register("ShowTimeRegion", typeof(bool), typeof(DateTimeBlock), new PropertyMetadata(true, new PropertyChangedCallback(SetTimeRegion)));

        /// <summary>
        /// 以中文方式顯示年月日時分
        /// </summary>
        public bool ChineseDisplayMode
        {
            get { return (bool)GetValue(ChineseDisplayModeProperty); }
            set { SetValue(ShowTimeRegionProperty, value); }
        }
        public static DependencyProperty ChineseDisplayModeProperty =
            DependencyProperty.Register("ChineseDisplayMode", typeof(bool), typeof(DateTimeBlock), new PropertyMetadata(false, new PropertyChangedCallback(SetChineseDisplayMode)));

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
        /// ShowTimeRegionProperty Changed
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        private static void SetTimeRegion(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            var instance = (DateTimeBlock)obj;
            var visibility = (bool)e.NewValue == true ? Visibility.Visible : Visibility.Collapsed;

            instance.TimeRegion.Visibility = visibility;
        }

        /// <summary>
        /// ChineseDisplayModeProperty Changed
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        private static void SetChineseDisplayMode(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            DateTimeBlock instance = (DateTimeBlock)obj;
            if ((bool)e.NewValue)
            {
                instance.lblYear_Word.Visibility = Visibility.Visible;
                instance.lblMonth_Word.Visibility = Visibility.Visible;
                instance.lblDay_Word.Visibility = Visibility.Visible;
                instance.lblHour_Word.Visibility = Visibility.Visible;
                instance.lblMinute_Word.Visibility = Visibility.Visible;

                instance.lblYear_Sign.Visibility = Visibility.Collapsed;
                instance.lblMonth_Sign.Visibility = Visibility.Collapsed;
                instance.lblDay_Sign.Visibility = Visibility.Collapsed;
                instance.lblHour_Sign.Visibility = Visibility.Collapsed;
            }
            else
            {
                instance.lblYear_Word.Visibility = Visibility.Collapsed;
                instance.lblMonth_Word.Visibility = Visibility.Collapsed;
                instance.lblDay_Word.Visibility = Visibility.Collapsed;
                instance.lblHour_Word.Visibility = Visibility.Collapsed;
                instance.lblMinute_Word.Visibility = Visibility.Collapsed;

                instance.lblYear_Sign.Visibility = Visibility.Visible;
                instance.lblMonth_Sign.Visibility = Visibility.Visible;
                instance.lblDay_Sign.Visibility = Visibility.Visible;
                instance.lblHour_Sign.Visibility = Visibility.Visible;
            }

        }

        #endregion

        #region Private Function

        /// <summary>
        /// 驗證方法
        /// </summary>
        /// <returns></returns>
        private bool Validation()
        {
            DateTime value = GetDateTime();

            if (value == DateTime.MinValue)
                return false;
            else
                return true;
        }

        /// <summary>
        /// 取得DateTime Value
        /// </summary>
        /// <returns></returns>
        private DateTime GetDateTime()
        {
            try
            {
                if (ShowTimeRegion)
                    return new DateTime(int.Parse(txtYear.Text), int.Parse(txtMonth.Text), int.Parse(txtDay.Text), int.Parse(txtHour.Text), int.Parse(txtMinute.Text), 0);
                else
                    return new DateTime(int.Parse(txtYear.Text), int.Parse(txtMonth.Text), int.Parse(txtDay.Text));
            }
            catch (Exception ex)
            {
                return DateTime.MinValue;
            }
        }

        #endregion

        #region Constructor

        public DateTimeBlock()
        {
            InitializeComponent();
        }

        #endregion
    }
}
