<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClientas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientas))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.dgvClientas = New System.Windows.Forms.DataGridView()
        Me.TratamientoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvClientas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVolver.AutoSize = True
        Me.btnVolver.BackColor = System.Drawing.Color.Transparent
        Me.btnVolver.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnVolver.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.btnVolver.Location = New System.Drawing.Point(493, 508)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(58, 30)
        Me.btnVolver.TabIndex = 3
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'dgvClientas
        '
        Me.dgvClientas.AllowUserToAddRows = False
        Me.dgvClientas.AllowUserToDeleteRows = False
        Me.dgvClientas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvClientas.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvClientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TratamientoC, Me.PrecioC, Me.FechaC})
        Me.dgvClientas.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dgvClientas.Location = New System.Drawing.Point(99, 43)
        Me.dgvClientas.Name = "dgvClientas"
        Me.dgvClientas.ReadOnly = True
        Me.dgvClientas.RowTemplate.Height = 25
        Me.dgvClientas.Size = New System.Drawing.Size(374, 416)
        Me.dgvClientas.TabIndex = 5
        '
        'TratamientoC
        '
        Me.TratamientoC.HeaderText = "Tratamiento"
        Me.TratamientoC.Name = "TratamientoC"
        Me.TratamientoC.ReadOnly = True
        Me.TratamientoC.Width = 160
        '
        'PrecioC
        '
        Me.PrecioC.HeaderText = "Precio"
        Me.PrecioC.Name = "PrecioC"
        Me.PrecioC.ReadOnly = True
        Me.PrecioC.Width = 80
        '
        'FechaC
        '
        Me.FechaC.HeaderText = "Fecha"
        Me.FechaC.Name = "FechaC"
        Me.FechaC.ReadOnly = True
        Me.FechaC.Width = 90
        '
        'frmClientas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Peluqueria.My.Resources.Resources.Captura_de_pantalla_20221024_234909
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(564, 541)
        Me.Controls.Add(Me.dgvClientas)
        Me.Controls.Add(Me.btnVolver)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmClientas"
        Me.Text = "VerClientas"
        CType(Me.dgvClientas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As Button
    Friend WithEvents dgvClientas As DataGridView
    Friend WithEvents TratamientoC As DataGridViewTextBoxColumn
    Friend WithEvents PrecioC As DataGridViewTextBoxColumn
    Friend WithEvents FechaC As DataGridViewTextBoxColumn
End Class
