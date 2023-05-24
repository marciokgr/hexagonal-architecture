using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Adapters.Interfaces
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> GetAll();

        Task<int> Insert(Usuario club);
    }
}
