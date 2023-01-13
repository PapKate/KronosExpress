using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KronosExpress
{
    public class GetSettlementsRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The array with the objects
        /// </summary>
        [XmlElement(ElementName = "ArrayOfGetSettlementObject")]
        public ArrayOfGetSettlementObjectRequestModel ArrayOfGetSettlementObject { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public GetSettlementsRequestModel()
        {

        }

        #endregion
    }
}
