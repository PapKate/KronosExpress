using System.Xml.Serialization;

namespace KronosExpress
{
    /// <summary>
    /// The body
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = KronosExpressConstants.EnvelopeNamespace)]
    public class BodyResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The response of the call for getting the announcement of waybills to Kronos Express system, provided that the customer makes available the AWB
        /// </summary>
        [XmlElement(ElementName = "AnnounceAWBResponse", Namespace = KronosExpressConstants.KronosExpressNamespace)]
        public AnnounceAWBResponseModel AnnounceAWBResponse { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BodyResponseModel()
        {

        }

        #endregion
    }
}
