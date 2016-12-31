using System.Windows.Controls;
using System.Windows.Input;
using System.Text.RegularExpressions;

namespace UsrControlTemplate
{
    /// <summary>
    /// DateTimeBlock.xaml 的互動邏輯
    /// </summary>
    public partial class DateTimeBlock : UserControl
    {
        public DateTimeBlock()
        {
            InitializeComponent();
        }

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
    }
}
