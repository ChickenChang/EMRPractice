using System.Windows.Controls;
using System.Windows.Input;
using System.Text.RegularExpressions;
using System.Windows;

namespace UsrControlTemplate
{
    /// <summary>
    /// DateTimeBlock.xaml 的互動邏輯
    /// </summary>
    public partial class DateTimeBlock : UserControl
    {
        #region DependenyProperty (DP)

        /// <summary>
        /// 是否顯示時間區塊
        /// </summary>
        public bool ShowTimeRegion
        {
            get { return (bool)GetValue(ShowTimeRegionProperty); }
            set
            {
                SetValue(ShowTimeRegionProperty, value);
            }
        }
        public static readonly DependencyProperty ShowTimeRegionProperty =
            DependencyProperty.Register("ShowTimeRegion", typeof(bool), typeof(DateTimeBlock), new PropertyMetadata(true, new PropertyChangedCallback(SetTimeRegion)));

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

        #endregion

        #region Constructor

        public DateTimeBlock()
        {
            InitializeComponent();
        }

        #endregion
    }
}
