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
    [XmlType(TypeName = "Envelope", Namespace = KronosExpressConstants.SoapNamespace)]
    [XmlRoot(Namespace = KronosExpressConstants.SoapNamespace, IsNullable = false)]
    public class EnvelopeRequestModel<TBody, T>
        where TBody : class, IBody<T>
        where T : class
    {
        #region Public Properties

        /// <summary>
        /// The response of the call for getting the announcement of waybills to Kronos Express system, provided that the customer makes available the AWB
        /// </summary>
        [XmlElement(ElementName = "Header", Namespace = KronosExpressConstants.SoapNamespace)]
        public HeaderRequestModel Header { get; set; }

        /// <summary>
        /// The body
        /// </summary>
        [XmlElement(ElementName = "Body", Namespace = KronosExpressConstants.SoapNamespace)]
        public TBody Body { get; set; }

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
