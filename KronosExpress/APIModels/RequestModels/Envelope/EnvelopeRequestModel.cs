using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KronosExpress
{
    /// <summary>
    /// The envelope
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = KronosExpressConstants.EnvelopeNamespace)]
    [XmlRoot(Namespace = KronosExpressConstants.EnvelopeNamespace, IsNullable = false)]
    public class EnvelopeRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The response of the call for getting the announcement of waybills to Kronos Express system, provided that the customer makes available the AWB
        /// </summary>
        [XmlElement(ElementName = "AuthHeader", Namespace = KronosExpressConstants.KronosExpressNamespace)]
        public AuthHeaderRequestModel Header { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public EnvelopeRequestModel()
        {

        }

        #endregion
    }
}
