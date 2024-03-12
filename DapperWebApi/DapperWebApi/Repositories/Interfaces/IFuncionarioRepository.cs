using DapperWebApi.Entities;

namespace DapperWebApi.Repositories.Interfaces
{
    public interface IFuncionarioRepository
    {
        public Task<IEnumerable<Funcionario>> GetAll();
        public Task<Funcionario> GetById(int id);
    }
}
