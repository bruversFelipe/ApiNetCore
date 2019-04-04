using System.Threading.Tasks;
using Api.Models;
using Core.Service.Cadastros;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Cadastros
{
    [Route("cadastros/")] /* Microsoft.AspNetCore.Mvc  Routes para definir a rota pai, pode ser repitida em outros arquivos*/
    public class CadastroClienteController
    {
        private readonly CadastroClienteService _cadastroClienteService;

        public CadastroClienteController()
        {
            _cadastroClienteService = new CadastroClienteService(); /* no construtor instancio o service  */
        }

        [HttpPost("cliente")] /* rota do método */
        public void CadastroCliente([FromBody] CadastroClienteModel entrada)
        /*métodos posts devem ter um modelo um objeto para ser passado e tipado (o teste deve ser feito via postman) */
        {
            _cadastroClienteService.CadastroCliente(entrada.NM_Cliente,
                                                    entrada.CPF_Cliente);
        }
    }
}