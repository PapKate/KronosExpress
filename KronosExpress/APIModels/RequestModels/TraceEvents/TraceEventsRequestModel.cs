using System.Xml.Serialization;

namespace KronosExpress
{
    /// <summary>
    /// Contains an array with all the available track and traces
    /// </summary>
    public class TraceEventsRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The language code
        /// </summary>
        [XmlElement(ElementName = "languagecode")]
        public string LanguageCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TraceEventsRequestModel()
        {

        }

        #endregion
    }
}
