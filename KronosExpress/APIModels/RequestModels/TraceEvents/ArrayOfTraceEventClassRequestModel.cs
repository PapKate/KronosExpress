using System.Xml.Serialization;

namespace KronosExpress
{
    public class ArrayOfTraceEventClassRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The trace events
        /// </summary>
        [XmlElement(ElementName = "TraceEventClass")]
        public IEnumerable<TraceEventClassRequestModel> TraceEventClasses { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructors
        /// </summary>
        public ArrayOfTraceEventClassRequestModel()
        {

        }

        #endregion
    }
}
