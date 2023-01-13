using System.Xml.Serialization;

namespace KronosExpress
{
    /// <summary>
    /// AnnounceCreateAWB operation allows the announcement of waybills to Kronos Express system, 
    /// provided that the customer does not make available the AWB.
    /// </summary>
    public class AnnounceCreateAWBRequestModel
    {
        #region Public Properties

        /// <summary>
        /// A unique recipient code
        /// REQUIRED
        /// </summary>
        [XmlElement(ElementName = "RecipientCode")]
        public string RecipientCode { get; set; }

        /// <summary>
        /// The recipient name
        /// REQUIRED
        /// </summary>
        [XmlElement(ElementName = "RecipientName")]
        public string RecipientName { get; set; }

        /// <summary>
        /// The recipient surname
        /// REQUIRED
        /// </summary>
        [XmlElement(ElementName = "RecipientSurname")]
        public string RecipientSurname { get; set; }

        /// <summary>
        /// The recipient email
        /// </summary>
        [XmlElement(ElementName = "RecipientEmail")]
        public string RecipientEmail { get; set; }

        /// <summary>
        /// The recipient address
        /// REQUIRED
        /// </summary>
        [XmlElement(ElementName = "RecipientAddress")]
        public string RecipientAddress { get; set; }

        /// <summary>
        /// The recipient postcode
        /// REQUIRED
        /// </summary>
        [XmlElement(ElementName = "RecipientPostcode")]
        public string RecipientPostcode { get; set; }

        /// <summary>
        /// The recipient city
        /// REQUIRED
        /// </summary>
        [XmlElement(ElementName = "RecipientCity")]
        public string RecipientCity { get; set; }

        /// <summary>
        /// The recipient phone number 
        /// REQUIRED
        /// </summary>
        [XmlElement(ElementName = "RecipientPhoneNumber")]
        public string RecipientPhoneNumber { get; set; }

        /// <summary>
        /// The comments
        /// </summary>
        [XmlElement(ElementName = "RecipientComments")]
        public string RecipientComments { get; set; }

        /// <summary>
        /// Warehouse code indicates the hub which will handle the delivery
        /// REQUIRED
        /// </summary>
        [XmlElement(ElementName = "WarehouseCode")]
        public string WarehouseCode { get; set; }

        /// <summary>
        /// The weight of the parcel. The weight must be in decimal type.e.g 5.00 and is expressed in KG. The maximum allowed value for Parcel 001 is 1 KG
        /// REQUIRED
        /// </summary>
        [XmlElement(ElementName = "ParcelWeight")]
        public string ParcelWeight { get; set; }

        /// <summary>
        /// The quantity of the parcel. Should be always “1”
        /// REQUIRED
        /// </summary>
        [XmlElement(ElementName = "ParcelQuantity")]
        public string ParcelQuantity { get; set; }

        /// <summary>
        /// The parcel type
        /// REQUIRED
        /// </summary>
        [XmlElement(ElementName = "ParcelType")]
        public ParcelType ParcelType { get; set; }

        /// <summary>
        /// The services
        /// </summary>
        [XmlElement(ElementName = "Services")]
        public ServicesRequestModel Services { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AnnounceCreateAWBRequestModel() : base()
        {

        }

        #endregion
    }
}
