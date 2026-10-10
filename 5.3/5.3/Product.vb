Public Class Product
    Public Property ProductId As String
    Public Property ProductName As String
    Public Property UnitPrice As Decimal
    Public Property Quantity As Integer
    Public Property Category As String

    Public Sub New()
    End Sub

    Public Sub New(productId As String, productName As String, unitPrice As Decimal, quantity As Integer, category As String)
        Me.ProductId = productId
        Me.ProductName = productName
        Me.UnitPrice = unitPrice
        Me.Quantity = quantity
        Me.Category = category
    End Sub
End Class
