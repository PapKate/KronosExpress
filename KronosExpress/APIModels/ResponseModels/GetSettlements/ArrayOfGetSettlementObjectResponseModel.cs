using System.Xml.Serialization;

namespace KronosExpress
{
    public class ArrayOfGetSettlementObjectResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The objects
        /// </summary>
        [XmlElement(ElementName = "GetSettlementObject")]
        public IEnumerable<GetSettlementObjectResponseModel> GetSettlementObjects { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ArrayOfGetSettlementObjectResponseModel()
        {

        }

        #endregion
    }
}
