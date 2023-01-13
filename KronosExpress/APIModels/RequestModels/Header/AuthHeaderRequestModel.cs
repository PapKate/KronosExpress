using System.Xml.Serialization;

namespace KronosExpress
{
    /// <summary>
    /// The authentication header
    /// </summary>
    public class AuthHeaderRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The username
        /// REQUIRED
        /// </summary>
        [XmlElement(ElementName = "UserName")]
        public string Username { get; set; }

        /// <summary>
        /// The password
        /// REQUIRED
        /// </summary>
        [XmlElement(ElementName = "Password")]
        public string Password { get; set; }

        /// <summary>
        /// The hashed password 
        /// REQUIRED
        /// </summary>
        [XmlElement(ElementName = "Hash")]
        public string Hash { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AuthHeaderRequestModel() : base()
        {

        }

        #endregion
    }
}
