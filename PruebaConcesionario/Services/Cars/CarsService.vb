Imports System.Data.Entity

Public Class CarsService
    Implements ICarsService
    Private ReadOnly _db As New ConcesionarioEntities()

    Public Sub CreateCar(car As car) Implements ICarsService.CreateCar
        Throw New NotImplementedException()
    End Sub

    Public Sub DeleteCar(id As Integer) Implements ICarsService.DeleteCar
        Throw New NotImplementedException()
    End Sub

    Public Async Function GetEnums() As Threading.Tasks.Task(Of EnumsDTO) Implements ICarsService.GetEnums
        Dim fuels = Await _db.enum_fuel.Select(Function(t) New SelectListItem With {.Text = t.name, .Value = t.id}).ToListAsync()
        Dim gearBoxes = Await _db.enum_gearbox.Select(Function(t) New SelectListItem With {.Text = t.name, .Value = t.id, .Selected = False}).ToListAsync()
        Dim enums = New EnumsDTO(gearBoxes, fuels)
        Return enums
    End Function
    Private Function generateSelectListItem(value As Integer, name As String) As SelectListItem
        Dim output As SelectListItem = New SelectListItem With {
            .Text = name,
            .Value = value
        }
        Return output
    End Function
    Public Function UpdateCar(id As Integer, car As car) As car Implements ICarsService.UpdateCar
        Throw New NotImplementedException()
    End Function

    Public Function GetCar(id As Integer) As car Implements ICarsService.GetCar
        Throw New NotImplementedException()
    End Function
End Class
