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
using System.ComponentModel;
using HAMI.ModelLayer.UsrControl;

namespace UsrControlTemplate
{
    /// <summary>
    /// ucRadioButton.xaml 的互動邏輯
    /// </summary>
    public partial class ucRadioButton : UserControl, INotifyPropertyChanged
    {
        #region PublicProperty



        #endregion

        #region DependenyProperty (DP)

        /// <summary>
        /// Data Source
        /// </summary>
        private List<ucRadioButtonDTO> _itemList;
        public List<ucRadioButtonDTO> ItemList
        {
            get{ return (List<ucRadioButtonDTO>)GetValue(ItemListProperty); }
            set
            {
                if (!object.Equals(_itemList, value))
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

        #endregion

        #region Property Changed Even Handler
        
        /// <summary>
        /// 用來控制DataSource改變時重Bind User Control
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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
                this.MainGrid.ColumnDefinitions.Add(definition);
            }

            //Set Row
            for (int i = 0; i < Convert.ToInt16(Math.Ceiling((decimal)ItemList.Count / ItemsInRow)); i++)
            {
                var definition = new RowDefinition();
                definition.Height = GridLength.Auto;
                this.MainGrid.RowDefinitions.Add(definition);
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
