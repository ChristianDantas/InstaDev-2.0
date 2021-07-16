using InstaDev_WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaDev_WebApi.Interfaces
{
    interface IPublicacaoRepository
    {
        void Cadastrar(Publicacao NovaPub);
        List<Publicacao> Listar();
        void AtualizaPub(int id, Publicacao PubAtt);
        List<Publicacao> ListarSeguido(Usuario Seguido, Usuario Seguidor);
    }
}
