using System.Xml.Serialization;
namespace KronosExpress
{
    public class Program
    {
        #region Pubic Methods

        public static void Main()
        {
            DeserializeObject("Response.xml");

            Console.ReadLine();
        }

        /// <summary>
        /// Deserializes a soap API envelope type
        /// </summary>
        /// <param name="filePath">The file path</param>
        public static void DeserializeObject(string filePath)
        {
            EnvelopeResponseModel envelope;
            // Creates a new XML serializer of type envelope
            var mySerializer = new XmlSerializer(typeof(EnvelopeResponseModel));

            //  
            var myFileStream = new FileStream(filePath, FileMode.Open);

            // Deserializes the stream to an envelope
            envelope = (EnvelopeResponseModel)mySerializer.Deserialize(myFileStream);

            Console.WriteLine("test");
        }

        #endregion
    }
}