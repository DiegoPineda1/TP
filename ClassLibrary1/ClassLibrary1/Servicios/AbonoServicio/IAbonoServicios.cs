using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackCochera.Servicios.AbonoServicio
{
    public interface IAbonoServicios
    {
        Task<List<ABONO>> GetAllAbonos();
        Task<List<ABONO>> GetPromedioAbonos();
    }
}
