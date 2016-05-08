Public Class Form1
    Dim VarConectar As Boolean = True
    Dim StrBufferEntrada As String
    Dim VarConexion As String
    Dim aux As Integer
    Dim VarRecibir As Boolean = False
    Dim Tiempos() As Integer = {100, 200, 300, 400, 500, 600, 700, 800, 900, 1000}

    Dim Vector1(1000) As Double
    Dim Vector2(1000) As Double
    Dim Vector3(1000) As Double

    Dim BMP As New Drawing.Bitmap(1000, 300)
    Dim GFX As Graphics = Graphics.FromImage(BMP)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Form2.BtnConectar2.Enabled = False
        For i = 0 To 9
            CbxTiempoCh1.Items.Add(Convert.ToString(Tiempos(i)))
            CbxTiempoCh2.Items.Add(Convert.ToString(Tiempos(i)))
            CbxTiempoCh3.Items.Add(Convert.ToString(Tiempos(i)))
        Next
        CbxTiempoCh1.Text = CbxTiempoCh1.Items(0)
        CbxTiempoCh2.Text = CbxTiempoCh1.Items(0)
        CbxTiempoCh3.Text = CbxTiempoCh1.Items(0)

        For t = 0 To 999
            Vector1(t) = 100 * Math.Sin(2 * 3.14 * 5 * t / 500) '5 ciclos en los 500 valores
            Vector2(t) = 100 * Math.Sin(2 * 3.14 * 5 * t / 500 + 2.09) '5 ciclos en los 500 valores
            Vector3(t) = 100 * Math.Sin(2 * 3.14 * 5 * t / 500 + 4.18) 'Esos valores sumados es el desfasage en radianes
        Next t




    End Sub


    Public Sub BtnBuscarPuertos_Click(sender As Object, e As EventArgs)

        Form2.CbxPuertos.Items.Clear()

        For Each PuertoDisponible As String In My.Computer.Ports.SerialPortNames
            Form2.CbxPuertos.Items.Add(PuertoDisponible)
        Next

        If Form2.CbxPuertos.Items.Count > 0 Then
            Form2.CbxPuertos.Text = Form2.CbxPuertos.Items(0)
            If Form2.CbxPuertos.Items.Count = 1 Then
                MessageBox.Show("Encontrado 1 puerto")
            End If

            If Form2.CbxPuertos.Items.Count > 1 Then
                MessageBox.Show("Encontrado " + Convert.ToString(Form2.CbxPuertos.Items.Count) + " puertos")
            End If

            Form2.BtnConectar2.Enabled = True
        Else
            MessageBox.Show("Ningun puerto encontrado")
            Form2.BtnConectar2.Enabled = False

            Form2.CbxPuertos.Items.Clear()
        End If
    End Sub

    Public Sub BtnConectar_Click(sender As Object, e As EventArgs)

        Form2.Hide()

        If VarConectar Then
            Try
                With SpPuerto
                    .BaudRate = 115200
                    .DataBits = 8
                    .Parity = IO.Ports.Parity.None
                    .StopBits = IO.Ports.StopBits.One
                    .PortName = Form2.CbxPuertos.Text
                    .Encoding = System.Text.Encoding.ASCII
                    .ReceivedBytesThreshold = 6
                    .Open()
                End With
                VarConectar = False

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try

        Else
            VarConectar = True
            LblConexion.Image = My.Resources.equis
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

            If (VarConexion = "123ok" + vbCrLf) Then
                LblConexion.Image = My.Resources.tilde
                LblEstado.Text = "Estado Conectado"

            End If

        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        VarConectar = True
        LblConexion.Image = My.Resources.equis
        SpPuerto.Write("desconectar" + Chr(0))
        Threading.Thread.Sleep(300)

        SpPuerto.Dispose()
        SpPuerto.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Form2.Show()
    End Sub

    Private Sub DatoRecibido(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SpPuerto.DataReceived
        Dim Numero As Double
        Dim Valor As Double
        Dim StrAux As String
        VarConexion = SpPuerto.ReadExisting


        If VarRecibir Then
            StrBufferEntrada = VarConexion
            'TxtDatosRecibidos.Text = StrBufferEntrada

            If StrBufferEntrada <> "" Then


                If StrBufferEntrada(0) = "A" Then
                    StrAux = StrBufferEntrada.Substring(1)
                    If StrAux <> "" Then
                        Try
                            Numero = Convert.ToDouble(StrAux)
                            Valor = Math.Round(((Numero * 3.3) / 1023), 2)
                            TxtCh1.Text = Valor.ToString

                        Catch ex As Exception

                        End Try

                    End If
                End If


                If StrBufferEntrada(0) = "B" Then
                    StrAux = StrBufferEntrada.Substring(1)
                    If StrAux <> "" Then
                        'TxtDatosRecibidos.Text = StrAux
                        Try
                            Numero = Convert.ToDouble(StrAux)
                            Valor = Math.Round(((Numero * 3.3) / 1023), 2)
                            TxtCh2.Text = Valor.ToString

                        Catch ex As Exception

                        End Try

                    End If
                End If

                If StrBufferEntrada(0) = "C" Then
                    StrAux = StrBufferEntrada.Substring(1)
                    If StrAux <> "" Then
                        'TxtDatosRecibidos2.Text = StrAux
                        Try
                            Numero = Convert.ToDouble(StrAux)
                            Valor = Math.Round(((Numero * 3.3) / 1023), 2)
                            TxtCh3.Text = Valor.ToString
                        Catch ex As Exception
                        End Try

                    End If
                End If

            End If

            If SpPuerto.IsOpen Then
                SpPuerto.DiscardInBuffer()
            End If

        End If
    End Sub

    Private Sub ChxCh1_CheckedChanged(sender As Object, e As EventArgs) Handles ChxCh1.CheckedChanged
        If ChxCh1.Checked = True Then
            SpPuerto.DiscardOutBuffer()
            SpPuerto.Write("ch1_on" + Chr(0))
            Threading.Thread.Sleep(300)
            If Convert.ToInt16(CbxTiempoCh1.Text) > 950 Then
                SpPuerto.Write(CbxTiempoCh1.Text + Chr(0))
            Else
                SpPuerto.Write("0" + CbxTiempoCh1.Text + Chr(0))
            End If
            CbxTiempoCh1.Enabled = False

        Else
            SpPuerto.DiscardOutBuffer()
            SpPuerto.Write("ch1_off" + Chr(0))
            CbxTiempoCh1.Enabled = True
        End If

    End Sub

    Private Sub ChxCh2_CheckedChanged(sender As Object, e As EventArgs) Handles ChxCh2.CheckedChanged
        If ChxCh2.Checked = True Then
            SpPuerto.DiscardOutBuffer()
            SpPuerto.Write("ch2_on" + Chr(0))
            Threading.Thread.Sleep(300)
            If Convert.ToInt16(CbxTiempoCh2.Text) > 950 Then
                SpPuerto.Write(CbxTiempoCh2.Text + Chr(0))
            Else
                SpPuerto.Write("0" + CbxTiempoCh2.Text + Chr(0))
            End If
            CbxTiempoCh2.Enabled = False

        Else
            SpPuerto.DiscardOutBuffer()
            SpPuerto.Write("ch2_off" + Chr(0))
            CbxTiempoCh2.Enabled = True
        End If
    End Sub

    Private Sub ChxCh3_CheckedChanged(sender As Object, e As EventArgs) Handles ChxCh3.CheckedChanged

        If ChxCh3.Checked = True Then
            SpPuerto.DiscardOutBuffer()
            SpPuerto.Write("ch3_on" + Chr(0))
            Threading.Thread.Sleep(300)
            If Convert.ToInt16(CbxTiempoCh3.Text) > 950 Then
                SpPuerto.Write(CbxTiempoCh3.Text + Chr(0))
            Else
                SpPuerto.Write("0" + CbxTiempoCh3.Text + Chr(0))
            End If
            CbxTiempoCh3.Enabled = False

        Else
            SpPuerto.DiscardOutBuffer()
            SpPuerto.Write("ch3_off" + Chr(0))
            CbxTiempoCh3.Enabled = True
        End If

    End Sub

    Private Sub ConectarConLaCIAAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConectarConLaCIAAToolStripMenuItem.Click
        Call ToolStripButton1_Click(sender, e)
    End Sub


    Private Sub ToolStripBtn_Iniciar_Click(sender As Object, e As EventArgs) Handles ToolStripBtn_Iniciar.Click
        VarRecibir = True
        LblEstado.Text = "Estado: Recibiendo"
    End Sub

    Private Sub ToolStripBtn_Pausar_Click(sender As Object, e As EventArgs) Handles ToolStripBtn_Pausar.Click
        VarRecibir = False
        LblEstado.Text = "Estado: En pausa"
    End Sub

    Private Sub ToolStripBtn_Detener_Click(sender As Object, e As EventArgs) Handles ToolStripBtn_Detener.Click
        VarRecibir = False
        LblEstado.Text = "Estado: Detenido"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GFX.FillRectangle(Brushes.LightGray, 0, 0, PictureBox1.Width, PictureBox1.Height)
        'Grafico de la grilla (Horizontales)
        For i = 0 To 9
            GFX.DrawLine(Pens.White, 0, Convert.ToSingle(PictureBox1.Height / 10 * i), PictureBox1.Width, Convert.ToSingle(PictureBox1.Height / 10 * i))
        Next

        'Grafico de la grilla(Verticales)
        For i = 0 To 9
            GFX.DrawLine(Pens.White, Convert.ToSingle(PictureBox1.Width / 10 * i), 0, Convert.ToSingle(PictureBox1.Width / 10 * i), PictureBox1.Width)
        Next
        'GFX.DrawLine(Pens.LightGray, 0, PictureBox1.Height - 1, PictureBox1.Width, PictureBox1.Height - 1)
        'GFX.DrawLine(Pens.LightGray, PictureBox1.Width - 1, 0, PictureBox1.Width - 1, PictureBox1.Width)

        For i = 0 To 649
            GFX.DrawLine(Pens.Red, i, Convert.ToSingle(Vector1(i) + 125), i + 1, Convert.ToSingle(Vector1(i + 1) + 125))

        Next


        PictureBox1.Image = BMP
    End Sub
End Class
