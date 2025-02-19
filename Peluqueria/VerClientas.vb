Imports System.CodeDom
Imports System.Net.Mime

Public Class frmClientas

    Dim Cantfilas As Integer
    Dim NombreT As String
    Dim PrecioT As Integer
    Dim FechaT As Date

    Private Sub frmClientas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select idtratamiento from tratamiento where nombre = '" & Clienta & "'"
        Call ejecutar(sql)
        While rs.Read
            switch = 2
            sql = "select nombreTratamiento from tratamiento where idtratamiento = '" & rs(0) & "'"
            Call ejecutar(sql)
            rs2.Read()
            NombreT = rs2(0)
            sql = "select precio from tratamiento where idtratamiento = '" & rs(0) & "'"
            Call ejecutar(sql)
            rs2.Read()
            PrecioT = rs2(0)
            sql = "select fecha from tratamiento where idtratamiento = '" & rs(0) & "'"
            Call ejecutar(sql)
            rs2.Read()
            FechaT = rs2(0)

            dgvClientas.Rows.Add()
            Cantfilas = dgvClientas.Rows.Count - 1

            dgvClientas.Item(0, Cantfilas).Value = NombreT
            dgvClientas.Item(1, Cantfilas).Value = PrecioT
            dgvClientas.Item(2, Cantfilas).Value = Format(FechaT, "yyyy/MM/dd")


        End While
        switch = 1

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
        frmInicio.Show()

    End Sub

    Private Sub dgvClientas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientas.CellContentClick

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)

    End Sub
End Class