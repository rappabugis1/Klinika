using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raspored
{
    interface IRaspored
    {
        List<RTermin> Tabela { get; set; }

        void ZakaziTermin(RTermin termin);
        RTermin DajSljedeci();

    }
}
