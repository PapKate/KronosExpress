using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KronosExpress
{
    public class TraceEventsResponseResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The result of the response 
        /// </summary>
        [XmlElement(ElementName = "TraceEventsResult")]
        public TraceEventsResultResponseModel TraceEvents { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructors
        /// </summary>
        public TraceEventsResponseResponseModel()
        {

        }

        #endregion
    }
}
