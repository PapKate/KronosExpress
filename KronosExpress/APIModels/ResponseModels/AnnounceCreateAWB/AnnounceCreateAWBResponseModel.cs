using System.Xml.Serialization;

namespace KronosExpress
{
    /// <summary>
    /// The response of the announcement of waybills to Kronos Express system
    /// </summary>
    public class AnnounceCreateAWBResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The result of the response of the announcement of waybills to Kronos Express system
        /// </summary>
        [XmlElement(ElementName = "AnnounceCreateAWBResult")]
        public AnnounceCreateAWBResultResponseModel AnnounceCreateAWBResult { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AnnounceCreateAWBResponseModel() : base()
        {

        }

        #endregion
    }
}
