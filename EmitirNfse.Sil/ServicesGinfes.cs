using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using EmitirNfse.Comuns;
using System.Xml;
using EmitirNfse;
using System.Windows.Forms;
using EmitirNfse.Dados;
using System.Globalization;

namespace EmitirNfse.Sil
{
    public static class ServicesGinfes
    {
        public static int Timeout = 10000;
        public static int nro = 0;
        public static string EnviarLoteRps(Modelos.EnviarLoteRpsEnvio EnviarLote)
        {
            Thread.Sleep(500);
            string ProtocoloRetorno = string.Empty;
            string s = Comuns.Comuns.SerializarUtf8(EnviarLote);
            XmlDocument xmlLoteRps = new XmlDocument();
            xmlLoteRps.LoadXml(s);
            xmlLoteRps.Normalize();
            xmlLoteRps = Comuns.Comuns.AssinaLoteRpsDigitalmente(xmlLoteRps);
            Comuns.Comuns.ValidaXml(xmlLoteRps);
            //xmlLoteRps.Save(string.Format(@"C:\Temp\{0}.xml", EnviarLote.LoteRps[0].ListaRps[0].infRps[0].TomadorServico[0].tomador.CpfCnpj.Cnpj));
            try
            {
                ServiceGinfesImpl.ServiceGinfesImplService EnviarNfse = new ServiceGinfesImpl.ServiceGinfesImplService();
                EnviarNfse.Timeout = Timeout;
                EnviarNfse.ClientCertificates.Add(Comuns.Comuns.LocalizaCertificadoValido());
                EnviarNfse.Proxy = Comuns.Comuns.CriarProxy();
                string str = EnviarNfse.RecepcionarLoteRpsV3(Comuns.Comuns.CriarCabecalho().InnerXml, xmlLoteRps.InnerXml);
                XmlDocument xmlretorno = new XmlDocument();
                xmlretorno.LoadXml(str);
                if (str.Contains("ns3:Protocolo"))
                {
                    ProtocoloRetorno = Comuns.Comuns.RecuperaTextoTagXml(xmlretorno, "ns3:Protocolo");
                }
                else
                {
                    ProtocoloRetorno = "Erro :" + xmlretorno.InnerText;
                }
            }
            catch (Exception ex)
            {
                //xmlLoteRps.Save(string.Format(@"C:\Temp\ErroImportarFaturamento\{0}.xml", EnviarLote.LoteRps[0].ListaRps[0].infRps[0].TomadorServico[0].tomador.CpfCnpj.Cnpj));
                //MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw ex;
            }
            return ProtocoloRetorno;
        }

        public static XmlDocument ConsultaDeLote(int Protocolo)
        {
            Thread.Sleep(1000);
            XmlDocument xmlCabecalho = Comuns.Comuns.CriarCabecalho();
            XmlDocument xmlConsulta = Comuns.Comuns.CriarXmlConsultaLote(Protocolo);
            XmlDocument x = Comuns.Comuns.AssinaXmlDigitalmente(xmlConsulta);
            string RetornoConsulta = string.Empty;
            try
            {
                ServiceGinfesImpl.ServiceGinfesImplService consultar = new ServiceGinfesImpl.ServiceGinfesImplService();
                consultar.ClientCertificates.Add(Comuns.Comuns.LocalizaCertificadoValido());
                consultar.Proxy = Comuns.Comuns.CriarProxy();
                RetornoConsulta = consultar.ConsultarLoteRpsV3(xmlCabecalho.InnerXml, x.InnerXml);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            XmlDocument XmlRetornoConsulta = new XmlDocument();
            XmlRetornoConsulta.LoadXml(RetornoConsulta);
            XmlRetornoConsulta.Save(string.Format(@"c:\temp\{0}.xml", Protocolo.ToString()));
            //Adiciona um elemento ao xml de retorno com o número do protocolo da rps
            XmlElement xmlDocElemento = XmlRetornoConsulta.DocumentElement;
            XmlElement xmlProtocolo = XmlRetornoConsulta.CreateElement("Protocolo");
            xmlProtocolo.InnerText = Protocolo.ToString();
            xmlDocElemento.AppendChild(xmlProtocolo);
            XmlRetornoConsulta.AppendChild(xmlDocElemento);

            return XmlRetornoConsulta;
        }
        public static void CancelarLote(int NroNfse)
        {
                XmlDocument XmlCancelamento = Comuns.Comuns.CriarXmlCancelarLote(NroNfse);
                XmlCancelamento = Comuns.Comuns.AssinaXmlDigitalmente(XmlCancelamento);
                try
                {

                    ServiceGinfesImpl.ServiceGinfesImplService Cancelamento = new ServiceGinfesImpl.ServiceGinfesImplService();
                    Cancelamento.ClientCertificates.Add(Comuns.Comuns.LocalizaCertificadoValido());
                    Cancelamento.Proxy = Comuns.Comuns.CriarProxy();
                    string Retorno = Cancelamento.CancelarNfseV3(Comuns.Comuns.CriarCabecalho().InnerXml, XmlCancelamento.InnerXml);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }
    }
}
