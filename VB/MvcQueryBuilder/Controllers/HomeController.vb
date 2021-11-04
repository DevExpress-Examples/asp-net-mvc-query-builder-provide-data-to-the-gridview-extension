Imports System.Configuration
Imports System.Web.Mvc

Namespace MvcQueryBuilder.Controllers
	Public Class HomeController
		Inherits Controller

		Private ReadOnly Property NorthwindConnectionString() As String
			Get
				Return ConfigurationManager.ConnectionStrings("NorthwindConnection").ConnectionString
			End Get
		End Property
		Private ReadOnly Property DataSource() As System.Web.UI.WebControls.SqlDataSource
			Get
				Dim [select] = "select [Suppliers].[CompanyName] from [dbo].[Suppliers]"
				If Session("SelectCommand") IsNot Nothing Then
					[select] = TryCast(Session("SelectCommand"), String)
				End If
				Return New System.Web.UI.WebControls.SqlDataSource(NorthwindConnectionString, [select])
			End Get
		End Property

		Public Function Index() As ActionResult
			Return View(DataSource)
		End Function

		Public Function QueryBuilder() As ActionResult
			Return View("QueryBuilder")
		End Function
		Public Function GridViewPartial() As ActionResult
			Return PartialView(DataSource)
		End Function
	End Class
End Namespace