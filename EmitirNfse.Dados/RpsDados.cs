using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace EmitirNfse.Dados
{
    public class RpsDados
    {
        public int RetornaProximoNumeroRps()
        {
            using (DadosContext Context = new DadosContext())
            {
                int id = Context.IdentificaRpsSet.OrderByDescending(a => a.Numero).Select(b => b.Numero).FirstOrDefault();
                return id + 1;
            }
        }

        public void SalvarRps(Modelos.IdentificacaoRPS Rps)
        {
            using (DadosContext Context = new DadosContext())
            {
                Context.Entry(Rps).State = EntityState.Added;
                Context.SaveChanges();
            }
        }

        public DataTable ListarRps()
        {
            using (DadosContext Context = new DadosContext())
            {
                var q = from c in Context.IdentificaRpsSet
                        join b in Context.EmpresaSet
                        on c.EmpresaId equals b.EmpresaId
                        join n in Context.Nfse
                        on c.Numero equals n.RpsNumero into d //Realiza um LEFT JOIN no select dos objetos.
                        from e in d.DefaultIfEmpty()
                        where c.Protocolo != string.Empty
                        orderby c.Numero descending
                        select new { c.Numero, b.RazaoSocial, b.CNPJ, c.Serie, c.Tipo, c.Valor, NroNfse = e.Numero == null ? 0 : e.Numero, c.Protocolo, c.Mensagem };

                DataTable Dt = new DataTable();
                Dt.Columns.Add("Numero");
                Dt.Columns.Add("RazaoSocial");
                Dt.Columns.Add("Cnpj");
                Dt.Columns.Add("Serie");
                Dt.Columns.Add("Tipo");
                Dt.Columns.Add("Valor");
                Dt.Columns.Add("NroNfse");
                Dt.Columns.Add("Protocolo");
                Dt.Columns.Add("Mensagem");

                foreach (var item in q)
                { 
                    Dt.Rows.Add(item.Numero, 
                        item.RazaoSocial,
                        item.CNPJ,
                        item.Serie,
                        item.Tipo,
                        item.Valor,
                        item.NroNfse,
                        item.Protocolo,
                        item.Mensagem); 
                }

                return Dt;

            }
        }

        public void ModificarRps(Modelos.IdentificacaoRPS Rps)
        {
            using (DadosContext Context = new DadosContext())
            {
                Context.Entry(Rps).State = EntityState.Modified;
                Context.SaveChanges();
            }
        }

        public IList<Modelos.IdentificacaoRPS> RetornaRpsPorProtocolo(string P)
        {
            using (DadosContext Context = new DadosContext())
            {
                return Context.IdentificaRpsSet.Where(a => a.Protocolo == P).ToList();
            }
        }

        public Modelos.IdentificacaoRPS RetornaRpsPorNumero(int NumeroRps)
        {
            using (DadosContext Context = new DadosContext())
            {
                return Context.IdentificaRpsSet.Where(a => a.Numero.Equals(NumeroRps)).FirstOrDefault();
            }
        }

        /// <summary>
        /// Calcula o valor acumulado do cliente na competência atual
        /// </summary>
        /// <param name="Empresa">Id da empresa</param>
        /// <param name="Competencia">Ano/mês da emissão da Nfse</param>
        /// <returns>Retorna um valor decimal</returns>
        public decimal RetornaTotalRpsAcumulado(int Empresa, int Competencia)
        {
            using (DadosContext Context = new DadosContext())
            {
                var q = from r in Context.IdentificaRpsSet
                        join n in Context.Nfse
                        on r.Numero equals n.RpsNumero into d
                        from e in d.DefaultIfEmpty()
                        where r.EmpresaId == Empresa && e.StatusNfse == 1 && e.Competencia == Competencia
                        select r;

                if (q.Count() == 0)
                    return 0M;
                else
                    return q.Sum(a => a.Valor);
            }
        }
    }
}
