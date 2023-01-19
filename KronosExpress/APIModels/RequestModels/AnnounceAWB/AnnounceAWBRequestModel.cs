
using System.Xml.Serialization;

namespace KronosExpress
{
    public class AnnounceAWBRequestModel : AnnounceCreateAWBRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Waybill number provided by customer. Waybill number should have been agreed with Kronos Express prior implementation.
        /// The AWB must have a prefix of at least 4 characters and can be as long as 25 characters/numbers.
        /// REQUIRED
        /// </summary>
        [XmlElement(ElementName = "AWB")]
        public string AWB { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AnnounceAWBRequestModel()
        {

        }

        #endregion
    }
}
