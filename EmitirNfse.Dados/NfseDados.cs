using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace EmitirNfse.Dados
{
    public class NfseDados
    {
        public void SalvarNfse(Modelos.InfNfse Nfse)
        {
            using (DadosContext Context = new DadosContext())
            {
                if (Context.Nfse.Where(a=> a.Numero.Equals(Nfse.Numero)).Count() == 0)
                    Context.Entry(Nfse).State = EntityState.Added;
                else
                    Context.Entry(Nfse).State = EntityState.Modified;


                Context.SaveChanges();
            }
        }

        public Modelos.InfNfse RetornaNfsePorRps(int NumeroRps)
        {
            using (DadosContext Context = new DadosContext())
            {
                return Context.Nfse.Where(a => a.RpsNumero.Equals(NumeroRps)).FirstOrDefault();
            }
        }

        public Modelos.InfNfse RetornaNfsePorNro(int NumeroNfse)
        {
            using (DadosContext Context = new DadosContext())
            {
                return Context.Nfse.Find(NumeroNfse);
            }
        }
    }
}
