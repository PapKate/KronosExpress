﻿using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Formatters;

namespace KronosExpress
{
    public class Program
    {
        static string host = "http://courier.kronosexpress.com/EshopWS.asmx";
        static string username = "web@dsdc.gr";
        static string password = "1kt2JM49@C$t";
        static string _namespaceeshop = "https://services.kronosexpress.com/EshopWS";
        static string uniquekey = "fAtWUDDJY06iwmSUUnOSJ4LD";

        #region Pubic Methods

        public static void Main()
        {
            //DeserializeObject("Response.xml");

            SerializeObject("Request.xml");

            Console.ReadLine();
        }

        public static void SerializeObject(string filePath)
        {
            var envelope = new EnvelopeRequestModel<AnnounceAWBBodyRequestModel, AnnounceAWBRequestModel>()
            {
                Header = new HeaderRequestModel()
                {
                    AuthHeader = new AuthHeaderRequestModel()
                    {
                        Username = username,
                        Password = password,
                        Hash = "Hashhhhhhhhh"
                    }
                },
                Body = new AnnounceAWBBodyRequestModel()
                {
                    Model = new AnnounceAWBRequestModel()
                    {
                        AWB = "1234",
                        RecipientCode = "12345678",
                        RecipientName = "John",
                        RecipientSurname = "Smith",
                        RecipientAddress = "221b Baker Street",
                        RecipientPostcode = "26441",
                        RecipientCity = "London",
                        RecipientPhoneNumber = "6978010326",
                        RecipientComments = "Comments on this beautiful business card: Impressive... Very nice!",
                        WarehouseCode = "091b",
                        ParcelWeight = "0.2g",
                        ParcelQuantity = "1",
                        ParcelType = ParcelType.Envelope,
                        Services = new ServicesRequestModel()
                        {
                            ServiceClasses = new List<ServiceClassRequestModel>()
                            {
                                new ServiceClassRequestModel()
                                {
                                    ServiceCode = "12345gr",
                                    ServiceDetails = "The details of this service."
                                },
                                new ServiceClassRequestModel()
                                {
                                    ServiceCode = "12345gr",
                                    ServiceDetails = "The details of this service."
                                }
                            }
                        },
                        RecipientEmail = "john@smith.com"
                    }
                }
            };

            var mySerializer = new XmlSerializer(typeof(EnvelopeRequestModel<AnnounceAWBBodyRequestModel, AnnounceAWBRequestModel>));

            var xmlNameSpace = new XmlSerializerNamespaces();
            xmlNameSpace.Add("soap12", KronosExpressConstants.EnvelopeNamespace);
            xmlNameSpace.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            xmlNameSpace.Add("xsd", "https://www.w3.org/2001/XMLSchema");

            // Opens the file
            var myFileStream = new FileStream(filePath, FileMode.Truncate);
            mySerializer.Serialize(myFileStream, envelope, xmlNameSpace);

            Console.WriteLine("serialized");
        }

        /// <summary>
        /// Deserializes a soap API envelope type
        /// </summary>
        /// <param name="filePath">The file path</param>
        public static void DeserializeObject(string filePath)
        {
            EnvelopeResponseModel<AnnounceAWBBodyResponseModel, AnnounceAWBResponseModel> envelope;

            // Creates a new XML serializer of type envelope
            var mySerializer = new XmlSerializer(typeof(EnvelopeResponseModel<AnnounceAWBBodyResponseModel, AnnounceAWBResponseModel>));

            // Opens the file
            var myFileStream = new FileStream(filePath, FileMode.Open);

            // Deserializes the stream to an envelope
            envelope = (EnvelopeResponseModel<AnnounceAWBBodyResponseModel, AnnounceAWBResponseModel>)mySerializer.Deserialize(myFileStream);

            Console.WriteLine("test");
        }

        public static void GetServices()
        {
            HttpWebRequest request = CreateWebRequest(host);
            XmlDocument soapEnvelopeXml = new XmlDocument();
            string xml = File.ReadAllText("getServicesRequest.xml").Replace("@username", username).Replace("@password", Sha(password));
            var hash = Sha(xml + uniquekey);
            xml = xml.Replace("<Hash></Hash>", "<Hash>" + hash.Trim() + "</Hash>");
            soapEnvelopeXml.LoadXml(xml);
            using (Stream stream = request.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader rd = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    string soapResult = rd.ReadToEnd();
                    XmlDocument document = new XmlDocument();
                    document.LoadXml(soapResult); //loading soap message as string 
                    XmlNamespaceManager manager = new
                    XmlNamespaceManager(document.NameTable);
                    manager.AddNamespace("res", _namespaceeshop);
                    XmlNodeList xnList = document.SelectNodes("//res:ServicesClass", manager);
                    int nodes = xnList.Count;
                    List<TrackAndTraceClassResponseModel> obj = new List<TrackAndTraceClassResponseModel>();
                    foreach (XmlNode xn in xnList)
                    {
                        var code = xn["Code"].InnerText;
                        var description = xn["Description"].InnerText;
                    }
                }
            }
        }
        public static string Sha(string value)
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] hashValue;
            byte[] message = UE.GetBytes(value);
            SHA256Managed hashString = new SHA256Managed();
            string hex = "";
            hashValue = hashString.ComputeHash(message);
            foreach (byte x in hashValue)
            {
                hex += string.Format("{0:x2}", x);
            }
            return hex;
        }

        public static HttpWebRequest CreateWebRequest(string url)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Headers.Add(@"SOAP:Action");
            webRequest.ContentType = "text/xml; charset=utf-8";
            webRequest.Method = "POST";
            return webRequest;
        }


        #endregion
    }
    }