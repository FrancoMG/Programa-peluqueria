<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.btnClientas = New System.Windows.Forms.Button()
        Me.btnTrabajo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClientas
        '
        resources.ApplyResources(Me.btnClientas, "btnClientas")
        Me.btnClientas.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnClientas.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.btnClientas.Name = "btnClientas"
        Me.btnClientas.UseVisualStyleBackColor = False
        '
        'btnTrabajo
        '
        resources.ApplyResources(Me.btnTrabajo, "btnTrabajo")
        Me.btnTrabajo.BackColor = System.Drawing.Color.Transparent
        Me.btnTrabajo.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.btnTrabajo.Name = "btnTrabajo"
        Me.btnTrabajo.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        resources.ApplyResources(Me.btnSalir, "btnSalir")
        Me.btnSalir.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmInicio
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnTrabajo)
        Me.Controls.Add(Me.btnClientas)
        Me.DoubleBuffered = True
        Me.Name = "frmInicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClientas As Button
    Friend WithEvents btnTrabajo As Button
    Friend WithEvents btnSalir As Button
End Class
