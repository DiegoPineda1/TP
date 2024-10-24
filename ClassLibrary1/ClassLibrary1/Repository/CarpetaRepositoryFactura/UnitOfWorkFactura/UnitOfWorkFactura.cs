using BackCochera.Repository.CarpetaRepositoryCliente.Interfaces;
using BackCochera.Repository.CarpetaRepositoryFactura.Interfaces;
using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackCochera.Repository.CarpetaRepositoryFactura.UnitOfWorkFactura
{
    public class UnitOfWorkFactura : IUnitOfWorkFactura
    {
        private readonly db_cocherasContext _context;
        public IFacturaRepository FacturaRepository { get; }

        public UnitOfWorkFactura(db_cocherasContext context, IFacturaRepository repos)
        {
            _context = context;
            FacturaRepository = repos;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
