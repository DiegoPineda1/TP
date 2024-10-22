using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackCochera.Repository.CarpetaRepositoryCliente.Interfaces
{
    public interface IClienteRepository
    {
        Task<List<CLIENTE>> GetAllClientes();
        Task<CLIENTE> GetClienteById(int id);
        Task<bool> CreateCliente(CLIENTE cliente);
        Task<bool> UpdateCliente(int id, CLIENTE clienteActualizado);
        Task<bool> DeleteCliente(int id);
    }
}
