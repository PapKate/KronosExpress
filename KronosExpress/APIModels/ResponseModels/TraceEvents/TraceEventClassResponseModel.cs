using System.Xml.Serialization;

namespace KronosExpress
{
    public class TraceEventClassResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The code
        /// </summary>
        [XmlElement(ElementName = "Code")]
        public string Code { get; set; }

        /// <summary>
        /// The description
        /// </summary>
        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// The service
        /// </summary>
        [XmlElement(ElementName = "Servicecode")]
        public string ServiceCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructors
        /// </summary>
        public TraceEventClassResponseModel()
        {

        }

        #endregion
    }
}
