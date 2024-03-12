using DapperWebApi.Entities;

namespace DapperWebApi.Repositories.Interfaces
{
    public interface IEmpresaRepository
    {
        public Task<IEnumerable<Empresa>> GetAll();
    }
}
