using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> GetAll();

        Task<int> Insert(Usuario club);
    }
}
