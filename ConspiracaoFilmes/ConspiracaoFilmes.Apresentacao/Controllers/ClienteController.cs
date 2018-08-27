using ConspiracaoFilmes.Application.Interface;
using ConspiracaoFilmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using ConspiracaoFilmes.Domain.Commons.Helpers;
using ConspiracaoFilmes.Domain.Commons.Enums;
using ConspiracaoFilmes.Application.Models;

namespace ConspiracaoFilmes.Apresentacao.Controllers
{
    public class ClienteController : BaseController
    {
        private readonly IAppServiceCliente _appService;
        public ClienteController(IAppServiceCliente appService)
        {
            _appService = appService;
        }
        // GET: Cliente

        public ActionResult Create()
        {
            return PartialView(new ClienteModel());
        }


        public ActionResult Edit(int id)
        {
            ClienteModel model = AutoMapper.Mapper.Map<Cliente, ClienteModel>(_appService.GetById(id));
            return PartialView(model);
        }


        public ActionResult GetClientes()
        {
            List<ClienteModel> retorno = AutoMapper.Mapper.Map<List<Cliente>, List<ClienteModel>>(_appService.GetAll().ToList());
        
            return Json(retorno, JsonRequestBehavior.AllowGet);
        }
        //public ActionResult GetClientes()
        //{
        //    List<ClienteModel> retorno = AutoMapper.Mapper.Map<List<Cliente>, List<ClienteModel>>(_appService.GetAll().ToList());
        //    return PartialView(retorno);
        //}


        [HttpPost]
        public ActionResult Create(ClienteModel model)
        {
            try
            {
                Cliente c = AutoMapper.Mapper.Map<ClienteModel, Cliente>(model);
                _appService.Add(c);
                return ResponseServerStatus(new ServerStatus() { status = StatusMensagem.ok, mensagem = "Cliente adicionado com sucesso" });

            }
            catch (Exception ex)
            {

                return ResponseServerStatus(new ServerStatus() { status = StatusMensagem.erro, mensagem = ex.Message });
            }

        }

        [HttpPost]
        public ActionResult Edit(ClienteModel model)
        { 
            try
            {
                _appService.EditarCliente(model);
                return ResponseServerStatus(new ServerStatus() { status = StatusMensagem.ok, mensagem = "Cliente editado com sucesso" });

            }
            catch (Exception ex)
            {

                return ResponseServerStatus(new ServerStatus() { status = StatusMensagem.erro, mensagem = ex.Message });
            }

        }
        public ActionResult Index()
        {
            return View();
        }
    }
}