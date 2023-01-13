using System.Xml.Serialization;

namespace KronosExpress
{
    public class AnnounceAWBResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The result of the response of the announcement of waybills to Kronos Express system
        /// </summary>
        [XmlElement(ElementName = "AnnounceAWBResult")]
        public AnnounceAWBResultResponseModel AnnounceAWBResult { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AnnounceAWBResponseModel() : base()
        {

        }

        #endregion
    }
}
