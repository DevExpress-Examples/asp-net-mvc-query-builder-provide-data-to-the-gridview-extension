using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace MvcQueryBuilder.Controllers {
    // Processes Query Builder requests.
    public class QueryBuilderController : DevExpress.Web.Mvc.Controllers.QueryBuilderApiControllerBase {
        public override ActionResult Invoke() {
            return base.Invoke();
        }

        public ActionResult Save() {
            var result = QueryBuilderExtension.GetSaveCallbackResult("QueryBuilder");
            Session["SelectCommand"] = result.SelectStatement;
            return RedirectToAction("Index", "Home");
        }
    }
}