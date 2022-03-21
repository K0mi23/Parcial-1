using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1
{
    internal class DatosJugador
    {
        public string nombreJugador { get; set; }
        public string numJugador { get; set; }
        public string equipoJugador { get; set; }
    }

    internal class datosEncuentro
    {
        public string numJugador2 { get; set; }
        public DateTime fechaEncuentro { get; set; }
        public string equipoContrario { get; set; }
        public int golesAnotados { get; set; }
    }

    internal class datosGolesJugador
    {
        public string nombreJugador { get; set; }
        public int golesAnotados { get; set; }

    }
}
