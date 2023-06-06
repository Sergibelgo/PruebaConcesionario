Imports System.Web.Mvc

Namespace Controllers
    Public Class CarsController
        Inherits Controller
        Private ReadOnly _service As New CarsService()
        ' GET: cars
        Function Index() As ActionResult
            Return View()
        End Function

        ' GET: cars/Details/5
        Function Details(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' GET: cars/Create
        Async Function Create() As Threading.Tasks.Task(Of ActionResult)
            Dim enums = Await _service.GetEnums()
            ViewData("Combustion") = enums.fuelEnum
            ViewData("Marchas") = enums.gearEnum
            Return View()
        End Function

        ' POST: cars/Create
        <HttpPost()>
        Function Create(ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add insert logic here

                Return RedirectToAction("Index")
            Catch
                Return View(collection)
            End Try
        End Function

        ' GET: cars/Edit/5
        Function Edit(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: cars/Edit/5
        <HttpPost()>
        Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add update logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: cars/Delete/5
        Function Delete(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: cars/Delete/5
        <HttpPost()>
        Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add delete logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function
    End Class
End Namespace