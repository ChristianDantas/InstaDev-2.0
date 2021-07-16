using System;
using System.Collections.Generic;

#nullable disable

namespace InstaDev_WebApi.Domains
{
    public partial class Publicacao
    {
        public int IdPublicacao { get; set; }
        public int? IdUsuario { get; set; }
        public byte[] ImagemPub { get; set; }
        public string Descricao { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
