using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KronosExpress
{
    public class PrintLabelRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The waybill
        /// </summary>
        public string AWB { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PrintLabelRequestModel()
        {

        }

        #endregion
    }
}
