using System.Threading.Tasks;
using Api.Models;
using Core.Service.Consultas;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Consultas
{
    [Route("consultas/")]
    public class ConsultaClienteController
    {
        private readonly ConsultaClienteService _consultaClienteService;

        public ConsultaClienteController()
        {
            _consultaClienteService = new ConsultaClienteService();
        }

        [HttpGet("cliente/{NM_Cliente}")]
        /* métodos gets usados em consultas, pode ser passado parâmetro via url (o teste pode ser feito via navegador) */
        public dynamic ConsultaCliente(string NM_Cliente)
        {
            return _consultaClienteService.ConsultaCliente(NM_Cliente);
        }
    }
}