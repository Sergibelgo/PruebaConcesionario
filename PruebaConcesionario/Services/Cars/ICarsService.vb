Imports System.Threading.Tasks

Public Interface ICarsService
    Function GetEnums() As Task(Of EnumsDTO)
    Function CreateCarAsync(car As car) As Task
    Function UpdateCar(id As Integer, car As car) As car
    Sub DeleteCar(id As Integer)
    Function GetCar(id As Integer) As car
End Interface
