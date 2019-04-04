using System;
using System.Threading.Tasks;
using Core.Repository.Cadastros;

namespace Core.Service.Cadastros
{
    public class CadastroClienteService
    {
        private readonly CadastroClienteRepository _cadastroClienteRepository;

        public CadastroClienteService()
        {
            _cadastroClienteRepository = new CadastroClienteRepository(); /*no construtor instancio o repository  */
        }

        public void CadastroCliente(string NM_Cliente,
                                    string CPF_Cliente)
        {
            _cadastroClienteRepository.CadastroCliente(NM_Cliente,
                                                       CPF_Cliente); /* camada do service chama o repository */
        }
    }
}