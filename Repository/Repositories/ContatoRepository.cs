using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories{
    public class ContatoRepository : IContatoRepository
    {
        public bool Alterar(Contato contato)
        {
            throw new NotImplementedException();
        }

        public bool Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public int Inserir(Contato contato)
        {
            throw new NotImplementedException();
        }

        public Contato ObterPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contato> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
