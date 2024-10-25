using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackCochera.Repository.CarpetaRepositoryLugar.Interfaces
{
    public interface ILugarRepository
    {
        Task<List<LUGARE>> GetAllLugares();
        Task<List<LUGARE>> GetLugaresDisponibles();
        Task<bool> UpdateLugar(int id,bool estaOcupado);
    }
}
