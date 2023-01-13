using System.Xml.Serialization;

namespace KronosExpress
{
    /// <summary>
    /// The body
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = KronosExpressConstants.EnvelopeNamespace)]
    public class BodyRequestModel<T>
        where T : class
    {
        #region Public Properties

        public T RequestModel { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BodyRequestModel()
        {

        }

        #endregion
    }
}
