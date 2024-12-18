﻿using BackCochera.Repository.CarpetaRepositoryCliente.Interfaces;
using ClassLibrary1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackCochera.Repository.CarpetaRepositoryCliente.Implemetacion
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly db_cocherasContext _context;
        public ClienteRepository(db_cocherasContext db_CocherasContext)
        {
            _context = db_CocherasContext;
        }

        public async Task<bool> CreateCliente(CLIENTE cliente)
        {
            await _context.CLIENTEs.AddAsync(cliente);
            return true;
        }

        public async Task<bool> DeleteCliente(int id)
        {
            var cliente = await _context.CLIENTEs.FindAsync(id);
            if (cliente != null)
            {
                _context.CLIENTEs.Remove(cliente);
                return true;
            }
            return false;
        }

        public async Task<List<CLIENTE>> GetAllClientes()
        {
            return await _context.CLIENTEs.ToListAsync();
        }

        public async Task<CLIENTE> GetClienteById(int id)
        {
            return await _context.CLIENTEs.FindAsync(id);
        }

        public async Task<bool> UpdateCliente(int id, CLIENTE clienteActualizado)
        {
            var cliente = await _context.CLIENTEs.FindAsync(id);
            if (cliente != null)
            {
                _context.Entry(cliente).CurrentValues.SetValues(clienteActualizado);
                return true;
            }
            return false;
        }
    }
}
