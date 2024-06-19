using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace EmitirNfse.Modelos
{
    [Table("Nfse")]
    public class InfNfse
    {
        [Key]
        [Column("NfseNumero")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero
        {
            get;
            set;
        }

        [Column("NfseCodVerifica")]
        public string CodigoVerificacao
        {
            get;
            set;
        }

        [Column("NfseDataEmissao")]
        public DateTime DataEmissao
        {
            get;
            set;
        }

        [Column("NfseNatOperacao")]
        public int NaturezaOperacao
        {
            get;
            set;
        }

        [Column("NfseOptaSimplesNac")]
        public int OptanteSimplesNacional
        {
            get;
            set;
        }

        [Column("NfseIncetivaCult")]
        public int IncetivadorCultural
        {
            get;
            set;
        }

        [Column("NfseCompetencia")]
        public int Competencia
        {
            get;
            set;
        }

        [Column("RpsNumero")]
        public int RpsNumero
        {
            get;
            set;
        }

        [Column("NfseItem")]
        public string ItemListaServico
        {
            get;
            set;
        }

        [Column("NfseItemDescricao")]
        public string Discriminacao
        {
            get;
            set;
        }

        /// <summary>
        /// Valor do bruto do serviço
        /// </summary>
        [Column("NfseValorServico")]
        public decimal ValorServicos
        {
            get;
            set;
        }

        /// <summary>
        /// Valor das deduções
        /// </summary>
        [Column("NfseValorDeducoes")]
        public decimal ValorDeducoes
        {
            get;
            set;
        }

        /// <summary>
        /// Valor do Pis calculado. Somente será calculado caso o valor da nota fiscal seja superior a R$ 5.000,00.
        /// Também será calculado caso o tomador tenha um valor superior a R$ 5.000,00 faturado no mesmo período.
        /// </summary>
        [Column("NfseValorPis")]
        public decimal ValorPis
        {
            get;
            set;
        }

        /// <summary>
        /// Valor do Cofins calculado. Somente será calculado caso o valor da nota fiscal seja superior a R$ 5.000,00.
        /// Também será calculado caso o tomador tenha um valor superior a R$ 5.000,00 faturado no mesmo período.
        /// </summary>
        [Column("NfseValorCofins")]
        public decimal ValorCofins
        {
            get;
            set;
        }

        /// <summary>
        /// Valor do INSS calculado. Somente será calculado caso o valor da nota fiscal seja superior a R$ 5.000,00.
        /// Também será calculado caso o tomador tenha um valor superior a R$ 5.000,00 faturado no mesmo período.
        /// </summary>
        [Column("NfseValorInss")]
        public decimal ValorInss
        {
            get;
            set;
        }

        /// <summary>
        /// Valor do IR calculado. Somente será calculado caso o valor da nota fiscal seja superior a R$ 650,00.
        /// Também será calculado caso o tomador tenha um valor superior a R$ 5.000,00 faturado no mesmo período.
        /// </summary>
        [Column("NfseValorIr")]
        public decimal ValorIr
        {
            get;
            set;
        }

        /// <summary>
        /// Valor do CSLL calculado. Somente será calculado caso o valor da nota fiscal seja superior a R$ 5.000,00.
        /// Também será calculado caso o tomador tenha um valor superior a R$ 5.000,00 faturado no mesmo período.
        /// </summary>
        [Column("NfseValorCsll")]
        public decimal ValorCsll
        {
            get;
            set;
        }

        /// <summary>
        /// Indica se o o valor do ISS será retido pela prestadora de serviço.
        /// </summary>
        [Column("NfseIssRetido")]
        public int IssRetido
        {
            get;
            set;
        }

        /// <summary>
        /// Indica o valor do ISS.
        /// </summary>
        [Column("NfseValorIss")]
        public decimal ValorIss
        {
            get;
            set;
        }

        /// <summary>
        /// Valor de retenção do ISS
        /// </summary>
        [Column("NfseValorIssRetido")]
        public decimal ValorIssRetido
        {
            get;
            set;
        }

        /// <summary>
        /// Valor de outras retenções efeutadas durante a operação fiscal.
        /// </summary>
        [Column("NfseOutrasRetencoes")]
        public decimal OutrasRetencoes
        {
            get;
            set;
        }

        /// <summary>
        /// Valor da Base de Cálculo dos impostos.
        /// ValorServicos - (ValorDeducoes + DescontoIncondicionado)
        /// </summary>
        [Column("NfseBaseCalculo")]
        public decimal BaseCalculo
        {
            get;
            set;
        }

        /// <summary>
        /// Alíquota do ISS
        /// </summary>
        [Column("NfseAliquotaIss")]
        public decimal Aliquota
        {
            get;
            set;
        }

        /// <summary>
        /// Valor líquido da Nota fiscal, já deduzido as retenções e descontos
        /// ValorServicos - (ValorPis + ValorCofins + ValorCsll + ValorInss + ValorIr + OutrasRetencoes + ValorIssRetido
        /// + DescontoCondicionado + DescontoIncondicionado);
        /// </summary>
        [Column("NfseValorLiquido")]
        public decimal ValorLiquidoNfse
        {
            get;
            set;
        }

        [Column("NfseDescontoIncondicionado")]
        public decimal DescontoIncondicionado
        {
            get;
            set;
        }

        [Column("NfseDescontoCondicionado")]
        public decimal DescontoCondicionado
        {
            get;
            set;
        }

        [Column("EmpresaId")]
        public int EmpresaId
        {
            get;
            set;
        }

        [Column("NfseStatus")]
        public int StatusNfse
        {
            get;
            set;
        }

        //[XmlIgnore]
        //public virtual ICollection<Modelos.Empresas> Empresas
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

    public enum EnumStatusNfse
    {
        Normal = 1,
        Cancelada = 2,
        Substituida = 3
    }
}
