using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Security.Cryptography.Xml;
using System.Configuration;
using System.Net;
using System.Security.Principal;
using System.Globalization;
using EmitirNfse.Dados;

namespace EmitirNfse.Comuns
{
    public static class Comuns
    {
        /// <summary>
        /// Serializa um objeto em XML
        /// </summary>
        /// <param name="Objeto">Objeto a ser serializado</param>
        /// <returns>Retorna um Xml serializado a partir de um objeto</returns>
        public static String Serializar(object Objeto)
        {
            StringWriter sw = new StringWriter();
            XmlSerializer Serializer = new XmlSerializer(Objeto.GetType());
            Serializer.Serialize(sw, Objeto);
            return sw.ToString();
        }

        /// <summary>
        /// Serializa um objeto para xml no Enconding utf-8
        /// </summary>
        /// <param name="Objeto">Objeto a ser serializado para xml</param>
        /// <returns>Retorna uma string em formato xml</returns>
        public static String SerializarUtf8(object Objeto)
        {
            XmlSerializer Serializer = new XmlSerializer(Objeto.GetType());
            Stream stream = new MemoryStream();
            XmlTextWriter Xt = new XmlTextWriter(stream, UTF8Encoding.UTF8);
            Serializer.Serialize(Xt, Objeto);
            stream.Seek(0, SeekOrigin.Begin);
            StreamReader reader = new StreamReader(stream, UTF8Encoding.UTF8);
            string result = reader.ReadToEnd();
            return result;
        }

        /// <summary>
        /// Deserializa o objeto para XML
        /// </summary>
        /// <param name="xml">String do XML</param>
        /// <param name="type">typeof do objeto para realizar a deserialização</param>
        /// <returns>Retorna o objeto deserializado do Xml</returns>
        public static Object Deserializar(string xml, Type type)
        {
            StringReader Sr = new StringReader(xml);
            XmlSerializer Serializer = new XmlSerializer(type);
            return Serializer.Deserialize(Sr);
        }

        /// <summary>
        /// Localiza um certificado digital válido. Retorna um certificado.
        /// </summary>
        /// <returns>Retorna um certificado digital válido</returns>
        public static X509Certificate2 LocalizaCertificadoValido()
        {
            X509Certificate2Collection ColCert = new X509Certificate2Collection();
            X509Store Store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            Store.Open(OpenFlags.ReadOnly);
            ColCert = Store.Certificates;
            foreach (X509Certificate2 Cert in ColCert)
            {
                if (Cert.HasPrivateKey && Cert.NotAfter > DateTime.Now.Date && Cert.NotBefore < DateTime.Now.Date)
                    return Cert;
            }

            return null;
        }

        /// <summary>
        /// Método que converte um número em inteiro
        /// </summary>
        /// <param name="Str">String numérica que será convertida para inteiro</param>
        /// <returns>Retorna um número convertido para inteiro.</returns>
        public static int toInt32(this string Str)
        {
            int Retorno = 0;
            int.TryParse(Str, out Retorno);
            return Retorno;
        }

        /// <summary>
        /// Cria o arquivo de cabeçalho do xml de integração da Nfse
        /// </summary>
        /// <returns>Retorna um XmlDocument com o cabeçalho para enviar para a Nfse</returns>
        public static XmlDocument CriarCabecalho()
        {
            XmlDocument XmlCabecalho = new XmlDocument();
            XmlElement xmlRoot = XmlCabecalho.CreateElement("cabecalho", "http://www.ginfes.com.br/cabecalho_v03.xsd");
            XmlAttribute xmlAtt = XmlCabecalho.CreateAttribute("versao");
            xmlAtt.Value = "3";
            xmlRoot.Attributes.Append(xmlAtt);
            XmlElement XmlVersaoDados = XmlCabecalho.CreateElement("versaoDados");
            XmlVersaoDados.InnerText = "1";

            xmlRoot.AppendChild(XmlVersaoDados);
            XmlCabecalho.AppendChild(xmlRoot);
            return XmlCabecalho;
        }

