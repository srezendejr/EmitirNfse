using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace EmitirNfse.Modelos
{
    public class Cep
    {
        [Key]
        public string CEP
        {
            get;
            set;
        }

        public string LOG_NO_ABREV
        {
            get;
            set;
        }

        public string UFE_SG
        {
            get;
            set;
        }

        public string LOC_NO
        {
            get;
            set;
        }

        public int MUN_NU
        {
            get;
            set;
        }

        public string BAI_NO
        {
            get;
            set;
        }
    }
}
