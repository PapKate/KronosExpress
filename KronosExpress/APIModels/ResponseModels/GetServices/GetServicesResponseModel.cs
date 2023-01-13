using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KronosExpress
{
    /// <summary>
    /// Provides all the available services that can be utilized
    /// </summary>
    public class GetServicesResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The response
        /// </summary>
        [XmlElement(ElementName = "GetServicesResponse")]
        public GetServicesResponseResponseModel GetServicesResponse { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public GetServicesResponseModel()
        {

        }

        #endregion
    }
}
