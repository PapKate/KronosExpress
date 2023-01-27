using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KronosExpress
{
    [XmlType(AnonymousType = true, Namespace = KronosExpressConstants.SoapNamespace)]
    public class HeaderRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The response of the call for getting the announcement of waybills to Kronos Express system, provided that the customer makes available the AWB
        /// </summary>
        [XmlElement(ElementName = "AuthHeader", Namespace = KronosExpressConstants.KronosExpressNamespace)]
        public AuthHeaderRequestModel AuthHeader { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public HeaderRequestModel()
        {

        }

        #endregion
    }
}
