using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmitirNfse.Modelos
{
    [Serializable()]
    public class Valores
    {
        /// <summary>
        /// Valor do bruto do serviço
        /// </summary>
        public decimal ValorServicos
        {
            get;
            set;
        }

        /// <summary>
        /// Valor das deduções
        /// </summary>
        public decimal ValorDeducoes
        {
            get;
            set;
        }

        /// <summary>
        /// Valor do Pis calculado. Somente será calculado caso o valor da nota fiscal seja superior a R$ 5.000,00.
        /// Também será calculado caso o tomador tenha um valor superior a R$ 5.000,00 faturado no mesmo período.
        /// </summary>
        public decimal ValorPis
        {
            get;
            set;
        }

        /// <summary>
        /// Valor do Cofins calculado. Somente será calculado caso o valor da nota fiscal seja superior a R$ 5.000,00.
        /// Também será calculado caso o tomador tenha um valor superior a R$ 5.000,00 faturado no mesmo período.
        /// </summary>
        public decimal ValorCofins
        {
            get;
            set;
        }

        /// <summary>
        /// Valor do INSS calculado. Somente será calculado caso o valor da nota fiscal seja superior a R$ 5.000,00.
        /// Também será calculado caso o tomador tenha um valor superior a R$ 5.000,00 faturado no mesmo período.
        /// </summary>
        public decimal ValorInss
        {
            get;
            set;
        }

        /// <summary>
        /// Valor do IR calculado. Somente será calculado caso o valor da nota fiscal seja superior a R$ 650,00.
        /// Também será calculado caso o tomador tenha um valor superior a R$ 5.000,00 faturado no mesmo período.
        /// </summary>
        public decimal ValorIr
        {
            get;
            set;
        }

        /// <summary>
        /// Valor do CSLL calculado. Somente será calculado caso o valor da nota fiscal seja superior a R$ 5.000,00.
        /// Também será calculado caso o tomador tenha um valor superior a R$ 5.000,00 faturado no mesmo período.
        /// </summary>
        public decimal ValorCsll
        {
            get;
            set;
        }

        /// <summary>
        /// Indica se o o valor do ISS será retido pela prestadora de serviço.
        /// </summary>
        public int IssRetido
        {
            get;
            set;
        }

        /// <summary>
        /// Indica o valor do ISS.
        /// </summary>
        public decimal ValorIss
        {
            get;
            set;
        }

        /// <summary>
        /// Valor de retenção do ISS
        /// </summary>
        public decimal ValorIssRetido
        {
            get;
            set;
        }

        /// <summary>
        /// Valor de outras retenções efeutadas durante a operação fiscal.
        /// </summary>
        public decimal OutrasRetencoes
        {
            get;
            set;
        }

        /// <summary>
        /// Valor da Base de Cálculo dos impostos.
        /// ValorServicos - (ValorDeducoes + DescontoIncondicionado)
        /// </summary>
        public decimal BaseCalculo
        {
            get;
            set;
        }

        /// <summary>
        /// Alíquota do ISS
        /// </summary>
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
        public decimal ValorLiquidoNfse
        {
            get;
            set;
        }

        public decimal DescontoIncondicionado
        {
            get;
            set;
        }

        public decimal DescontoCondicionado
        {
            get;
            set;
        }


    }
}
