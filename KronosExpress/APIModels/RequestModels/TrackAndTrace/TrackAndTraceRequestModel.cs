using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KronosExpress
{
    public class TrackAndTraceRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The waybill number
        /// </summary>
        [XmlElement(ElementName = "AWB")]
        public string AWB { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TrackAndTraceRequestModel()
        {

        }

        #endregion
    }
}
