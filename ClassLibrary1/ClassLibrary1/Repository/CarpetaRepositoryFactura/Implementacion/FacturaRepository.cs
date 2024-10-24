using BackCochera.Repository.CarpetaRepositoryFactura.Interfaces;
using ClassLibrary1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackCochera.Repository.CarpetaRepositoryFactura.Implementacion
{
    public class FacturaRepository : IFacturaRepository
    {
        db_cocherasContext _context;

        public FacturaRepository(db_cocherasContext context)
        {
            _context = context;
        }

        public Task<bool> Create(FACTURA factura)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<DETALLE_FACTURA>> GetAll()
        {
            var detalleCompleto = from detalle in _context.DETALLE_FACTURAs
                                             join factura in _context.FACTURAs
                                             on detalle.id_factura equals factura.id_factura
                                             join cliente in _context.CLIENTEs
                                             on factura.id_cliente equals cliente.id_cliente
                                             join vehiculo in _context.VEHICULOs
                                             on detalle.id_vehiculo equals vehiculo.id_vehiculo
                                             join abono in _context.ABONOs
                                             on detalle.id_abono equals abono.id_abono
                                             join tipo_vehiculo in _context.TIPO_VEHICULOs
                                             on vehiculo.id_tipo_vehiculo equals tipo_vehiculo.id_tipo_vehiculo
                                             join modelo in _context.MODELOs
                                             on vehiculo.id_modelo equals modelo.id_modelo
                                             select new
                                             {
                                                 Detalle = detalle.id_detalle_factura,
                                                 Entrada = detalle.fecha_entrada,
                                                 Salida = detalle.fecha_salida,
                                                 Factura = detalle.id_factura,
                                                 Patente = vehiculo.patente,
                                                 Tipo_Vehiculo = tipo_vehiculo.descripcion,
                                                 Modelo = modelo.descripcion,
                                                 Cliente = cliente.nombre,
                                                 Abono = abono.descripcion,
                                                 Precio = detalle.precio,
                                                 Descuento = detalle.descuento,
                                                 Recargo = detalle.recargo
                                             };

            var result = await detalleCompleto.ToListAsync();

            return result;
        }

        public Task<FACTURA> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(int id, FACTURA df)
        {
            throw new NotImplementedException();
        }
    }
}
