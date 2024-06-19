using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.Validation;
using System.Data;

namespace EmitirNfse.Dados
{
    public class EmpresaDados
    {
        public IList<Modelos.Empresas> ListarEmpresas()
        {
            using (DadosContext Context = new DadosContext())
            {
                try
                {
                    return Context.EmpresaSet.ToList();
                }
                catch (DbEntityValidationException ex)
                {
                    throw ex;
                }
            }
        }

        public Modelos.Empresas RetornaEmpresaPorId(int Id)
        {
            using (DadosContext Context = new DadosContext())
            {
                return Context.EmpresaSet.Find(Id);
            }
        }

        public Modelos.Empresas RetornaEmpresaPorCpfCnpj(string CpfCnpj)
        {
            using (DadosContext Context = new DadosContext())
            {
                return Context.EmpresaSet.Where(a => a.CNPJ.Equals(CpfCnpj)).FirstOrDefault();
            }
        }

        public Modelos.Cep PesquisaCep(string CodigoCep)
        {
            using (DadosContext Context = new DadosContext("name=CnnCep"))
            {
                string ConsulaSql = "SELECT CASE WHEN LOG_LOGRADOURO.CEP IS NULL THEN LOG_LOCALIDADE.CEP ELSE LOG_LOGRADOURO.CEP END AS CEP, LOG_LOGRADOURO.LOG_NO_ABREV, LOG_LOCALIDADE.UFE_SG, LOG_LOCALIDADE.LOC_NO, LOG_LOCALIDADE.MUN_NU, LOG_BAIRRO.BAI_NO " +
                    "FROM LOG_LOGRADOURO WITH(NOLOCK) FULL OUTER JOIN LOG_LOCALIDADE WITH(NOLOCK) ON LOG_LOGRADOURO.LOC_NU = LOG_LOCALIDADE.LOC_NU LEFT OUTER JOIN LOG_BAIRRO WITH(NOLOCK) ON LOG_LOGRADOURO.BAI_NU_INI = LOG_BAIRRO.BAI_NU " +
                    "WHERE CASE WHEN LOG_LOGRADOURO.CEP IS NULL THEN LOG_LOCALIDADE.CEP ELSE LOG_LOGRADOURO.CEP END = '" + CodigoCep + "'";

                return Context.CepSet.SqlQuery(ConsulaSql, CodigoCep).FirstOrDefault();
            }
        }

        public IList<string> RetornaUf()
        {
            using (DadosContext Context = new DadosContext("name=CnnCep"))
            {
                string ConsulaSql = "SELECT DISTINCT UFE_SG FROM Log_Faixa_Uf ORDER BY UFE_SG";
                var v = Context.Database.SqlQuery<string>(ConsulaSql).ToList();
                return v;
            }
        }

        public IList<string> RetornaCidadePorUf(string Uf)
        {
            using (DadosContext Context = new DadosContext("name=CnnCep"))
            {
                string ConsulaSql = "SELECT LOC_NO FROM LOG_LOCALIDADE WHERE UFE_SG = '" + Uf + "' ORDER BY LOC_NO";

                return Context.Database.SqlQuery<string>(ConsulaSql).Distinct().ToList();
            }
        }

        public void Salvar(Modelos.Empresas empresa)
        {
            using (DadosContext Context = new DadosContext())
            {
                Context.Entry(empresa).State = empresa.EmpresaId == 0 ? EntityState.Added : EntityState.Modified;
                Context.SaveChanges();
            }
        }
    }
}
