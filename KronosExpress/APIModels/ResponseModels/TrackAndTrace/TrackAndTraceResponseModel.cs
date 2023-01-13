using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KronosExpress
{
    /// <summary>
    /// Contains an array of all the track and traces for a specific waybill
    /// </summary>
    public class TrackAndTraceResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The result of the response
        /// </summary>
        [XmlElement(ElementName = "TrackAndTraceResult")]
        public TrackAndTraceResultResponseModel TrackAndTraceResult { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TrackAndTraceResponseModel()
        {

        }

        #endregion
    }
}
