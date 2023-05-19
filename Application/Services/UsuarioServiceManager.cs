using Domain.Interfaces;
using Domain.Interfaces;
using Domain.Entities;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UsuarioServiceManager : IUsuarioService
    {

        private readonly IUsuarioService _usuarioRepository;

        public UsuarioServiceManager(IUsuarioService usuarioService) =>
               (_usuarioRepository) = (usuarioService);

        public async Task<IEnumerable<Usuario>> GetAll()
        {
            var clubs = await _usuarioRepository.GetAll();
            return clubs;
        }

        public async Task<int> Insert(Usuario usuario)
        {
            var id = await _usuarioRepository.Insert(usuario);           

            return id;
        }
    }
}
