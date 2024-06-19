using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using System.Configuration;

namespace EmitirNfse.Modelos
{
    [Serializable()]
    [Table("LoteRps")]
    public class LoteRps
    {
        public LoteRps()
        {
            this.InscricaoMunicipal = ConfigurationManager.AppSettings["InscMunicipal"];
            this.CNPJ = ConfigurationManager.AppSettings["CNPJPrestador"];
            this.id = 1;
            ListaRps = new List<Modelos.Rps>();
            xmlns = new XmlSerializerNamespaces();
            xmlns.Add("", "http://www.ginfes.com.br/servico_enviar_lote_rps_envio_v03.xsd");
        }

        [XmlNamespaceDeclarations()]
        public XmlSerializerNamespaces xmlns;


        [XmlAttribute("Id")]
        [Key]
        [Column("LoteRpsId")]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.DatabaseGeneratedOption.None)]
        public int id
        {
            get;
            set;
        }

        [XmlElement(ElementName = "NumeroLote", Namespace = "http://www.ginfes.com.br/tipos_v03.xsd")]
        [Column("LoteRpsNumero")]
        public int NumeroLote
        {
            get;
            set;
        }

        [XmlElement(ElementName = "Cnpj", Namespace = "http://www.ginfes.com.br/tipos_v03.xsd")]
        [Column("LoteRpsCNPJ")]
        public string CNPJ
        {
            get;
            set;
        }

        [XmlElement(ElementName = "InscricaoMunicipal", Namespace = "http://www.ginfes.com.br/tipos_v03.xsd")]
        [Column("LoteRpsInscMunic")]
        public string InscricaoMunicipal
        {
            get;
            set;
        }

        [XmlElement(ElementName = "QuantidadeRps", Namespace = "http://www.ginfes.com.br/tipos_v03.xsd")]
        [Column("LoteRpsQtd")]
        public int QuantidadeRps
        {
            get;
            set;
        }

        [XmlArray(ElementName = "ListaRps", Namespace = "http://www.ginfes.com.br/tipos_v03.xsd")]
        [NotMapped]
        public List<Modelos.Rps> ListaRps
        {
            get;
            set;
        }

    }
    [Serializable()]
    [XmlRoot(ElementName = "EnviarLoteRpsEnvio", Namespace = "http://www.ginfes.com.br/servico_enviar_lote_rps_envio_v03.xsd")]
    public class EnviarLoteRpsEnvio
    {
        public EnviarLoteRpsEnvio()
        {
            LoteRps = new List<Modelos.LoteRps>();
            xmlns = new XmlSerializerNamespaces();
            xmlns.Add("", "http://www.ginfes.com.br/servico_enviar_lote_rps_envio_v03.xsd");
        }
        [XmlNamespaceDeclarations()]
        public XmlSerializerNamespaces xmlns;

        [XmlElement(ElementName = "LoteRps")]
        public List<Modelos.LoteRps> LoteRps
        {
            get;
            set;
        }
    }
}
