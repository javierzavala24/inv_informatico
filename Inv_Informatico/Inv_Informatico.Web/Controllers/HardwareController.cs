using Inv_Informatico.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inv_Informatico.Web.Controllers
{
    public class HardwareController : Controller
    {
        // GET: Hardware
        public ActionResult Index()
        {
            var hardware1 = new HardwareModel();
            hardware1.Id = 1;
            hardware1.Descripcion = "Monitor";

            var hardware2 = new HardwareModel();
            hardware2.Id = 2;
            hardware2.Descripcion = "Mouse";

            var hardware3 = new HardwareModel();
            hardware3.Id = 3;
            hardware3.Descripcion = "Teclado";

            var listadeHardware = new List<HardwareModel>();
            listadeHardware.Add(hardware1);
            listadeHardware.Add(hardware2);
            listadeHardware.Add(hardware3);

            return View(listadeHardware);
        }
    }
}