using System.Xml.Serialization;

namespace KronosExpress
{
    /// <summary>
    /// The service
    /// </summary>
    public class ServiceClassRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The Codes can be retrieved from GetServices operation. 
        /// When using code 3 in the details you must provided the COD amount in a decimal type.x.xx e.g 5.30
        /// REQUIRED
        /// </summary>
        [XmlElement(ElementName = "ServiceCode")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// The Codes can be retrieved from GetServices operation. 
        /// ServiceDetails should be pg. 7 Kronos Express empty except only when ServiceCode is 003 where the value is the COD amount in type double e.g. 50.30.
        /// REQUIRED
        /// </summary>
        [XmlElement(ElementName = "ServiceDetails")]
        public string ServiceDetails { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServiceClassRequestModel() : base()
        {

        }

        #endregion
    }
}
