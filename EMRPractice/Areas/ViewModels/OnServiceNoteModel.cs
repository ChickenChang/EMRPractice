using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HAMI.ModelLayer.UsrControl;

namespace EMRPractice.Areas.ViewModels
{
    public class OnServiceNoteModel
    {
        /// <summary>
        /// 科別 RadioButton DataSource
        /// </summary>
        public List<ucRadioButtonDTO> Subject { get; set; }

        /// <summary>
        /// 來源單位 RadioButton DataSource
        /// </summary>
        public List<ucRadioButtonDTO> SourceUnit { get; set; }

        /// <summary>
        /// 轉入原因 RadioButton DataSource
        /// </summary>
        public List<ucRadioButtonDTO> ImportReason { get; set; }

        /// <summary>
        /// 過去重大病史 RadioButton DataSource
        /// </summary>
        public List<ucRadioButtonDTO> DiseaseHistory { get; set; }
    }
}
