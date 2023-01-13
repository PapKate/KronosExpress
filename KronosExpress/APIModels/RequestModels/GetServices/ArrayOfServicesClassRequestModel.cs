using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KronosExpress
{
    public class ArrayOfServicesClassRequestModel
    {
        #region Public Properties

        /// <summary>
        /// A list containing all the services
        /// </summary>
        [XmlElement(ElementName = "ServicesClass")]
        public IEnumerable<ServicesClassRequestModel> ServicesClasses { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ArrayOfServicesClassRequestModel()
        {

        }

        #endregion
    }
}
