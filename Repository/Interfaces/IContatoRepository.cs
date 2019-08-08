using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IContatoRepository
    {
        int Inserir(Contato contato);

        bool Alterar(Contato contato);

        List<Contato> ObterTodos();

        Contato ObterPeloId(int id);

        bool Apagar(int id);
    }
}