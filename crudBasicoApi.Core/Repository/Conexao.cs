using System;
using System.Data;
using Dapper;

namespace Core.v1.Repository
{
    public class Conexao
    {
        /* primeiro passo é a conexão. */
        /* string de conexão básica, pode ser feito de forma melhor e também criptografada */
        public string strConexao = @"data source=localhost\sqlexpress;initial catalog=CRUD_BASICO;persist security info=True;Integrated Security=SSPI;";
    }

    internal static class DapperExtensions
    {
    }
}