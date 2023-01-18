using System.Xml.Serialization;

namespace KronosExpress
{
    /// <summary>
    /// The envelope
    /// </summary>
    [XmlType(TypeName = "Envelope", Namespace = KronosExpressConstants.EnvelopeNamespace)]
    [XmlRoot(Namespace = KronosExpressConstants.EnvelopeNamespace, IsNullable = false)]
    public class EnvelopeResponseModel<TBody, T>
        where TBody : class, IBodyResponseModel<T>
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
