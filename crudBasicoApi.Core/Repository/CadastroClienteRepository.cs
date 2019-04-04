
using System.Data;
using System.Data.SqlClient;
using Core.v1.Repository;
using Dapper;

namespace Core.Repository.Cadastros
{
    public class CadastroClienteRepository : Conexao /* herda conexão */
    {
        public void CadastroCliente(string NM_Cliente,
                                    string CPF_Cliente) /*esse método é void pois só cadastra, não tem retorno */
        {
            using (SqlConnection con = new SqlConnection(strConexao)) /* usa a dependencia SqlClient e instancia o objeto con */
            {

                DynamicParameters parametros = new DynamicParameters(); /* dynamic parameters - Biblioteca dapper */
                parametros.Add("NM_Cliente", NM_Cliente, DbType.String); /* dbtype - tipa o parâmetro - biblioteca System.Data */
                parametros.Add("CPF_Cliente", CPF_Cliente, DbType.String);
                con.Query(sql: @"INSERT INTO dbo.Cliente(NM_Cliente, CPF_Cliente)
                                 VALUES (@NM_Cliente, @CPF_Cliente);",
                          param: parametros,
                          commandType: CommandType.Text); /* essa é a inserção de código manual, sem procedure, vem um texto sql e no commmand type vem .text */
            }
        }
    }
}