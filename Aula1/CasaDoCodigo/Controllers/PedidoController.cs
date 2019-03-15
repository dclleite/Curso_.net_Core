using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CasaDoCodigo.Models;
using CasaDoCodigo.Repositories;

namespace CasaDoCodigo.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IProdutoRepository produtoRepository;

        public PedidoController(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        public IActionResult Carrossel(){
            return View(produtoRepository.GetProdutos());
        }
        public IActionResult Carrinho(){
            return View();
        }
        public IActionResult Cadastro(){
            return View();
        }
        public IActionResult Resumo(){
            return View();
        }
    }
}