using System.Xml.Serialization;

namespace KronosExpress
{
    public class ArrayOfGetSettlementObjectRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The objects
        /// </summary>
        [XmlElement(ElementName = "GetSettlementObject")]
        public IEnumerable<GetSettlementObjectRequestModel> GetSettlementObjects { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ArrayOfGetSettlementObjectRequestModel()
        {

        }

        #endregion
    }
}
