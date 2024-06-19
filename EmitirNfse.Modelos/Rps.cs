using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Configuration;
using System.ComponentModel.DataAnnotations;

namespace EmitirNfse.Modelos
{
    [Serializable()]
    public class Rps
    {
        public Rps()
        {
            infRps = new List<Modelos.InfRps>();
        }

        [XmlElement(ElementName = "InfRps")]
        public List<Modelos.InfRps> infRps
        {
            get;
            set;
        }
    }
    [Serializable()]
    public class IdentificacaoPrestador
    {
        public IdentificacaoPrestador()
        {
            this.CNPJ = ConfigurationManager.AppSettings["CNPJPrestador"];
            this.InscricaoMunicipal = Convert.ToInt32(ConfigurationManager.AppSettings["InscMunicipal"]);
        }

        [XmlElement(ElementName = "Cnpj")]
        public string CNPJ
        {
            get;
            set;
        }

        [XmlElement(ElementName = "InscricaoMunicipal")]
        public int InscricaoMunicipal
        {
            get;
            set;
        }
    }

    [Serializable()]
    [Table("InfoRps")]
    public class InfRps
    {
        public InfRps()
        {
            this.IdentificacaoRps = new IdentificacaoRPS();
            RpsSubstituido = new IdentificacaoRPS();
            Servico = new List<DadosServicos>();
            PrestadorServico = new List<IdentificacaoPrestador>();
            TomadorServico = new List<TomadorServico>();
        }

        [XmlAttribute(AttributeName = "Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("InfoRpsId")]
        public int Id
        {
            get;
            set;
        }

        [XmlElement("IdentificacaoRps")]
        [NotMapped]
        public Modelos.IdentificacaoRPS IdentificacaoRps
        {
            get;
            set;
        }

        [NotMapped]
        public string DataEmissao
        {
            get;
            set;
        }

        [NotMapped]
        public int NaturezaOperacao
        {
            get;
            set;
        }

        [NotMapped]
        public int OptanteSimplesNacional
        {
            get;
            set;
        }

        [NotMapped]
        public int IncentivadorCultural
        {
            get;
            set;
        }

        [NotMapped]
        public int Status
        {
            get;
            set;
        }

        [NotMapped]
        [XmlElement("RpsSubstituido")]
        public Modelos.IdentificacaoRPS RpsSubstituido
        {
            get;
            set;
        }

        [XmlElement("Servico")]
        [NotMapped]
        public List<Modelos.DadosServicos> Servico
        {
            get;
            set;
        }

        [XmlElement("Prestador")]
        [NotMapped]
        public List<Modelos.IdentificacaoPrestador> PrestadorServico
        {
            get;
            set;
        }

        [XmlElement("Tomador")]
        [NotMapped]
        public List<Modelos.TomadorServico> TomadorServico
        {
            get;
            set;
        }

        [XmlIgnore]
        public int RpsIdentNumero
        {
            get;
            set;
        }

        [XmlIgnore]
        public int LoteRpsId
        {
            get;
            set;
        }
    }

    [Serializable()]
    [Table("Rps")]
    public class IdentificacaoRPS
    {
        public IdentificacaoRPS()
        { 
            this.Numero = 0;
            this.Serie = "F";
            this.Tipo = 1;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("RpsNumero")]
        public int Numero
        {
            get;
            set;
        }

        [Column("RpsSerie")]
        public string Serie
        {
            get;
            set;
        }

        [Column("RpsTipo")]
        public int Tipo
        {
            get;
            set;
        }

        [XmlIgnore]
        [Column("RpsProtocolo")]
        public string Protocolo
        {
            get;
            set;
        }

        [XmlIgnore]
        [Column("EmpresaId")]
        public int EmpresaId
        {
            get;
            set;
        }

        [XmlIgnore]
        [Column("RpsStatus")]
        public int status
        {
            get;
            set;
        }

        [XmlIgnore]
        [Column("RpsMensagemRetorno")]
        public string Mensagem
        {
            get;
            set;
        }

        [XmlIgnore]
        [Column("RpsValor")]
        public decimal Valor
        {
            get;
            set;
        }

        //[XmlIgnore]
        //public virtual ICollection<Modelos.Empresas> Empresa
        //{
        //    get;
        //    set;
        //}
        //[XmlIgnore]
        //public virtual ICollection<Modelos.InfNfse> Nfse
        //{
        //    get;
        //    set;
        //}
    }
}
