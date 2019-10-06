using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XmlSerializationDeserialisation
{
    [XmlRoot("Response")]
    public class ResponseModel
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
        //        <request>
        //<comment>PIN Validation</comment>
        //<type_code>0010</type_code>
        //<pri_tran_code>PIN</pri_tran_code>
        //<sec_tran_code>VER</sec_tran_code>
        //<term_type>IVR</term_type>
        //<bin>123456</bin>
        //<cardholder>7890123456</cardholder>
        //<member>00</member>
        //<pin>0123456789ABCDEF</pin>
        //<terminal_id>Varchar 15</terminal_id>
        //<tp_datetime>YYYYMMDDHHMMSS</tp_datetime>
        //<tp_seq>123456</tp_seq>
        //<return_fields>void_code</return_fields>
        //</request>
    }
}
