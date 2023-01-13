using System.Xml.Serialization;

namespace KronosExpress
{
    public class GetServicesResultResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The services
        /// </summary>
        [XmlElement(ElementName = "ServicesClass")]
        public IEnumerable<ServicesClassResponseModel> ServicesClass { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public GetServicesResultResponseModel()
        {

        }

        #endregion
    }
}
