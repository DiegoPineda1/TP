using BackCochera.Repository.CarpetaRepositoryAbono.UnitOfWorkAbono;
using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackCochera.Servicios.AbonoServicio
{
    public class AbonoServicios : IAbonoServicios
    {
        private readonly IUnitOfWorkAbono _unitOfWorkAbono;

        public AbonoServicios(IUnitOfWorkAbono unitOfWorkAbono)
        {
            _unitOfWorkAbono = unitOfWorkAbono;
        }

        public async Task<List<ABONO>> GetAllAbonos()
        {
            return await _unitOfWorkAbono.AbonoRepository.GetAllAbonos();
        }

        public Task<List<ABONO>> GetPromedioAbonos()
        {
            throw new NotImplementedException();
        }
    }
}
