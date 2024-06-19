using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace EmitirNfse.Modelos
{
    public enum EnumNatOperacao
    {

        [Description("Tributação no município")]
        TribMunicipio = 1,
        [Description("Tributação fora do município")]
        TribForaMunicipio = 2,
        [Description("Isenção")]
        Isencao = 3,
        [Description("Imune")]
        Inume = 4,
        [Description("Exigibilidade suspensa por decisão judicial")]
        DecicaoJudicial = 5,
        [Description("Exigibilidade suspensa por procedimento administrativo")]
        ProcAdm = 6

    }
}
