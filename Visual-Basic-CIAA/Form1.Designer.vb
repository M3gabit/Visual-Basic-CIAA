﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.LblConexion = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PgbConexion = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LblEstado = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CbxTiempoCh3 = New System.Windows.Forms.ComboBox()
        Me.CbxTiempoCh2 = New System.Windows.Forms.ComboBox()
        Me.CbxTiempoCh1 = New System.Windows.Forms.ComboBox()
        Me.ChxCh3 = New System.Windows.Forms.CheckBox()
        Me.ChxCh2 = New System.Windows.Forms.CheckBox()
        Me.ChxCh1 = New System.Windows.Forms.CheckBox()
        Me.TxtCh3 = New System.Windows.Forms.TextBox()
        Me.TxtCh2 = New System.Windows.Forms.TextBox()
        Me.TxtCh1 = New System.Windows.Forms.TextBox()
        Me.BtnRecibir = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConectarConLaCIAAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.SpPuerto = New System.IO.Ports.SerialPort(Me.components)
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TabControl1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(897, 342)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(897, 416)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.MenuStrip1)
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblConexion, Me.ToolStripLabel2, Me.ToolStripSeparator1, Me.PgbConexion, Me.ToolStripSeparator2, Me.LblEstado, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(897, 25)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 0
        '
        'LblConexion
        '
        Me.LblConexion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LblConexion.AutoSize = False
        Me.LblConexion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LblConexion.Image = Global.WindowsApplication1.My.Resources.Resources.equis
        Me.LblConexion.Name = "LblConexion"
        Me.LblConexion.Size = New System.Drawing.Size(22, 22)
        Me.LblConexion.Text = "ToolStripLabel1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripLabel2.Text = "Conectado:"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'PgbConexion
        '
        Me.PgbConexion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.PgbConexion.AutoSize = False
        Me.PgbConexion.Name = "PgbConexion"
        Me.PgbConexion.Size = New System.Drawing.Size(150, 22)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'LblEstado
        '
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(123, 22)
        Me.LblEstado.Text = "Estado: Desconectado"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(897, 342)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CbxTiempoCh3)
        Me.TabPage1.Controls.Add(Me.CbxTiempoCh2)
        Me.TabPage1.Controls.Add(Me.CbxTiempoCh1)
        Me.TabPage1.Controls.Add(Me.ChxCh3)
        Me.TabPage1.Controls.Add(Me.ChxCh2)
        Me.TabPage1.Controls.Add(Me.ChxCh1)
        Me.TabPage1.Controls.Add(Me.TxtCh3)
        Me.TabPage1.Controls.Add(Me.TxtCh2)
        Me.TabPage1.Controls.Add(Me.TxtCh1)
        Me.TabPage1.Controls.Add(Me.BtnRecibir)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(889, 316)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CbxTiempoCh3
        '
        Me.CbxTiempoCh3.FormattingEnabled = True
        Me.CbxTiempoCh3.Location = New System.Drawing.Point(670, 84)
        Me.CbxTiempoCh3.Name = "CbxTiempoCh3"
        Me.CbxTiempoCh3.Size = New System.Drawing.Size(121, 21)
        Me.CbxTiempoCh3.TabIndex = 9
        '
        'CbxTiempoCh2
        '
        Me.CbxTiempoCh2.FormattingEnabled = True
        Me.CbxTiempoCh2.Location = New System.Drawing.Point(528, 84)
        Me.CbxTiempoCh2.Name = "CbxTiempoCh2"
        Me.CbxTiempoCh2.Size = New System.Drawing.Size(121, 21)
        Me.CbxTiempoCh2.TabIndex = 8
        '
        'CbxTiempoCh1
        '
        Me.CbxTiempoCh1.FormattingEnabled = True
        Me.CbxTiempoCh1.Location = New System.Drawing.Point(392, 84)
        Me.CbxTiempoCh1.Name = "CbxTiempoCh1"
        Me.CbxTiempoCh1.Size = New System.Drawing.Size(121, 21)
        Me.CbxTiempoCh1.TabIndex = 7
        '
        'ChxCh3
        '
        Me.ChxCh3.AutoSize = True
        Me.ChxCh3.Location = New System.Drawing.Point(670, 43)
        Me.ChxCh3.Name = "ChxCh3"
        Me.ChxCh3.Size = New System.Drawing.Size(81, 17)
        Me.ChxCh3.TabIndex = 6
        Me.ChxCh3.Text = "CheckBox3"
        Me.ChxCh3.UseVisualStyleBackColor = True
        '
        'ChxCh2
        '
        Me.ChxCh2.AutoSize = True
        Me.ChxCh2.Location = New System.Drawing.Point(528, 43)
        Me.ChxCh2.Name = "ChxCh2"
        Me.ChxCh2.Size = New System.Drawing.Size(81, 17)
        Me.ChxCh2.TabIndex = 5
        Me.ChxCh2.Text = "CheckBox2"
        Me.ChxCh2.UseVisualStyleBackColor = True
        '
        'ChxCh1
        '
        Me.ChxCh1.AutoSize = True
        Me.ChxCh1.Location = New System.Drawing.Point(392, 45)
        Me.ChxCh1.Name = "ChxCh1"
        Me.ChxCh1.Size = New System.Drawing.Size(81, 17)
        Me.ChxCh1.TabIndex = 4
        Me.ChxCh1.Text = "CheckBox1"
        Me.ChxCh1.UseVisualStyleBackColor = True
        '
        'TxtCh3
        '
        Me.TxtCh3.Location = New System.Drawing.Point(232, 205)
        Me.TxtCh3.Multiline = True
        Me.TxtCh3.Name = "TxtCh3"
        Me.TxtCh3.Size = New System.Drawing.Size(100, 65)
        Me.TxtCh3.TabIndex = 3
        '
        'TxtCh2
        '
        Me.TxtCh2.Location = New System.Drawing.Point(233, 113)
        Me.TxtCh2.Multiline = True
        Me.TxtCh2.Name = "TxtCh2"
        Me.TxtCh2.Size = New System.Drawing.Size(100, 61)
        Me.TxtCh2.TabIndex = 2
        '
        'TxtCh1
        '
        Me.TxtCh1.Location = New System.Drawing.Point(232, 43)
        Me.TxtCh1.Multiline = True
        Me.TxtCh1.Name = "TxtCh1"
        Me.TxtCh1.Size = New System.Drawing.Size(100, 50)
        Me.TxtCh1.TabIndex = 1
        '
        'BtnRecibir
        '
        Me.BtnRecibir.Location = New System.Drawing.Point(75, 70)
        Me.BtnRecibir.Name = "BtnRecibir"
        Me.BtnRecibir.Size = New System.Drawing.Size(75, 23)
        Me.BtnRecibir.TabIndex = 0
        Me.BtnRecibir.Text = "Button1"
        Me.BtnRecibir.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(889, 316)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(897, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConectarConLaCIAAToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ConectarConLaCIAAToolStripMenuItem
        '
        Me.ConectarConLaCIAAToolStripMenuItem.Name = "ConectarConLaCIAAToolStripMenuItem"
        Me.ConectarConLaCIAAToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ConectarConLaCIAAToolStripMenuItem.Text = "Conectar con la CIAA"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator4, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(897, 25)
        Me.ToolStrip2.Stretch = True
        Me.ToolStrip2.TabIndex = 1
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(59, 22)
        Me.ToolStripButton1.Text = "Conectar"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripButton2.Text = "Desconectar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(43, 22)
        Me.ToolStripButton3.Text = "Iniciar"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(46, 22)
        Me.ToolStripButton4.Text = "Pausar"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton5.Text = "Detener"
        '
        'SpPuerto
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 416)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents LblConexion As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PgbConexion As ToolStripProgressBar
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents LblEstado As ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConectarConLaCIAAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents SpPuerto As IO.Ports.SerialPort
    Friend WithEvents BtnRecibir As Button
    Friend WithEvents TxtCh3 As TextBox
    Friend WithEvents TxtCh2 As TextBox
    Friend WithEvents TxtCh1 As TextBox
    Friend WithEvents CbxTiempoCh3 As ComboBox
    Friend WithEvents CbxTiempoCh2 As ComboBox
    Friend WithEvents CbxTiempoCh1 As ComboBox
    Friend WithEvents ChxCh3 As CheckBox
    Friend WithEvents ChxCh2 As CheckBox
    Friend WithEvents ChxCh1 As CheckBox
End Class
