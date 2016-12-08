<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscarPuertos = New System.Windows.Forms.Button()
        Me.CbxPuertos = New System.Windows.Forms.ComboBox()
        Me.BtnConectar2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnConectar2)
        Me.GroupBox1.Controls.Add(Me.CbxPuertos)
        Me.GroupBox1.Controls.Add(Me.BtnBuscarPuertos)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 142)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'BtnBuscarPuertos
        '
        Me.BtnBuscarPuertos.Location = New System.Drawing.Point(16, 30)
        Me.BtnBuscarPuertos.Name = "BtnBuscarPuertos"
        Me.BtnBuscarPuertos.Size = New System.Drawing.Size(143, 35)
        Me.BtnBuscarPuertos.TabIndex = 0
        Me.BtnBuscarPuertos.Text = "Buscar Puertos"
        Me.BtnBuscarPuertos.UseVisualStyleBackColor = True
        '
        'CbxPuertos
        '
        Me.CbxPuertos.FormattingEnabled = True
        Me.CbxPuertos.Location = New System.Drawing.Point(180, 86)
        Me.CbxPuertos.Name = "CbxPuertos"
        Me.CbxPuertos.Size = New System.Drawing.Size(168, 21)
        Me.CbxPuertos.TabIndex = 1
        '
        'BtnConectar2
        '
        Me.BtnConectar2.Location = New System.Drawing.Point(16, 86)
        Me.BtnConectar2.Name = "BtnConectar2"
        Me.BtnConectar2.Size = New System.Drawing.Size(139, 33)
        Me.BtnConectar2.TabIndex = 2
        Me.BtnConectar2.Text = "Conectar"
        Me.BtnConectar2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 169)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnConectar2 As Button
    Friend WithEvents CbxPuertos As ComboBox
    Friend WithEvents BtnBuscarPuertos As Button
End Class
