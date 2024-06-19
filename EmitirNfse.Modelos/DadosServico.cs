using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace EmitirNfse.Modelos
{
    [Serializable()]
    public class DadosServicos
    {
        public DadosServicos()
        {
            Valores = new Valores();
            this.CodigoMunicipio = ConfigurationManager.AppSettings["CodigoMunicipio"];
            this.CodigoTributacaoMunicipio = "01.07.00";
        }

        public Valores Valores
        {
            get;
            set;
        }

        public string ItemListaServico
        {
            get;
            set;
        }

        public string CodigoCnae
        {
            get;
            set;
        }

        public string CodigoTributacaoMunicipio
        {
            get;
            set;
        }

        public string Discriminacao
        {
            get;
            set;
        }

        public string CodigoMunicipio
        {
            get;
            set;
        }


    }
}
