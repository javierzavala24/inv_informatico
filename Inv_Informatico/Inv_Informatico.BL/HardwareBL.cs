using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inv_Informatico.BL
{
    public class HardwareBL
    {
        Contexto _contexto;
        public List<Hardware> ListadeHardware { get; set; }

        public HardwareBL()
        {
            _contexto = new Contexto();
            ListadeHardware = new List<Hardware>();
        }

        public List<Hardware> ObtenerHardware()
        {
            ListadeHardware = _contexto.Hardware.ToList();
            return ListadeHardware;

        }
    }
}
