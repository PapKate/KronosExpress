using System.Xml.Serialization;

namespace KronosExpress
{
    public class PrintLabelResultResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The image of the waybill
        /// </summary>
        [XmlElement(ElementName = "base64Binary")]
        public string Image { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PrintLabelResultResponseModel()
        {

        }

        #endregion
    }
}
