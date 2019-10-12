using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Jerry.BookStore.Controllers;

namespace Jerry.BookStore.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : BookStoreControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
