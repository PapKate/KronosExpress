using System.Xml.Serialization;

namespace KronosExpress
{
    public class ServicesClassResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The service code
        /// The services are 2Door , COD , Pickup & Delivery etc
        /// </summary>
        [XmlElement(ElementName = "Code")]
        public string Code { get; set; }

        /// <summary>
        /// The service description
        /// </summary>
        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicesClassResponseModel()
        {

        }

        #endregion
    }
}
