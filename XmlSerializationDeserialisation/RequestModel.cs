using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XmlSerializationDeserialisation
{
    [XmlRoot("Request")]
    public class RequestModel
    {
        [XmlElement("comment")]
        public string Comment { get; set; }
        [XmlElement("type_code")]
        public string Type_code { get; set; }
        [XmlElement("pri_tran_code")]
        public string Pri_tran_code { get; set; }
        [XmlElement("sec_tran_code")]
        public string Sec_tran_code { get; set; }
        [XmlElement("term_type")]
        public string Term_type { get; set; }
        [XmlElement("bin")]
        public string Bin { get; set; }
        [XmlElement("cardholder")]
        public string Cardholder { get; set; }
        [XmlElement("member")]
        public string Member { get; set; }
        [XmlElement("pin")]
        public string Pin { get; set; }
        [XmlElement("terminal_id")]
        public string Terminal_id { get; set; }
        [XmlElement("tp_datetime")]
        public string Tp_datetime { get; set; }
        [XmlElement("tp_seq")]
        public string Tp_seq { get; set; }
        [XmlElement("return_fields")]
        public string Return_fields { get; set; }
    }
}
