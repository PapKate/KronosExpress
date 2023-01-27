using System.Xml;
using System.Xml.Serialization;

namespace KronosExpress
{
    /// <summary>
    /// The body
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = KronosExpressConstants.SoapNamespace)]
    public class AnnounceAWBBodyResponseModel : IBody<AnnounceAWBResponseModel>
    {
        #region Public Properties

        /// <summary>
        /// The response of the call for getting the announcement of waybills to Kronos Express system, provided that the customer makes available the AWB
        /// </summary>
        [XmlElement(ElementName = "AnnounceAWBResponse", Namespace = KronosExpressConstants.KronosExpressNamespace)]
        public AnnounceAWBResponseModel Model { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AnnounceAWBBodyResponseModel()
        {

        }

        #endregion
    }
}
