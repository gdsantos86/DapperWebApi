using Dapper;
using DapperWebApi.Context;
using DapperWebApi.Entities;
using DapperWebApi.Repositories.Interfaces;

namespace DapperWebApi.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly DapperContext _context;

        public FuncionarioRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Funcionario>> GetAll()
        {
            var query = "SELECT * FROM Funcionarios";
            using (var connection = _context.CreateConnection())
            {
                var funcionarios = await connection.QueryAsync<Funcionario>(query);
                return funcionarios.ToList();
            }
        }
    }
}
