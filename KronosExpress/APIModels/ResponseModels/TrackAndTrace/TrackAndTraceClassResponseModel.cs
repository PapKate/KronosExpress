using System.Xml.Serialization;

namespace KronosExpress
{
    public class TrackAndTraceClassResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The date of the event
        /// </summary>
        [XmlElement(ElementName = "Date")]
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// The id that matches with the get settlements
        /// </summary>
        [XmlElement(ElementName = "SettlementID")]
        public string SettlementId { get; set; }

        /// <summary>
        /// The status
        /// </summary>
        [XmlElement(ElementName = "Status")]
        public Status Status { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TrackAndTraceClassResponseModel()
        {

        }

        #endregion
    }
}