        /// <summary>
        /// Assina um arquivo XML digitalmente utilizando um certificado no padrões ICP-Brasil para a integração da NFS-e.
        /// </summary>
        /// <param name="xml">XML que deverá ser assinado</param>
        /// <returns>Retorna um XmlDocument com assinatura do certificado digital</returns>
        public static XmlDocument AssinaLoteRpsDigitalmente(XmlDocument xml)
        {
            XmlNodeList ListNodeId = xml.GetElementsByTagName("LoteRps");
            XmlElement XmlNfse = xml.DocumentElement;
            X509Certificate2 Cert = LocalizaCertificadoValido();
            foreach (XmlElement InfRps in ListNodeId)
            {
                string Id = InfRps.Attributes.GetNamedItem("Id").Value;
                SignedXml signedXml = new SignedXml(InfRps);
                signedXml.SigningKey = Cert.PrivateKey;
                Reference reference = new Reference("#" + Id);
                reference.AddTransform(new XmlDsigEnvelopedSignatureTransform());
                reference.AddTransform(new XmlDsigC14NTransform());
                signedXml.AddReference(reference);
                KeyInfo keyInfo = new KeyInfo();
                keyInfo.AddClause(new KeyInfoX509Data(Cert));
                signedXml.KeyInfo = keyInfo;
                signedXml.ComputeSignature();
                XmlElement xmlSignature = xml.CreateElement("Signature", "http://www.w3.org/2000/09/xmldsig#");
                XmlElement xmlSignatureInfo = signedXml.SignedInfo.GetXml();
                XmlElement xmlKeyInfo = signedXml.KeyInfo.GetXml();
                XmlElement xmlSignatureValue = xml.CreateElement("SignatureValue", xmlSignature.NamespaceURI);
                string SignBase64 = Convert.ToBase64String(signedXml.Signature.SignatureValue);
                XmlText text = xml.CreateTextNode(SignBase64);
                xmlSignatureValue.AppendChild(text);
                xmlSignature.AppendChild(xml.ImportNode(xmlSignatureInfo, true));
                xmlSignature.AppendChild(xmlSignatureValue);
                xmlSignature.AppendChild(xml.ImportNode(xmlKeyInfo, true));
                XmlNfse.AppendChild(xmlSignature);
            }
            xml.AppendChild(XmlNfse);
            return xml;
        }

        /// <summary>
        /// Assina digitalmente um xml.
        /// </summary>
        /// <param name="xml">Xml que será assinado</param>
        /// <returns>Retorna um XmlDocument assinado</returns>
        public static XmlDocument AssinaXmlDigitalmente(XmlDocument xml)
        {
            XmlElement XmlNfse = xml.DocumentElement;
            X509Certificate2 Cert = LocalizaCertificadoValido();
            SignedXml signedXml = new SignedXml(xml);
            signedXml.SigningKey = Cert.PrivateKey;
            Reference reference = new Reference();
            reference.Uri = "";
            reference.AddTransform(new XmlDsigEnvelopedSignatureTransform());
            reference.AddTransform(new XmlDsigC14NTransform());
            signedXml.AddReference(reference);
            KeyInfo keyInfo = new KeyInfo();
            keyInfo.AddClause(new KeyInfoX509Data(Cert));
            signedXml.KeyInfo = keyInfo;
            signedXml.ComputeSignature();
            XmlElement xmlSignature = xml.CreateElement("Signature", "http://www.w3.org/2000/09/xmldsig#");
            XmlElement xmlSignatureInfo = signedXml.SignedInfo.GetXml();
            XmlElement xmlKeyInfo = signedXml.KeyInfo.GetXml();
            XmlElement xmlSignatureValue = xml.CreateElement("SignatureValue", xmlSignature.NamespaceURI);
            string SignBase64 = Convert.ToBase64String(signedXml.Signature.SignatureValue);
            XmlText text = xml.CreateTextNode(SignBase64);
            xmlSignatureValue.AppendChild(text);
            xmlSignature.AppendChild(xml.ImportNode(xmlSignatureInfo, true));
            xmlSignature.AppendChild(xmlSignatureValue);
            xmlSignature.AppendChild(xml.ImportNode(xmlKeyInfo, true));
            XmlNfse.AppendChild(xmlSignature);

            xml.AppendChild(XmlNfse);
            return xml;
        }

