using BackCochera.Repository.CarpetaRepositoryLugar.Interfaces;
using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackCochera.Repository.CarpetaRepositoryLugar.UnitofWorkLugar
{
    public class UnitOfWorkLugar : IUnitOfWorkLugar
    {
        private readonly db_cocherasContext _context;
        public ILugarRepository LugarRepository { get; }
        public UnitOfWorkLugar(db_cocherasContext context,ILugarRepository repos)
        {
            _context = context;
            LugarRepository = repos;
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
