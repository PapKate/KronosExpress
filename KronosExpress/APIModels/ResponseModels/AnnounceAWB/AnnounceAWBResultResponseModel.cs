using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KronosExpress
{
    public class AnnounceAWBResultResponseModel 
    {
        #region Public Properties

        /// <summary>
        /// The waybill
        /// </summary>
        [XmlElement(ElementName = "AWB")]
        public string AWB { get; set; }

        /// <summary>
        /// The status
        /// </summary>
        [XmlElement(ElementName = "Status")]
        public string Status { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AnnounceAWBResultResponseModel()
        {

        }

        #endregion
    }
}