        public static XmlDocument CriarXmlCancelarLote(int NumeroNfse)
        {
            XmlDocument XmlCancelamento = new XmlDocument();
            XmlElement xmlRoot = XmlCancelamento.CreateElement("CancelarNfseEnvio", "http://www.ginfes.com.br/servico_cancelar_nfse_envio_v03.xsd");
            XmlElement xmlPedido = XmlCancelamento.CreateElement("Pedido");
            XmlElement xmlInfPedido = XmlCancelamento.CreateElement("InfPedidoCancelamento", "http://www.ginfes.com.br/tipos_v03.xsd");
            XmlElement xmlIdentNf = XmlCancelamento.CreateElement("IdentificacaoNfse", "http://www.ginfes.com.br/tipos_v03.xsd");
            XmlElement xmlNumero = XmlCancelamento.CreateElement("Numero", "http://www.ginfes.com.br/tipos_v03.xsd");
            XmlElement xmlCnpj = XmlCancelamento.CreateElement("Cnpj", "http://www.ginfes.com.br/tipos_v03.xsd");
            XmlElement xmlInscMunic = XmlCancelamento.CreateElement("InscricaoMunicipal", "http://www.ginfes.com.br/tipos_v03.xsd");
            XmlElement xmlCodiCanc = XmlCancelamento.CreateElement("CodigoCancelamento", "http://www.ginfes.com.br/tipos_v03.xsd");
            XmlElement xmlCodiMun = XmlCancelamento.CreateElement("CodigoMunicipio", "http://www.ginfes.com.br/tipos_v03.xsd");
            XmlDeclaration xmlDec = XmlCancelamento.CreateXmlDeclaration("1.0", "utf-8", null);
            xmlNumero.InnerText = NumeroNfse.ToString();
            xmlCnpj.InnerText = ConfigurationManager.AppSettings["CNPJPrestador"].ToString();
            xmlInscMunic.InnerText = ConfigurationManager.AppSettings["InscMunicipal"].ToString();
            xmlCodiMun.InnerText = ConfigurationManager.AppSettings["CodigoMunicipio"].ToString();
            xmlCodiCanc.InnerText = "E137";

            xmlIdentNf.AppendChild(xmlNumero);
            xmlIdentNf.AppendChild(xmlCnpj);
            xmlIdentNf.AppendChild(xmlInscMunic);
            xmlIdentNf.AppendChild(xmlCodiMun);
            xmlInfPedido.AppendChild(xmlIdentNf);
            xmlInfPedido.AppendChild(xmlCodiCanc);
            xmlPedido.AppendChild(xmlInfPedido);
            xmlRoot.AppendChild(xmlPedido);
            XmlCancelamento.AppendChild(xmlDec);
            XmlCancelamento.AppendChild(xmlRoot);

            return XmlCancelamento;
        }

        /// <summary>
        /// Cria o Xml para consultar o lote rps integrado.
        /// </summary>
        /// <param name="LoteRps">Número do lote rps informado no  retorno da integração</param>
        /// <returns>Retorna um XmlDocument para realizar a consulta do LoteRps</returns>
        public static XmlDocument CriarXmlConsultaLote(int LoteRps)
        {
            XmlDocument XmlConsulta = new XmlDocument();
            XmlElement xmlRoot = XmlConsulta.CreateElement("ConsultarLoteRpsEnvio", "http://www.ginfes.com.br/servico_consultar_lote_rps_envio_v03.xsd");
            XmlElement xmlPrestador = XmlConsulta.CreateElement("Prestador", "http://www.ginfes.com.br/servico_consultar_lote_rps_envio_v03.xsd");
            XmlElement xmlCnpj = XmlConsulta.CreateElement("Cnpj", "http://www.ginfes.com.br/tipos_v03.xsd");
            xmlCnpj.InnerText = ConfigurationManager.AppSettings["CNPJPrestador"].ToString();
            XmlElement xmlInscMunic = XmlConsulta.CreateElement("InscricaoMunicipal", "http://www.ginfes.com.br/tipos_v03.xsd");
            xmlInscMunic.InnerText = ConfigurationManager.AppSettings["InscMunicipal"].ToString();
            XmlElement xmlProtocolo = XmlConsulta.CreateElement("Protocolo", "http://www.ginfes.com.br/servico_consultar_lote_rps_envio_v03.xsd");
            xmlProtocolo.InnerText = LoteRps.ToString();
            XmlDeclaration xmlDec = XmlConsulta.CreateXmlDeclaration("1.0", "utf-8", null);

            XmlConsulta.AppendChild(xmlDec);
            xmlPrestador.AppendChild(xmlCnpj);
            xmlPrestador.AppendChild(xmlInscMunic);
            xmlRoot.AppendChild(xmlPrestador);
            xmlRoot.AppendChild(xmlProtocolo);
            XmlConsulta.AppendChild(xmlRoot);
            return XmlConsulta;
        }

