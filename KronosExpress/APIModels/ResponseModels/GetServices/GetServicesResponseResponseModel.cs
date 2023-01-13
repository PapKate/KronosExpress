using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KronosExpress
{
    public class GetServicesResponseResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The result 
        /// </summary>
        [XmlElement(ElementName = "GetServicesResult")]
        public GetServicesResultResponseModel GetServicesResult { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public GetServicesResponseResponseModel()
        {

        }

        #endregion
    }
}
