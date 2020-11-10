using System.Web.Mvc;

namespace BookStore.Controllers
{
    [RoutePrefix("autores")]
    public class AuthorController : Controller
    {
        [Route("listar")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("criar")]
        public ActionResult Create()
        {
            return View();
        }

        [Route("editar/{id:int}")]
        public ActionResult Edit()
        {
            return View();
        }


        [Route("excluir/{id:int}")]
        [Route()]
        public ActionResult Delete()
        {
            return View();
        }

    }
}