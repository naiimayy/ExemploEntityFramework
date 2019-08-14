using Microsoft.EntityFrameworkCore;
using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories{
    public class ComputadorRepository : IComputadorRepository
    {
        private SistemaContext context;
        public ComputadorRepository(SistemaContext context)
        {
            this.context = context;
        }
        public bool Alterar(Computador computador)
        {
            computador.RegistroAtivo = true;
            context.Computadores.Update(computador);
            return context.SaveChanges() == 1;
        }

        public bool Apagar(int id)
        {
            var computador = context.Computadores.FirstOrDefault(y => y.Id == id);
            if (computador == null)
                return false;

            computador.RegistroAtivo = false;
            return context.SaveChanges() == 1;
        }

        public int Inserir(Computador computador)
        {
            computador.RegistroAtivo = true;
            context.Computadores.Add(computador);
            context.SaveChanges();
            return computador.Id;
        }

        public Computador ObterPeloId(int id)
        {
            return context.Computadores.Include(x=> x.Categoria).FirstOrDefault(x => x.Id == id && x.RegistroAtivo);
        }

        public List<Computador> ObterTodos()
        {
            return context.Computadores
                .Include(x=> x.Categoria)
                .Where(x => x.RegistroAtivo).ToList();
        }
    }
}
