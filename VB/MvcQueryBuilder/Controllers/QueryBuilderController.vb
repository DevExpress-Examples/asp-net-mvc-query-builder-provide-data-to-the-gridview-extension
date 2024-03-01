Imports System.Web.Mvc
Imports DevExpress.Web.Mvc

Namespace MvcQueryBuilder.Controllers

    ' Processes Query Builder requests.
    Public Class QueryBuilderController
        Inherits DevExpress.Web.Mvc.Controllers.QueryBuilderApiControllerBase

        Public Overrides Function Invoke() As ActionResult
            Return MyBase.Invoke()
        End Function

        Public Function Save() As ActionResult
            Dim result = QueryBuilderExtension.GetSaveCallbackResult("QueryBuilder")
            Session("SelectCommand") = result.SelectStatement
            Return RedirectToAction("Index", "Home")
        End Function
    End Class
End Namespace
