﻿using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackCochera.Repository.CarpetaRepositoryFactura.Interfaces
{
    public interface IFacturaRepository
    {
        Task<List<FACTURA>> GetAll();
        Task<FACTURA> GetById(int id);
        Task<bool> Create(FACTURA factura);
        Task<bool> Update(int id, FACTURA DF);
        Task<bool> DeleteById(int id);
    }
}
