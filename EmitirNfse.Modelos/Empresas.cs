using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Data.Entity;

namespace EmitirNfse.Modelos
{
    public class Empresas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [XmlIgnore]
        public int EmpresaId
        {
            get;
            set;
        }

        [Column("EmpresaRazaoSocial")]
        [XmlElement("RazaoSocial")]
        public string RazaoSocial
        {
            get;
            set;
        }

        [Column("EmpresaCNPJCPF")]
        [XmlElement("CpfCnpj")]
        public string CNPJ
        {
            get;
            set;
        }

        [Column("EmpresaIE")]
        [XmlIgnore]
        public string InscrEstadual
        {
            get;
            set;
        }

        [Column("EmpresaInscMunicipal")]
        [XmlElement("InscricaoMunicipal")]
        public string InscrMunicipal
        {
            get;
            set;
        }

        [Column("EmpresaNomeResponsavel")]
        [XmlIgnore]
        public string NomeResponsavel
        {
            get;
            set;
        }

        #region Endereco
        [Column("EmpresaLogradouro")]
        [XmlElement("Endereco")]
        public string EnderecoLog
        {
            get;
            set;
        }

        [Column("EmpresaNroEndereco")]
        [XmlElement("Numero")]
        public string EnderecoNro
        {
            get;
            set;
        }

        [Column("EmpresaComplEnd")]
        [XmlElement("Complemento")]
        public string EnderecoComplemento
        {
            get;
            set;
        }

        [Column("EmpresaBairro")]
        [XmlElement("Bairro")]
        public string EnderecoBairro
        {
            get;
            set;
        }

        [XmlElement("CodigoMunicipio")]
        public int? CodigoCidade
        {
            get;
            set;
        }

        [Column("EmpresaUF")]
        [XmlElement("Uf")]
        public string EnderecoUF
        {
            get;
            set;
        }

        [Column("EmpresaCep")]
        [XmlElement("Cep")]
        public string EnderecoCEP
        {
            get;
            set;
        }

        [Column("EmpresaCidade")]
        [XmlIgnore]
        public string EnderecoCidade
        {
            get;
            set;
        }

        #endregion

        #region Contato
        [Column("EmpresaFonePrincipal")]
        [XmlElement("Telefone")]
        public string Telefone
        {
            get;
            set;
        }

        [Column("EmpresaEmail")]
        [XmlElement("Email")]
        public string Email
        {
            get;
            set;
        }
        #endregion

        //[XmlIgnore]
        //public virtual ICollection<Modelos.InfNfse> Nfse
        //{
        //    get;
        //    set;
        //}

        //[XmlIgnore]
        //public virtual ICollection<Modelos.IdentificacaoRPS> Rps
        //{
        //    get;
        //    set;
        //}
    }

    [Serializable()]
    [XmlRoot("CpfCnpj")]
    public class CpfCnpj
    {
        public string Cpf
        {
            get;
            set;
        }

        public string Cnpj
        {
            get;
            set;
        }
    }

    [Serializable()]
    [XmlRoot(ElementName = "Tomador")]
    [NotMapped]
    public class TomadorServico
    {
        public TomadorServico()
        {
            Endereco = new Endereco();
            Contato = new Conato();
        }
        public TomadorServico(Modelos.Empresas empresa)
        {
            Endereco = new Endereco();
            Contato = new Conato();
            tomador = new IdentificacaoTomador();

            if (empresa.CNPJ.Length == 14)
                tomador.CpfCnpj.Cnpj = empresa.CNPJ;
            else
                tomador.CpfCnpj.Cpf = empresa.CNPJ;
            tomador.InscricaoMunicipal = string.IsNullOrEmpty(empresa.InscrMunicipal) == true ? null : empresa.InscrMunicipal;
            this.RazaoSocial = empresa.RazaoSocial;
            this.Endereco.Bairro = empresa.EnderecoBairro;
            this.Endereco.Cep = empresa.EnderecoCEP;
            this.Endereco.CodigoMunicipio = empresa.CodigoCidade.ToString();
            this.Endereco.endereco = empresa.EnderecoLog;
            this.Endereco.Numero = empresa.EnderecoNro.Trim();
            this.Endereco.Uf = empresa.EnderecoUF;
            this.Contato.Telefone = empresa.Telefone;
            this.Contato.Email = empresa.Email;
        }
        [XmlElement(ElementName = "IdentificacaoTomador")]
        public IdentificacaoTomador tomador
        {
            get;
            set;
        }

        public string RazaoSocial
        {
            get;
            set;
        }

        [XmlElement(ElementName = "Endereco")]
        public Endereco Endereco
        {
            get;
            set;
        }

        [XmlElement(ElementName = "Contato")]
        public Conato Contato
        {
            get;
            set;
        }
    }

    [Serializable()]
    [XmlRoot("IdentificacaoTomador")]
    [NotMapped]
    public class IdentificacaoTomador
    {
        public IdentificacaoTomador()
        {
            CpfCnpj = new CpfCnpj();
        }

        [XmlElement(ElementName = "CpfCnpj")]
        public CpfCnpj CpfCnpj
        {
            get;
            set;
        }

        public string InscricaoMunicipal
        {
            get;
            set;
        }
    }

    [Serializable()]
    [XmlRoot(ElementName = "Endereco")]
    [NotMapped]
    public class Endereco
    {
        [XmlElement(ElementName = "Endereco")]
        public string endereco
        {
            get;
            set;
        }

        public string Numero
        {
            get;
            set;
        }

        public string Bairro
        {
            get;
            set;
        }

        public string CodigoMunicipio
        {
            get;
            set;
        }

        public string Uf
        {
            get;
            set;
        }

        public string Cep
        {
            get;
            set;
        }
    }

    [Serializable()]
    [XmlRoot(ElementName = "Contato")]
    [NotMapped]
    public class Conato
    {
        public string Telefone
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }
    }
}
