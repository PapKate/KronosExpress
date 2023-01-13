using System.Xml.Serialization;

namespace KronosExpress
{
    public class ArrayOfTraceEventClassResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The trace events
        /// </summary>
        [XmlElement(ElementName = "TraceEventClass")]
        public IEnumerable<TraceEventClassResponseModel> TraceEventClasses { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructors
        /// </summary>
        public ArrayOfTraceEventClassResponseModel()
        {

        }

        #endregion
    }
}
