using System;
using System.Collections.Generic;

#nullable disable

namespace InstaDev_WebApi.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Publicacaos = new HashSet<Publicacao>();
        }

        public int IdUsuario { get; set; }
        public int? IdTipo { get; set; }
        public string NomeUsuario { get; set; }
        public string Indentificacao { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public byte[] FotoPerfil { get; set; }
        public int? Seguidores { get; set; }

        public virtual TipoUsuario IdTipoNavigation { get; set; }
        public virtual ICollection<Publicacao> Publicacaos { get; set; }
    }
}
