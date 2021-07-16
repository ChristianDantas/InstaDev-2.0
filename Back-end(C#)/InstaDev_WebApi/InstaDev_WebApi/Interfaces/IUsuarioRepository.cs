using InstaDev_WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaDev_WebApi.Interfaces
{
    interface IUsuarioRepository
    {
        void Cadastrar(Usuario NovoUsuario);
        List<Usuario> listagem();
        void Atualizar(int id, Usuario UsuarioAtualizado);
        void Seguir(Usuario UsuarioSeguidor, Usuario UsuarioSeguido);
    }
}