        /// <summary>
        /// Cria um proxy IWebProxy para autenticação no servidor de internet
        /// </summary>
        /// <returns>Retorna um IWebProxy com os dados de autenticação do servidor web</returns>
        public static IWebProxy CriarProxy()
        {
            IWebProxy iw = WebRequest.GetSystemWebProxy();
            NetworkCredential nc = CredentialCache.DefaultNetworkCredentials;
            //NetworkCredential nc = new NetworkCredential("sergio.rezende", "sergiomcom", "mcom");
            iw.Credentials = nc;
            return iw;
        }

        /// <summary>
        /// Método que realiza a validação do xml da Nfse com os schemas.
        /// Busca o caminho dos Xsd's basedo no caminho descrito no arquivo de configuração
        /// </summary>
        /// <param name="xmlDoc">Arquivo xml gerado para a nfse</param>
        public static void ValidaXml(XmlDocument xmlDoc)
        {
            try
            {

                StringReader sr = new StringReader(xmlDoc.InnerXml);
                XmlReaderSettings xmlRS = new XmlReaderSettings();
                XmlUrlResolver xmlRes = new XmlUrlResolver();
                xmlRes.Credentials = CredentialCache.DefaultNetworkCredentials;
                xmlRS.Schemas.Add("http://www.ginfes.com.br/servico_enviar_lote_rps_envio_v03.xsd", string.Format("{0}{1}", ConfigurationManager.AppSettings["SchemasXDS"].ToString(), "servico_enviar_lote_rps_envio_v03.xsd"));
                xmlRS.Schemas.Add("http://www.ginfes.com.br/tipos_v03.xsd", string.Format("{0}{1}", ConfigurationManager.AppSettings["SchemasXDS"].ToString(), "tipos_v03.xsd"));
                xmlRS.Schemas.Add("http://www.ginfes.com.br/cabecalho_v03.xsd", string.Format("{0}{1}", ConfigurationManager.AppSettings["SchemasXDS"].ToString(), "cabecalho_v03.xsd"));
                xmlRS.Schemas.Add("http://www.ginfes.com.br/servico_consultar_lote_rps_envio_v03.xsd", string.Format("{0}{1}", ConfigurationManager.AppSettings["SchemasXDS"].ToString(), "servico_consultar_lote_rps_envio_v03.xsd"));
                xmlRS.Schemas.Add("http://www.ginfes.com.br/servico_consultar_situacao_lote_rps_resposta_v03.xsd", string.Format("{0}{1}", ConfigurationManager.AppSettings["SchemasXDS"].ToString(), "servico_consultar_situacao_lote_rps_resposta_v03.xsd"));
                xmlRS.Schemas.Add("http://www.ginfes.com.br/servico_cancelar_nfse_envio_v03.xsd", string.Format("{0}{1}", ConfigurationManager.AppSettings["SchemasXDS"].ToString(), "servico_cancelar_nfse_envio_v03.xsd"));
                xmlRS.XmlResolver = xmlRes;
                xmlRS.ValidationType = ValidationType.Schema;
                XmlReader xmlRR = XmlReader.Create(sr, xmlRS);
                XmlDocument NovoXml = new XmlDocument();
                NovoXml.Load(xmlRR);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método que valida o CPF e o CNPJ informado. Calcula o valor dos dígitos e compara com os valores informados.
        /// </summary>
        /// <param name="CpfCnpj">Valor do CPF ou CNPJ sem os caracteres especiais</param>
        /// <returns>Retorna verdadeiro para confirmação do Cpf/CNPJ ou falso para CPF/CNPJ incorreto.</returns>
        public static bool ValidaCpfCnpj(string CpfCnpj)
        {
            int Tamanho = CpfCnpj.Length;
            int Soma = 0;
            bool Valido = false;
            int Digito1 = 0;
            int Digito2 = 0;
            int Contador = 0;
            if (Tamanho == 14)
                Contador = 5;
            else
                Contador = Tamanho - 1;
            for (int i = 0; i < Tamanho - 2; i++)
            {
                int numero = int.Parse(CpfCnpj.Substring(i, 1));
                Soma += int.Parse(CpfCnpj.Substring(i, 1)) * (Contador - i);
                if ((Contador - i) == 2)
                    Contador = 10 + i;
            }

            Digito1 = (11 - (Soma % 11));
            if (Digito1 >= 10)
                Digito1 = 0;

            Soma = 0;
            if (Tamanho == 14)
                Contador = 6;
            else
                Contador = Tamanho;
            for (int i = 0; i < Tamanho - 1; i++)
            {
                int numero = int.Parse(CpfCnpj.Substring(i, 1));
                Soma += int.Parse(CpfCnpj.Substring(i, 1)) * (Contador - i);
                if ((Contador - i) == 2)
                    Contador = 10 + i;
            }

            Digito2 = (11 - (Soma % 11));
            if (Digito2 >= 10)
                Digito2 = 0;

            if (Digito1 == int.Parse(CpfCnpj.Substring(Tamanho - 2, 1))
                && Digito2 == int.Parse(CpfCnpj.Substring(Tamanho - 1, 1)))
                Valido = true;

            return Valido;
        }

        /// <summary>
        /// Recupera o valor da tag xml indicada pelo parâmetro
        /// </summary>
        /// <param name="xml">Stream do Xml</param>
        /// <param name="tag">Nome da tag para recuperar o valor</param>
        /// <returns>Retorna uma string com o valor da tag</returns>
        public static string RecuperaTextoTagXml(XmlDocument xml, string tag)
        {
            string Retorno = string.Empty;

            //XmlDocument xmld = new XmlDocument();
            //xmld.LoadXml(xml);
            //xmld.Normalize();
            XmlNodeList xnl = xml.GetElementsByTagName(tag);
            if (xnl.Count > 0)
                Retorno = xnl[0].InnerText;

            return Retorno;
        }

        /// <summary>
        /// Realiza o cálculo dos valores do serviço prestado em uma Nfse
        /// </summary>
        /// <param name="Cnpj">CNPJ do cliente para realizar o calculo dos valores acumulados na competência </param>
        /// <param name="ValorServico">Valor do serviço prestado</param>
        /// <param name="OutrasDeducoes">Valor de outras deduções</param>
        /// <param name="DescontoIncondicionado">Valor dos desconcontos incondicionados</param>
        /// <param name="DescontoCondicionado">Valor dos descontos condicionados</param>
        /// <param name="IssRetido">Se o ISS é retido este valor é verdadeiro, caso contrário será falso</param>
        /// <returns></returns>
        public static Modelos.Valores CalculaValores(string Cnpj, decimal ValorServico, decimal OutrasDeducoes, 
            decimal DescontoIncondicionado, decimal DescontoCondicionado, bool IssRetido)
        {
            Modelos.Valores Valores = new Modelos.Valores();
            string Competencia;
            if (DateTime.Now.Month > 9)
            {
                Competencia = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString();
            }
            else
            {
                Competencia = DateTime.Now.Year.ToString() + '0' + DateTime.Now.Month.ToString();
            }
            Decimal ValorAcumuladoServico = new Dados.RpsDados().RetornaTotalRpsAcumulado(new Dados.EmpresaDados().RetornaEmpresaPorCpfCnpj(Cnpj).EmpresaId, Competencia.toInt32());
            Valores.Aliquota = Convert.ToDecimal(ConfigurationManager.AppSettings["Iss"]) / 100M;
            Valores.ValorServicos = ValorServico;
            Valores.OutrasRetencoes = OutrasDeducoes;
            Valores.DescontoCondicionado = DescontoCondicionado;
            Valores.DescontoIncondicionado = DescontoIncondicionado;

            Valores.ValorDeducoes = ValorServico * 0.33M;
            Valores.BaseCalculo = ValorServico - Valores.ValorDeducoes;
            Valores.ValorIss = Valores.BaseCalculo * Valores.Aliquota;
            Valores.ValorInss = 0;
            if (Valores.ValorServicos >= 5000M || ValorAcumuladoServico >= 5000M)
            {
                Valores.ValorCsll = ValorServico * (Convert.ToDecimal(ConfigurationManager.AppSettings["Csll"]) / 100);
                Valores.ValorCofins = ValorServico * (Convert.ToDecimal(ConfigurationManager.AppSettings["Cofins"]) / 100);
                Valores.ValorPis = ValorServico * (Convert.ToDecimal(ConfigurationManager.AppSettings["Pis"]) / 100);
            }

            if (Valores.ValorServicos >= 650M)
            {
                Valores.ValorIr = ValorServico * (Convert.ToDecimal(ConfigurationManager.AppSettings["IR"]) / 100);
            }

            if (IssRetido)
            {
                Valores.ValorIssRetido = Valores.BaseCalculo * (Convert.ToDecimal(ConfigurationManager.AppSettings["Iss"]) / 100M);
                Valores.ValorIss = 0;
                Valores.IssRetido = 1;
            }
            else
            {
                Valores.IssRetido = 2;
                Valores.ValorIssRetido = 0;
            }

            Valores.BaseCalculo = Decimal.Round(Valores.BaseCalculo, 2);
            Valores.DescontoCondicionado = Decimal.Round(Valores.DescontoCondicionado, 2);
            Valores.DescontoIncondicionado = Decimal.Round(Valores.DescontoIncondicionado, 2);
            Valores.OutrasRetencoes = Decimal.Round(Valores.OutrasRetencoes, 2);
            Valores.ValorCofins = Decimal.Round(Valores.ValorCofins, 2);
            Valores.ValorCsll = Decimal.Round(Valores.ValorCsll, 2);
            Valores.ValorDeducoes = Decimal.Round(Valores.ValorDeducoes, 2);
            Valores.ValorInss = Decimal.Round(Valores.ValorInss, 2);
            Valores.ValorIr = Decimal.Round(Valores.ValorIr, 2);
            Valores.ValorIss = Decimal.Round(Valores.ValorIss, 2);
            Valores.ValorIssRetido = Decimal.Round(Valores.ValorIssRetido, 2);
            Valores.ValorLiquidoNfse = Decimal.Round(Valores.ValorLiquidoNfse, 2);
            Valores.ValorPis = Decimal.Round(Valores.ValorPis, 2);
            Valores.ValorServicos = Decimal.Round(Valores.ValorServicos, 2);


            Valores.ValorLiquidoNfse = Valores.ValorServicos - (Valores.ValorPis + Valores.ValorCofins + Valores.ValorCsll + 
                Valores.ValorInss + Valores.ValorIr + Valores.OutrasRetencoes + Valores.ValorIssRetido + Valores.DescontoCondicionado+
                Valores.DescontoIncondicionado);


            return Valores;
        }

        /// <summary>
        /// Preenche o modelo de Nota Fiscal Eletrônica.
        /// </summary>
        /// <param name="XmlRetorno">Arquivo Xml de retorno da integração com a Nfse</param>
        /// <returns>Retorna uma lista do modelo de Nfse</returns>
        public static List<Modelos.InfNfse> PreencheNfse(XmlDocument XmlRetorno)
        {
            List<Modelos.InfNfse> LstNfse = new List<Modelos.InfNfse>();
            XmlNodeList DadosNf = XmlRetorno.GetElementsByTagName("ns4:InfNfse");
            XmlNodeList DadosValores = XmlRetorno.GetElementsByTagName("ns4:Valores");
            XmlNodeList DadosServico = XmlRetorno.GetElementsByTagName("ns4:Servico");
            XmlNodeList DadosTomador = XmlRetorno.GetElementsByTagName("ns4:CpfCnpj");
            XmlNodeList IdentRps = XmlRetorno.GetElementsByTagName("ns4:IdentificacaoRps");
            for (int i = 0; i < DadosNf.Count; i++)
            {
                Modelos.InfNfse nfse = new Modelos.InfNfse();
                nfse.RpsNumero = IdentRps[i]["ns4:Numero"].InnerText.toInt32();
                nfse.Aliquota = Convert.ToDecimal(DadosValores[i]["ns4:Aliquota"].InnerText);
                nfse.BaseCalculo = Convert.ToDecimal(DadosValores[i]["ns4:BaseCalculo"].InnerText, new CultureInfo("en-US"));
                nfse.CodigoVerificacao = DadosNf[i]["ns4:CodigoVerificacao"].InnerText;
                nfse.Competencia = DadosNf[i]["ns4:Competencia"].InnerText.toInt32();
                nfse.DataEmissao = Convert.ToDateTime(DadosNf[i]["ns4:DataEmissaoRps"].InnerText);
                nfse.DescontoCondicionado = Convert.ToDecimal(DadosValores[i]["ns4:DescontoCondicionado"].InnerText, new CultureInfo("en-US"));
                nfse.DescontoIncondicionado = Convert.ToDecimal(DadosValores[i]["ns4:DescontoIncondicionado"].InnerText, new CultureInfo("en-US"));
                nfse.Discriminacao = DadosServico[i]["ns4:Discriminacao"].InnerText;
                nfse.IncetivadorCultural = DadosNf[i]["ns4:IncentivadorCultural"].InnerText.toInt32();
                nfse.IssRetido = DadosValores[i]["ns4:IssRetido"].InnerText.toInt32();
                nfse.ItemListaServico = DadosServico[0]["ns4:ItemListaServico"].InnerText;
                nfse.NaturezaOperacao = DadosNf[i]["ns4:NaturezaOperacao"].InnerText.toInt32();
                nfse.Numero = DadosNf[i]["ns4:Numero"].InnerText.toInt32();
                nfse.OptanteSimplesNacional = DadosNf[i]["ns4:OptanteSimplesNacional"].InnerText.toInt32();
                nfse.OutrasRetencoes = Convert.ToDecimal(DadosValores[i]["ns4:OutrasRetencoes"].InnerText, new CultureInfo("en-US"));
                nfse.ValorCofins = Convert.ToDecimal(DadosValores[i]["ns4:ValorCofins"].InnerText, new CultureInfo("en-US"));
                nfse.ValorCsll = Convert.ToDecimal(DadosValores[i]["ns4:ValorCsll"].InnerText, new CultureInfo("en-US"));
                nfse.ValorDeducoes = Convert.ToDecimal(DadosValores[i]["ns4:ValorDeducoes"].InnerText, new CultureInfo("en-US"));
                nfse.ValorInss = Convert.ToDecimal(DadosValores[i]["ns4:ValorInss"].InnerText, new CultureInfo("en-US"));
                nfse.ValorIr = Convert.ToDecimal(DadosValores[i]["ns4:ValorIr"].InnerText, new CultureInfo("en-US"));
                nfse.ValorIss = Convert.ToDecimal(DadosValores[i]["ns4:ValorInss"].InnerText, new CultureInfo("en-US"));
                nfse.ValorIssRetido = Convert.ToDecimal(DadosValores[i]["ns4:ValorIssRetido"].InnerText, new CultureInfo("en-US"));
                nfse.ValorLiquidoNfse = Convert.ToDecimal(DadosValores[i]["ns4:ValorLiquidoNfse"].InnerText, new CultureInfo("en-US"));
                nfse.ValorPis = Convert.ToDecimal(DadosValores[i]["ns4:ValorPis"].InnerText, new CultureInfo("en-US"));
                nfse.ValorServicos = Convert.ToDecimal(DadosValores[i]["ns4:ValorServicos"].InnerText, new CultureInfo("en-US"));
                nfse.StatusNfse = Convert.ToInt32(Modelos.EnumStatusNfse.Normal);
                if (DadosTomador[0]["ns4:Cnpj"] != null)
                    nfse.EmpresaId = new EmpresaDados().RetornaEmpresaPorCpfCnpj(DadosTomador[i]["ns4:Cnpj"].InnerText).EmpresaId;
                else
                    nfse.EmpresaId = new EmpresaDados().RetornaEmpresaPorCpfCnpj(DadosTomador[i]["ns4:Cpf"].InnerText).EmpresaId;
                LstNfse.Add(nfse);
            }

            return LstNfse;
        }

    }
}
