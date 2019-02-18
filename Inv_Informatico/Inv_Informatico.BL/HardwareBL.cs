using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inv_Informatico.BL
{
    public class HardwareBL
    {
        public List<Hardware> ObtenerHardware()
        {
            var hardware1 = new Hardware();
            hardware1.Id = 1;
            hardware1.Descripcion = "Monitor";
            hardware1.Marca = "Dell";

            var hardware2 = new Hardware();
            hardware2.Id = 2;
            hardware2.Descripcion = "Mouse";
            hardware2.Marca = "Logitech";

            var hardware3 = new Hardware();
            hardware3.Id = 3;
            hardware3.Descripcion = "Teclado";
            hardware3.Marca = "Compaq";

            var listadeHardware = new List<Hardware>();
            listadeHardware.Add(hardware1);
            listadeHardware.Add(hardware2);
            listadeHardware.Add(hardware3);

            return listadeHardware;
        }
    }
}
