using System.Xml.Serialization;

namespace KronosExpress
{
    public class TraceEventsResultResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The array of trace events
        /// </summary>
        [XmlElement(ElementName = "ArrayOfTraceEventClass")]
        public ArrayOfTraceEventClassResponseModel ArrayOfTraceEventClass { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructors
        /// </summary>
        public TraceEventsResultResponseModel()
        {

        }

        #endregion
    }
}
