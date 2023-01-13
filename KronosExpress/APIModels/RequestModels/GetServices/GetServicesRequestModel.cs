using System.Xml.Serialization;

namespace KronosExpress
{
    public class GetServicesRequestModel
    {
        #region Public Properties

        /// <summary>
        /// A list containing all the services
        /// </summary>
        [XmlElement(ElementName = "ArrayOfServicesClass")]
        public ArrayOfServicesClassRequestModel ArrayOfServicesClass { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public GetServicesRequestModel()
        {

        }

        #endregion
    }
}
