using BackCochera.Repository.CarpetaRepositoryAbono.Interfaces;
using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackCochera.Repository.CarpetaRepositoryAbono.UnitOfWorkAbono
{
    public class UnitOfWorkAbono : IUnitOfWorkAbono
    {
        private readonly db_cocherasContext _context;

        public IAbonoRepository AbonoRepository {  get; }

        public UnitOfWorkAbono(db_cocherasContext context, IAbonoRepository abonoRepository)
        {
            _context = context;
            AbonoRepository = abonoRepository;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
