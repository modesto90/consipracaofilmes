using ConspiracaoFilmes.Application.Interface;
using ConspiracaoFilmes.Application.Models;
using ConspiracaoFilmes.Domain.Commons.Enums;
using ConspiracaoFilmes.Domain.Commons.Helpers;
using ConspiracaoFilmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConspiracaoFilmes.Apresentacao.Controllers
{
    public class ProdutoController : BaseController
    {
        private readonly IAppServiceProduto _appService;
        public ProdutoController(IAppServiceProduto appService)
        {
            _appService = appService;
        }


        public ActionResult Create()
        {
            return View(new ProdutoModel());
        }

        public ActionResult Edit(int idProduto)
        {
            Produto p = _appService.GetById(idProduto);
            ProdutoModel model = AutoMapper.Mapper.Map<Produto, ProdutoModel>(p);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(ProdutoModel model)
        {
            _appService.AtualizarProduto(model);
            return ResponseServerStatus(new ServerStatus() { status = StatusMensagem.ok, mensagem = "Produto atualizado com sucesso" });
        }

        public ActionResult GetProdutos()
        {
            return PartialView(_appService.GetProdutos());
        }

        [HttpPost]
        public ActionResult Create(ProdutoModel model)
        {
            _appService.AdicionarProduto(model);
            return ResponseServerStatus(new ServerStatus() { status = StatusMensagem.ok, mensagem = "Produto adicionado com sucesso" });

        }
    }
}