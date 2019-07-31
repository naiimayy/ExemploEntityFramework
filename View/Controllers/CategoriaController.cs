using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace View.Controllers
{
    public class CategoriaController : Controller
    {
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
        [HttpGet, Route("ObterTodos")]
        public IActionResult ObterTodos(
            string busca = "", int quantidade = 10, int pagina = 0,
            string ColunaOrdem = "nome", string ordem="ASC")
        {
            return Ok(); 
        }
    }
}
