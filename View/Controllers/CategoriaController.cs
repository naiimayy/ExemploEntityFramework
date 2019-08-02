﻿using Microsoft.AspNetCore.Mvc;
using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace View.Controllers
{
    public class CategoriaController : Controller
    {
        private ICategoriaRepository repository;

        public CategoriaController(ICategoriaRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IActionResult index()
        {
            return View();
        }
        /// <summary>
        /// Método que permitirá ter acesso aos dados das categorias,
        /// filtrando, ordenando e paginando informações de acodrdo com os parametros.
        /// </summary>
        /// <param name="busca"></param>
        /// <param name="quantidade"></param>
        /// <param name="pagina"></param>
        /// <param name="ColunaOrdem"></param>
        /// <param name="ordem"></param>
        /// <returns>Retorna as categorias</returns>
        
        [HttpGet, Route("categoria/ObterTodos")]
        public JsonResult ObterTodos(
            string busca = "", int quantidade = 10, int pagina = 0,
            string colunaOrdem = "nome", string ordem="ASC")
        {
            List<Categoria> categorias = repository.ObterTodos(quantidade, pagina, busca, colunaOrdem, ordem);

            return Json(new { data = categorias }); 
        }

        [HttpPost]
        public JsonResult Cadastrar([FromBody]Categoria categoria)
        {
            categoria.RegistroAtivo = true;
            int id = repository.Inserir(categoria);
            // objeto anonimo
            var retorno = new { id = id };
            return Json(retorno);
        }

        [HttpPost]
        public JsonResult Alterar([FromBody]Categoria categoria)
        {
            bool alterado = repository.Alterar(categoria);
            var resultado = new { status = alterado };
            return Json(resultado);
        }

        [HttpGet]
        public JsonResult Apagar(int id)
        {
            bool apagou = repository.Apagar(id);
            var resultado = new { status = apagou };
            return Json(resultado);
        }
    }
}
