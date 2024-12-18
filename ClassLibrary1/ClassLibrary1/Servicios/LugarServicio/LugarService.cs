﻿using BackCochera.Repository.CarpetaRepositoryLugar.UnitofWorkLugar;
using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BackCochera.Servicios.LugarServicio
{
    public class LugarService : ILugarService
    {
        private readonly IUnitOfWorkLugar _unitOfWork;
        public LugarService(IUnitOfWorkLugar unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<List<LUGARE>> GetAllLugares()
        {
            return await _unitOfWork.LugarRepository.GetAllLugares();
        }

        public async Task<List<LUGARE>> GetLugaresDisponibles()
        {
            return await _unitOfWork.LugarRepository.GetLugaresDisponibles();
        }

        public async Task<bool> UpdateLugar(int id, bool estaOcupado)
        {
            var actualizado = await _unitOfWork.LugarRepository.UpdateLugar(id, estaOcupado);
            return actualizado;
        }

    }
}

