using BackCochera.Repository.CarpetaRepositoryAbono.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackCochera.Repository.CarpetaRepositoryAbono.UnitOfWorkAbono
{
    public interface IUnitOfWorkAbono : IDisposable
    {
        IAbonoRepository AbonoRepository { get; }
        Task<int> SaveChangesAsync();
    }
}
