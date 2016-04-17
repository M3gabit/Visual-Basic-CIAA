Public Class Form1
    Dim VarConectar As Boolean = True
    Dim aux As Integer

    Private Sub BtnConectar_Click(sender As Object, e As EventArgs)
        If VarConectar Then
            Try
                With SpPuerto
                    .BaudRate = 115200
                    .DataBits = 8
                    .Parity = IO.Ports.Parity.None
                    .StopBits = IO.Ports.StopBits.One
                    .PortName = CboPuertos.Text
                    .Encoding = System.Text.Encoding.ASCII
                    '.ReceivedBytesThreshold = 5
                    .Open()
                End With
                VarConectar = False


            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try

        Else

            VarConectar = True

            PtbEstado.Image = My.Resources.equis
            SpPuerto.Write("desconectar" + Chr(0))
            Threading.Thread.Sleep(300)

            SpPuerto.Dispose()
            SpPuerto.Close()

        End If

        CheckForIllegalCrossThreadCalls = False
        If SpPuerto.IsOpen = True Then
            SpPuerto.Write("iniciar" + Chr(0))

            While (aux <= 100)
                aux = aux + 10
                PgbConexion.Increment(12)
                Threading.Thread.Sleep(300)
            End While
            aux = 0
            PgbConexion.Increment(-100)

            If (Conexion = "123ok" + vbCr) Then
                PtbEstado.Image = My.Resources.tilde

            End If

        End If
    End Sub
End Class
