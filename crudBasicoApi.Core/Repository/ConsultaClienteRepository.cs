using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Core.v1.Repository;
using Dapper;

namespace Core.Repository.Consultas
{
    public class ConsultaClienteRepository : Conexao
    {
        public dynamic ConsultaCliente(string NM_Cliente) /*esse método é dynamic pq possui um retorno */
        {
            using (SqlConnection con = new SqlConnection(strConexao))
            {

                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("NM_Cliente", NM_Cliente, DbType.String);
                dynamic retorno = con.Query(sql: "dbo.ConsultaCliente",
                                            param: parametros,
                                            commandType: CommandType.StoredProcedure).ToList();
                // essa é a chamada de uma procedure, o .ToList é da biblioteca System.Linq; usando isso, a procedure deve retornar uma lista
                // a proc vem no objeto sql: e no commandType deve ser StoredProcedure
                return retorno;
            }
        }
    }
}