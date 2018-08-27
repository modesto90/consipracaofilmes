using ConspiracaoFilmes.Domain.Commons.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConspiracaoFilmes.Apresentacao.Controllers
{
    public class BaseController : Controller
    {
    public JsonResult ResponseServerStatus(ServerStatus ss)
    {
        return Json(new { status = ss.status, mensagem = ss.mensagem}, JsonRequestBehavior.AllowGet);
    }

}
}