using System.Configuration;
using System.Web.Mvc;

namespace MvcQueryBuilder.Controllers
{
    public class HomeController : Controller {
        string NorthwindConnectionString {
            get {
                return ConfigurationManager.ConnectionStrings["NorthwindConnection"].ConnectionString;
            }
        }
        System.Web.UI.WebControls.SqlDataSource DataSource {
            get {
                var select = @"select [Suppliers].[CompanyName] from [dbo].[Suppliers]";
                if (Session["SelectCommand"] != null) {
                    select = Session["SelectCommand"] as string;
                }
                return new System.Web.UI.WebControls.SqlDataSource(NorthwindConnectionString, select);
            }
        }

        public ActionResult Index() {
            return View(DataSource);
        }

        public ActionResult QueryBuilder() {
            return View("QueryBuilder");
        }
        public ActionResult GridViewPartial() {
            return PartialView(DataSource);
        }
    }
}