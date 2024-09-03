<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbProductos = New System.Windows.Forms.ComboBox()
        Me.BtnCargar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label1.Location = New System.Drawing.Point(123, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(486, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inventario de Productos Bodega ""Doña Camila"""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Botón de Carga C. Box"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Selección Código del Producto"
        '
        'CmbProductos
        '
        Me.CmbProductos.BackColor = System.Drawing.Color.White
        Me.CmbProductos.ForeColor = System.Drawing.Color.Fuchsia
        Me.CmbProductos.FormattingEnabled = True
        Me.CmbProductos.Location = New System.Drawing.Point(251, 134)
        Me.CmbProductos.Name = "CmbProductos"
        Me.CmbProductos.Size = New System.Drawing.Size(167, 29)
        Me.CmbProductos.TabIndex = 6
        '
        'BtnCargar
        '
        Me.BtnCargar.BackColor = System.Drawing.Color.White
        Me.BtnCargar.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCargar.ForeColor = System.Drawing.Color.Fuchsia
        Me.BtnCargar.Location = New System.Drawing.Point(251, 75)
        Me.BtnCargar.Name = "BtnCargar"
        Me.BtnCargar.Size = New System.Drawing.Size(167, 36)
        Me.BtnCargar.TabIndex = 0
        Me.BtnCargar.Text = "Cargar Productos"
        Me.BtnCargar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.DoñaCamila.My.Resources.Resources._5
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtPrecio)
        Me.GroupBox1.Controls.Add(Me.TxtStock)
        Me.GroupBox1.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox1.Location = New System.Drawing.Point(12, 240)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(731, 144)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles del producto:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(299, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(197, 27)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Precio del Producto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(526, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 27)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stock del Producto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Thistle
        Me.Label4.Location = New System.Drawing.Point(21, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre del Producto:"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.ForeColor = System.Drawing.Color.Fuchsia
        Me.TxtPrecio.Location = New System.Drawing.Point(298, 88)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(177, 34)
        Me.TxtPrecio.TabIndex = 2
        '
        'TxtStock
        '
        Me.TxtStock.ForeColor = System.Drawing.Color.Fuchsia
        Me.TxtStock.Location = New System.Drawing.Point(530, 88)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(160, 34)
        Me.TxtStock.TabIndex = 1
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.ForeColor = System.Drawing.Color.Fuchsia
        Me.TxtDescripcion.Location = New System.Drawing.Point(13, 88)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(226, 34)
        Me.TxtDescripcion.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.DoñaCamila.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(499, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.BackgroundImage = Global.DoñaCamila.My.Resources.Resources._5
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(746, 426)
        Me.Controls.Add(Me.CmbProductos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCargar)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Purple
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Bodega Doña Camila"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCargar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents CmbProductos As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
