using System.Xml.Serialization;

namespace KronosExpress
{
    public class GetSettlementObjectResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The country name
        /// </summary>
        [XmlElement(ElementName = "CountryName")]
        public string CountryName { get; set; }

        /// <summary>
        /// The post code
        /// </summary>
        [XmlElement(ElementName = "PostCode")]
        public string PostCode { get; set; }

        /// <summary>
        /// The settlement name
        /// </summary>
        [XmlElement(ElementName = "SettlementName")]
        public string SettlementName { get; set; }

        /// <summary>
        /// The settlement name in Latin characters
        /// </summary>
        [XmlElement(ElementName = "SettlementNameLatin")]
        public string SettlementNameLatin { get; set; }

        /// <summary>
        /// The region name 
        /// </summary>
        [XmlElement(ElementName = "RegionName")]
        public string RegionName { get; set; }

        /// <summary>
        /// The region name in Latin characters
        /// </summary>
        [XmlElement(ElementName = "RegionNameLatin")]
        public string RegionNameLatin { get; set; }

        /// <summary>
        /// The master warehouse
        /// </summary>
        [XmlElement(ElementName = "MasterWarehouse")]
        public string MasterWarehouse { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public GetSettlementObjectResponseModel()
        {

        }

        #endregion
    }
}
