using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Adapters.Interfaces;

namespace Application.Services
{
    public class UsuarioServiceManager : IUsuarioService
    {

        private readonly IUsuarioService _usuarioRepository;
        private readonly IEmailAdapter _emailAdapter;

        public UsuarioServiceManager(IUsuarioService usuarioService, IEmailAdapter emailAdapter) =>
               (_usuarioRepository, _emailAdapter) = (usuarioService, emailAdapter);

        public async Task<IEnumerable<Usuario>> GetAll()
        {
            var clubs = await _usuarioRepository.GetAll();
            return clubs;
        }

        public async Task<int> Insert(Usuario usuario)
        {
            var id = await _usuarioRepository.Insert(usuario);

            _ = _emailAdapter.SendEmail("", "", "", "");

            return id;
        }
    }
}
