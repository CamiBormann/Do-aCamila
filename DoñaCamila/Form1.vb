Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form1
    Dim RutaArchivo As String = ""
    Public AppExcel As Excel.Application
    Public Libro As Excel.Workbook
    Public Hoja As Excel.Worksheet

    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click
        Dim Ventana As New OpenFileDialog
        Ventana.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        If Ventana.ShowDialog() = DialogResult.OK Then
            RutaArchivo = Ventana.FileName
            CargaMasiva()
        End If
        If CmbProductos.Items.Count > 0 Then
            BtnCargar.Enabled = False
        End If
    End Sub
    Private Sub CmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbProductos.SelectedIndexChanged
        AppExcel = New Excel.Application
        Libro = AppExcel.Workbooks.Open(RutaArchivo)
        Hoja = Libro.ActiveSheet
        Dim index As Integer = CmbProductos.SelectedIndex
        Dim Producto As String = Hoja.Range("B" & index + 2).Value
        Dim Precio As String = Hoja.Range("F" & index + 2).Value
        Dim Stock As String = Hoja.Range("G" & index + 2).Value
        AppExcel.Quit()
        Libro = Nothing
        Hoja = Nothing
        TxtDescripcion.Text = Producto
        TxtPrecio.Text = Precio
        TxtStock.Text = Stock
    End Sub

    Public Sub CargaMasiva()
        AppExcel = New Excel.Application
        Try
            Libro = AppExcel.Workbooks.Open(RutaArchivo)
            Hoja = Libro.ActiveSheet
            Dim Celdas As Integer = Hoja.UsedRange.Rows.Count

            If Celdas < 2 Then
                MessageBox.Show("El archivo seleccionado no contiene datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            For X = 1 To Celdas - 1
                CmbProductos.Items.Add(X)
            Next
            AppExcel.Quit()
            Libro = Nothing
            Hoja = Nothing
        Catch ex As Exception
            AppExcel.Quit()
            Libro = Nothing
            Hoja = Nothing
            MsgBox("El archivo seleccionado, no es compatible")
            BtnCargar.Enabled = True
        End Try
    End Sub

End Class
