Imports System.Web.Mvc
Imports System.Web.Routing

Namespace MvcQueryBuilder

    Public Class RouteConfig

        Public Shared Sub RegisterRoutes(ByVal routes As RouteCollection)
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}")
            routes.IgnoreRoute("{resource}.ashx/{*pathInfo}")
            routes.MapRoute(name:="Default", url:="{controller}/{action}/{id}", defaults:=New With {.controller = "Home", .action = "Index", .id = UrlParameter.Optional}) ' Route name
        ' URL with parameters
        ' Parameter defaults
        End Sub
    End Class
End Namespace
