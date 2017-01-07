using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAMI.ModelLayer.OnServiceNote
{
    public class SurgeryDTO
    {
        /// <summary>
        /// 手術日期
        /// </summary>
        public string surgeryTime { get; set; }

        /// <summary>
        /// 手術名稱
        /// </summary>
        public string surgeryName { get; set; }

        /// <summary>
        /// 科別
        /// </summary>
        public string Division { get; set; }

        /// <summary>
        /// 手術種類
        /// </summary>
        public string surgeryType { get; set; }

        /// <summary>
        /// 手術醫師
        /// </summary>
        public string surgeryDoctor { get; set; }

        /// <summary>
        /// 一般診斷
        /// </summary>
        public string diagnosis { get; set; }

        /// <summary>
        /// 術後評估
        /// </summary>
        public string surgeryEvaluation { get; set; }
    }
}
