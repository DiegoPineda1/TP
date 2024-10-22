using BackCochera.Repository.CarpetaRepositoryCliente.unitofworkClientes;
using ClassLibrary1.Models;
using ClassLibrary1.Repository.unit_of_work;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiClientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteCotroller : ControllerBase
    {
        private readonly IUnitOfWorkCliente _unitOfWork;
        public ClienteCotroller(IUnitOfWorkCliente unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CLIENTE>>> GetClientes()
        {
            return await _unitOfWork.ClienteRepository.GetAllClientes();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<CLIENTE>> GetCliente(int id)
        {
            var cliente = await _unitOfWork.ClienteRepository.GetClienteById(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return cliente;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCliente(int id, CLIENTE cliente)
        {
            if (id != cliente.id_cliente)
            {
                return BadRequest();
            }
            var actualizado = await _unitOfWork.ClienteRepository.UpdateCliente(id, cliente);
            if (!actualizado)
            {
                return NotFound();
            }
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<CLIENTE>> PostCliente(CLIENTE cliente)
        {
            await _unitOfWork.ClienteRepository.CreateCliente(cliente);
            await _unitOfWork.SaveChangesAsync();
            return CreatedAtAction("GetCliente", new { id = cliente.id_cliente }, cliente);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            var eliminado = await _unitOfWork.ClienteRepository.DeleteCliente(id);
            if (!eliminado)
            {
                return NotFound();
            }
            await _unitOfWork.SaveChangesAsync();
            return NoContent();
        }
    }
}
