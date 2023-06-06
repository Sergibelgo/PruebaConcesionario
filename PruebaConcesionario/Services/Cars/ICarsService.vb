Imports System.Threading.Tasks

Public Interface ICarsService
    Function GetEnums() As Task(Of EnumsDTO)
    Sub CreateCar(car As car)
    Function UpdateCar(id As Integer, car As car) As car
    Sub DeleteCar(id As Integer)
    Function GetCar(id As Integer) As car
End Interface
