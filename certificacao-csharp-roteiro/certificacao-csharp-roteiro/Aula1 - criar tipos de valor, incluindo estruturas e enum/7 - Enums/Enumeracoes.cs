using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Enumeracoes : IAulaItem
    {
        public void Executar()
        {
            DiaDaSemana segunda = DiaDaSemana.Seg;

            DiaDaSemana primeiroDia = DiaDaSemana.Seg;
            Console.WriteLine($"primeiroDia: {primeiroDia}");

            Console.WriteLine($"(primeiroDia == 0): {(primeiroDia == 0)}");

            Console.WriteLine($"(int)DiaDaSemanaInicio3.Seg = {(int)DiaDaSemanaInicio3.Seg}");

            PlanoTVAssinatura residencia1 = PlanoTVAssinatura.TV | PlanoTVAssinatura.Celular;
            PlanoTVAssinatura residencia2 = PlanoTVAssinatura.Celular | PlanoTVAssinatura.Internet;
            PlanoTVAssinatura residencia3 = PlanoTVAssinatura.FoneFixo | PlanoTVAssinatura.Celular;

            Console.WriteLine($"residencia1 tem internet?" +
                $"{(residencia1 & PlanoTVAssinatura.Internet) == PlanoTVAssinatura.Internet}");
            Console.WriteLine($"residencia2 tem internet? " +
                $"{(residencia2 & PlanoTVAssinatura.Internet) == PlanoTVAssinatura.Internet}");
            Console.WriteLine($"residencia3 tem internet? " +
                $"{(residencia3 & PlanoTVAssinatura.Internet) == PlanoTVAssinatura.Internet}");
        }
    }

    enum DiaDaSemana { Seg, Ter, Qua, Qui, Sex, Sab, Dom };

    enum DiaDaSemanaInicio3 { Seg = 3, Ter, Qua, Qui, Sex, Sab, Dom };

    enum DiaTipado : long { Seg = 0, Ter, Qua, Qui, Sex, Sab, Dom };

    [FlagsAttribute]
    public enum PlanoTVAssinatura
    {
        Nenhum = 0,
        TV = 1,
        FoneFixo = 2,
        Celular = 4,
        Internet = 8,
        Ilimitado = 16
    }
}
