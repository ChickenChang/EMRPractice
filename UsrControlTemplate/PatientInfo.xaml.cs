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

namespace UsrControlTemplate
{
    /// <summary>
    /// PatientInfo.xaml 的互動邏輯
    /// </summary>
    public partial class PatientInfo : UserControl
    {
        #region Public Property

        /// <summary>
        /// 病歷號
        /// </summary>
        public string RecordID
        {
            get { return (string)this.lblRecordID.Content; }
            set { this.lblRecordID.Content = value; }
        }

        /// <summary>
        /// 姓名
        /// </summary>
        public string PatientName
        {
            get { return (string)this.lblPatientName.Content; }
            set { this.lblPatientName.Content = value; }
        }

        /// <summary>
        /// 病床號碼
        /// </summary>
        public string BedID
        {
            get { return (string)this.lblBedID.Content; }
            set { this.lblBedID.Content = value; }
        }

        /// <summary>
        /// 主治醫師
        /// </summary>
        public string AttendingPhysician
        {
            get { return (string)this.lblAttendingPhysician.Content; }
            set { this.lblAttendingPhysician.Content = value; }
        }

        /// <summary>
        /// 來源單位
        /// </summary>
        public string SourceUnit
        {
            get { return (string)this.lblSourceUnit.Content; }
            set { this.lblSourceUnit.Content = value; }
        }

        /// <summary>
        /// 入ICU天數
        /// </summary>
        public int ImportDayCount
        {
            get { return (int)this.lblImportDayCount.Content; }
        }

        #endregion

        public PatientInfo()
        {
            InitializeComponent();
        }
    }
}
