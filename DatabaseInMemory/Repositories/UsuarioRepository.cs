using Domain.Adapters.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatabaseInMemory.Repositories
{
    public class UsuarioRepository :IUsuarioService
    {
        public Task<IEnumerable<Usuario>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> Insert(Usuario club)
        {
            throw new NotImplementedException();
        }
    }
}
