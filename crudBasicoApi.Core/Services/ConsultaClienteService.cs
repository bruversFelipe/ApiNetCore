using System;
using System.Threading.Tasks;
using Core.Repository.Consultas;

namespace Core.Service.Consultas
{
    public class ConsultaClienteService
    {
        private readonly ConsultaClienteRepository _consultaClienteRepository;

        public ConsultaClienteService()
        {
            _consultaClienteRepository = new ConsultaClienteRepository();
        }

        public dynamic ConsultaCliente(string NM_Cliente)
        {
            return _consultaClienteRepository.ConsultaCliente(NM_Cliente);
        }
    }
}