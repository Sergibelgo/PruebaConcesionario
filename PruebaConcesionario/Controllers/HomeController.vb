

Public Class HomeController
    Inherits System.Web.Mvc.Controller
    Private ReadOnly _db As New ConcesionarioEntities()
    Function Index() As ActionResult
        Dim prueba = _db.cars.ToList()
        Return View(prueba)
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
