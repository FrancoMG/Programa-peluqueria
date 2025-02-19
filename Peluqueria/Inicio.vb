Imports System.Data.Odbc

Public Class frmInicio

    Dim NombreC As String
    Dim sql2 As String
    Dim sql3 As String
    Dim sql4 As String
    Dim sql5 As String
    Dim FechaA As Date


    Private Sub frmInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conexion = New OdbcConnection("DSN=CLIENTAS")
            conexion.Open()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnTrabajo_Click(sender As Object, e As EventArgs) Handles btnTrabajo.Click

        NombreC = InputBox("Ingrese el nombre de la persona")
        sql = "select count(nombre) from Clientas where nombre = '" & NombreC & "'"
        Call ejecutar(sql)
        rs.Read()

        If rs(0) = 0 Then
            Dim Respuesta = MsgBox("La persona ingresada no esta registrada" & vbCrLf & "¿Desea registrar a esta persona?", MsgBoxStyle.YesNo, "Registrar usuario")

            If Respuesta = MsgBoxResult.Yes Then
                sql = "insert into CLientas values('" & NombreC & "')"
                Call ejecutar(sql)
                rs.Read()
                MsgBox("Se ha registrado correctamente a la persona", MsgBoxStyle.OkOnly, "Persona registrada")
                Dim Tratamiento = InputBox("Ingrese el nombre del tratamiento hecho")
                Dim PrecioT = InputBox("Ingrese el precio del tratamiento (solo numeros)")
                sql = "select curdate()"
                Call ejecutar(sql)
                rs.Read()
                FechaA = rs(0)
                sql = "insert into Tratamiento values('', '" & NombreC & "', '" & Tratamiento & "', '" & PrecioT & "', '" & Format(FechaA, "yyyy/MM/dd") & "')"
                Call ejecutar(sql)
                MsgBox("Tratamiento ingresado correctamente", MsgBoxStyle.OkOnly, "Tratamiento")

            End If

        Else
            Dim Tratamiento = InputBox("Ingrese el nombre del tratamiento hecho")
            Dim PrecioT = InputBox("Ingrese el precio del tratamiento (solo numeros)")
            sql = "select curdate()"
            Call ejecutar(sql)
            rs.Read()
            FechaA = rs(0)
            sql = "insert into Tratamiento values('', '" & NombreC & "', '" & Tratamiento & "', '" & PrecioT & "', '" & Format(FechaA, "yyyy/MM/dd") & "')"
            Call ejecutar(sql)
            MsgBox("Tratamiento ingresado correctamente", MsgBoxStyle.OkOnly, "Tratamiento")

        End If


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub

    Private Sub btnClientas_Click(sender As Object, e As EventArgs) Handles btnClientas.Click
        Clienta = InputBox("Ingrese el nombre de la clienta")
        sql = "select count(*) from Tratamiento where nombre = '" & Clienta & "'"
        Call ejecutar(sql)
        rs.Read()

        If rs(0) = 0 Then
            MsgBox("El usuario ingresado no existe", MsgBoxStyle.Critical, "Usuario inexistente")

        Else
            Me.Hide()
            frmClientas.Show()

        End If
    End Sub
End Class
