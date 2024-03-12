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
            using var connection = _context.CreateConnection();
            var funcionarios = await connection.QueryAsync<Funcionario>(query);

            return funcionarios.ToList();
        }

        public async Task<Funcionario> GetById(int id)
        {
            var query = "SELECT * FROM Funcionarios WHERE Id = @Id";
            using var connection = _context.CreateConnection();
            var funcionario = await connection.QuerySingleOrDefaultAsync<Funcionario>(query, new { id });

            return funcionario;
        }
    }
}
