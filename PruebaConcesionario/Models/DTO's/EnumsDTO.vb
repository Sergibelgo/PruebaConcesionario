Public Class EnumsDTO
    Public fuelEnum As IEnumerable(Of SelectListItem)
    Public gearEnum As IEnumerable(Of SelectListItem)

    Public Sub New(gearEnum As IEnumerable(Of SelectListItem), fuelEnum As IEnumerable(Of SelectListItem))
        Me.gearEnum = gearEnum
        Me.fuelEnum = fuelEnum
    End Sub
End Class
