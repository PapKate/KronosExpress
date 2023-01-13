using System.Xml.Serialization;

namespace KronosExpress
{
    /// <summary>
    /// The services
    /// </summary>
    public class ServicesRequestModel
    {
        #region Public Properties
        /// <summary>
        /// The services
        /// </summary>
        [XmlElement(ElementName = "ServicesClassAWB")]
        public IEnumerable<ServiceClassRequestModel> ServiceClasses { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicesRequestModel() : base()
        {

        }

        #endregion
    }
}
