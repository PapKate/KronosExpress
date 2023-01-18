using System.Xml.Serialization;

namespace KronosExpress
{
    /// <summary>
    /// The result of the response of the announcement of waybills to Kronos Express system
    /// </summary>
    public class AnnounceCreateAWBResultResponseModel
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
        public AnnounceCreateAWBResultResponseModel() : base()
        {

        }

        #endregion
    }
}
