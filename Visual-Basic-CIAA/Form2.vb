Public Class Form2
    Private Sub BtnBuscarPuertos_Click(sender As Object, e As EventArgs) Handles BtnBuscarPuertos.Click
        Call Form1.BtnBuscarPuertos_Click(sender, e)
    End Sub

    Private Sub BtnConectar2_Click(sender As Object, e As EventArgs) Handles BtnConectar2.Click
        Call Form1.BtnConectar_Click(sender, e)
    End Sub
End Class