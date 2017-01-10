using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAMI.ModelLayer.ProgressNote
{
    public class TubeDTO
    {
        /// <summary>
        /// 管線狀態
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 管線種類
        /// </summary>
        public string Category { get; set;  }

        /// <summary>
        /// 管線位置    
        /// </summary>
        public string Location { get; set;  }

        /// <summary>
        /// 放置日期
        /// </summary>
        public string SetDate { get; set;  }
    }
}
