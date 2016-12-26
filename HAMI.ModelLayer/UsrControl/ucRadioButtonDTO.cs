using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAMI.ModelLayer.UsrControl
{
    public class ucRadioButtonDTO
    {
        /// <summary>
        /// Item序號 (對應使用者KeyIn的號碼)
        /// </summary>
        public int ItemNo { get; set; }

        /// <summary>
        /// 畫面顯示字樣
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// SelectValue
        /// </summary>
        public string Value { get; set; }
    }
}
