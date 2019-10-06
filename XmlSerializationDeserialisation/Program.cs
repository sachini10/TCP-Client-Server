using System;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using System.Xml;

namespace XmlSerializationDeserialisation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            try {
                RequestModel request = new RequestModel {
                    Comment="PIN Validation",
        Type_code="0010",
        Pri_tran_code="PIN",
        Sec_tran_code="VER",
       Term_type= "IVR",
        Bin="123456",
        Cardholder="7890123456",
        Member="00",
        Pin="0123456789ABCDEF",
        Terminal_id="Varchar 15",
       Tp_datetime="YYYYMMDDHHMMSS",
       Tp_seq="123456",
        Return_fields="void_code"
                };

                XmlSerializer serializer = new XmlSerializer(typeof(RequestModel));
                StringBuilder xml = new StringBuilder();
                StringWriter text = new StringWriter(xml);
               serializer.Serialize(text, request);
                Console.WriteLine(xml.ToString());

                string requestXml = xml.ToString();

                XmlDocument xDoc = new XmlDocument();

                xDoc.LoadXml(requestXml);

                XmlNodeReader xNodeReader = new XmlNodeReader(xDoc.DocumentElement);

                XmlSerializer xmlSerializer1 = new XmlSerializer(typeof(RequestModel));

                var requestData = xmlSerializer1.Deserialize(xNodeReader);

                RequestModel deserializedRequest = (RequestModel)requestData;
                Console.WriteLine(deserializedRequest.ToString());
                var x = deserializedRequest.Type_code;
                Console.WriteLine(x);

            }
            catch(Exception e) {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
