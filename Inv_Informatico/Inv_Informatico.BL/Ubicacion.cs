using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inv_Informatico.BL
{
    public class Ubicacion
    {
        public int Id { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "Ingrese la descripción")]
        [MinLength(3, ErrorMessage = "Ingrese minimo 3 caracteres")]
        [MaxLength(20, ErrorMessage = "Ingrese un maximo de 20 caracteres")]
        public string Descripcion { get; set; }

        public int BodegaId { get; set; }
        public int Bodega Bodega {get; set;}

    }
}
