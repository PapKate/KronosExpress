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
    public class EnvelopeResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The body
        /// </summary>
        [XmlElement(ElementName = "Body")]
        public BodyResponseModel Body { get; set; }

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
