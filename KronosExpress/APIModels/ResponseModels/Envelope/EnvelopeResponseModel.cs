using System.Xml.Serialization;

namespace KronosExpress
{
    /// <summary>
    /// The envelope
    /// </summary>
    [XmlType(TypeName = "Envelope", Namespace = KronosExpressConstants.SoapNamespace)]
    [XmlRoot(Namespace = KronosExpressConstants.SoapNamespace, IsNullable = false)]
    public class EnvelopeResponseModel<TBody, T>
        where TBody : class, IBody<T>
        where T : class
    {
        #region Public Properties

        /// <summary>
        /// The body
        /// </summary>
        [XmlElement(ElementName = "Body")]
        public TBody Body { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public EnvelopeResponseModel()
        {
                
        }

        #endregion
    }
}
