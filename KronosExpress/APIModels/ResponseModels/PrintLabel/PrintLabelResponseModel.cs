using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KronosExpress
{
    public class PrintLabelResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The result
        /// </summary>
        [XmlElement(ElementName = "PrintLabelResult")]
        public PrintLabelResultResponseModel PrintLabelResult { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PrintLabelResponseModel()
        {

        }

        #endregion
    }
}
