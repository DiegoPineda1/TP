using BackCochera.Repository.CarpetaRepositoryCliente.Interfaces;
using BackCochera.Repository.CarpetaRepositoryVehiculo.Interfaces;

namespace BackCochera.Repository.CarpetaRepositoryVehiculo.UnitofWorkVehiculo
{
    public interface IUnitOfWorkVehiculo
    {
        IVehiculoRepository vehiculoRepository { get; }
        Task<int> SaveChangesAsync();
    }
}