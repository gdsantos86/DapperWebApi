using Dapper;
using DapperWebApi.Context;
using DapperWebApi.Entities;
using DapperWebApi.Repositories.Interfaces;

namespace DapperWebApi.Repositories
{
    public class EmpresaRepository :IEmpresaRepository
    {
        private readonly DapperContext _context;

        public EmpresaRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Empresa>> GetAll()
        {
            var query = "SELECT * FROM Empresas";
            using var connection = _context.CreateConnection();
            var empresas = await connection.QueryAsync<Empresa>(query);

            return empresas.ToList();
        }

        public async Task<Empresa> GetById(int id)
        {
            var query = "SELECT * FROM Empresas WHERE Id = @Id";
            using var connection = _context.CreateConnection();
            var empresa = await connection.QuerySingleOrDefaultAsync<Empresa>(query, new {id});

            return empresa;
        }
    }
}
