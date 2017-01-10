using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HAMI.ModelLayer.UsrControl;

namespace EMRPractice.Areas.ViewModels
{
    public class ProgressNoteModel
    {
        /// <summary>
        /// RespiratoryMode RadioButton DataSource
        /// </summary>
        public List<ucRadioButtonDTO> RespiratoryMode { get; set; }

        /// <summary>
        /// CoughReflex RadioButton DataSource
        /// </summary>
        public List<ucRadioButtonDTO> CoughReflex { get; set; }

        /// <summary>
        /// CoughStrength RadioButton DataSource
        /// </summary>
        public List<ucRadioButtonDTO> CoughStrength { get; set; }

        /// <summary>
        /// SputumAmount RadioButton DataSource
        /// </summary>
        public List<ucRadioButtonDTO> SputumAmount { get; set; }

        /// <summary>
        /// SputumCharacteristics RadioButton DataSource
        /// </summary>
        public List<ucRadioButtonDTO> SputumCharacteristics { get; set; }

        /// <summary>
        /// UrineColor RadioButton DataSource
        /// </summary>
        public List<ucRadioButtonDTO> UrineColor { get; set; }

        /// <summary>
        /// SedimentsAmount RadioButton DataSource
        /// </summary>
        public List<ucRadioButtonDTO> SedimentsAmount { get; set; }

        /// <summary>
        /// InPastTime RadioButton DataSource
        /// </summary>
        public List<ucRadioButtonDTO> InPastTime { get; set; }


        public List<ucRadioButtonDTO> Binary { get; set; }

        public List<ucRadioButtonDTO> DRRLLP { get; set; }

        public List<ucRadioButtonDTO> HNH { get; set; }

        public List<ucRadioButtonDTO> D14 { get; set; }

        public List<ucRadioButtonDTO> AbdominalColor { get; set; }

        public List<ucRadioButtonDTO> TubeCategory { get; set; }
    }
}
