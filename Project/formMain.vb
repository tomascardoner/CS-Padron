Imports System.Text.RegularExpressions

Public Class formMain
    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.tbladpMesa.Fill(Me.datsetPadron.Mesa)
        Me.Text = My.Application.Info.Title
        lblCopyright.Text = My.Application.Info.Copyright

        bngsrcResult.Sort = "Apellido, Nombre, DocumentoNumero"
        bngsrcDetail.Sort = "Apellido, Nombre, DocumentoNumero"

        InitializeControls()
    End Sub

    Private Sub InitializeControls()
        radbtnSearchDocumento.Checked = True
        radbtnSearchDocumento.Focus()
        txtboxSearchDocumentoNumero.Text = ""

        cboboxSearchNombre.SelectedIndex = 1
        txtboxSearchNombre.Text = ""

        cboboxSearchSexo.SelectedIndex = 0

        ShowPanel(1)
    End Sub

    Private Sub ShowPanel(ByVal PanelNumber As Byte)
        pnlSearch.Visible = (PanelNumber = 1)
        pnlGrid.Visible = (PanelNumber = 2)
        pnlDetail.Visible = (PanelNumber = 3)

        Select Case PanelNumber
            Case 1  'SEARCH
                If radbtnSearchDocumento.Checked Then
                    txtboxSearchDocumentoNumero.Focus()
                End If
                Me.AcceptButton = btnSearchSearch
                Me.CancelButton = Nothing

            Case 2  'RESULTS
                pnlSearch.Visible = False
                pnlGrid.Visible = True
                pnlDetail.Visible = False

                btnResultDetail.Focus()
                Me.AcceptButton = btnResultDetail
                Me.CancelButton = btnResultBack

            Case 3  'DETAILS
                btnDetailNewSearch.Focus()
                Me.AcceptButton = btnDetailNewSearch
                Me.CancelButton = btnDetailBack
        End Select
    End Sub

    Private Sub radbtnSearch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbtnSearchDocumento.CheckedChanged, radbtnSearchApellidoNombre.CheckedChanged
        lblSearchDocumentoNumero.Enabled = radbtnSearchDocumento.Checked
        txtboxSearchDocumentoNumero.Enabled = radbtnSearchDocumento.Checked

        lblSearchNombre.Enabled = radbtnSearchApellidoNombre.Checked
        cboboxSearchNombre.Enabled = radbtnSearchApellidoNombre.Checked
        txtboxSearchNombre.Enabled = radbtnSearchApellidoNombre.Checked

        lblSearchSexo.Enabled = radbtnSearchApellidoNombre.Checked
        cboboxSearchSexo.Enabled = radbtnSearchApellidoNombre.Checked
    End Sub

    Private Sub txtboxSearchDocumentoNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtboxSearchDocumentoNumero.KeyPress
        If Not Regex.IsMatch(e.KeyChar, "[0-9\b]") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtboxSearchDocumentoNumero_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxSearchDocumentoNumero.LostFocus
        txtboxSearchDocumentoNumero.Text = txtboxSearchDocumentoNumero.Text.Trim
        txtboxSearchDocumentoNumero.Text = CS_ValueTranslation.FromStringToOnlyDigitsString(txtboxSearchDocumentoNumero.Text)
    End Sub

    Private Sub txtboxSearchNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtboxSearchNombre.KeyPress
        If Regex.IsMatch(e.KeyChar, "\*") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtboxSearchNombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxSearchNombre.LostFocus
        txtboxSearchNombre.Text = txtboxSearchNombre.Text.Trim
        txtboxSearchNombre.Text = Regex.Replace(txtboxSearchNombre.Text, "[^A-ZÑ ']", String.Empty)
    End Sub

    Private Sub Search_ButtonSearchClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchSearch.Click
        btnSearchSearch.Focus()

        If radbtnSearchDocumento.Checked Then
            'BUSQUEDA POR DOCUMENTO

            If txtboxSearchDocumentoNumero.Text.Length < 5 Then
                MsgBox("El Número de Documento debe tener al menos 5 dígitos.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                txtboxSearchDocumentoNumero.Focus()
                Exit Sub
            End If
            If Not IsNumeric(txtboxSearchDocumentoNumero.Text) Then
                MsgBox("El Número de Documento no tiene formato numérico.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                txtboxSearchDocumentoNumero.Focus()
                Exit Sub
            End If

            Try
                bngsrcResult.Filter = System.String.Format("DocumentoNumero = {0}", txtboxSearchDocumentoNumero.Text)
            Catch ex As Exception
                MsgBox("Ha ocurrido un Error al intentar aplicar el filtro especificado a la Base de Datos." & vbCr & vbCr & ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
            End Try

        ElseIf radbtnSearchApellidoNombre.Checked Then
            'BUSQUEDA POR NOMBRE Y SEXO

            If txtboxSearchNombre.Text.Length < 2 Then
                MsgBox("Debe especificar al menos 2 caracteres para el Apellido y Nombre", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                txtboxSearchNombre.Focus()
                Exit Sub
            End If

            Try

                'NOMBRE
                If txtboxSearchNombre.TextLength > 0 Then
                    Select Case cboboxSearchNombre.SelectedIndex
                        Case 0  'SEA IGUAL
                            bngsrcResult.Filter = System.String.Format("Apellido + ' ' + Nombre = '{0}'", CS_ValueTranslation.FromStringToPreventSQLInjection(txtboxSearchNombre.Text))
                        Case 1  'COMIENCE
                            bngsrcResult.Filter = System.String.Format("Apellido + ' ' + Nombre LIKE '{0}*'", CS_ValueTranslation.FromStringToPreventSQLInjection(txtboxSearchNombre.Text))
                        Case 2  'CONTENGA
                            bngsrcResult.Filter = System.String.Format("Apellido + ' ' + Nombre LIKE '*{0}*'", CS_ValueTranslation.FromStringToPreventSQLInjection(txtboxSearchNombre.Text))
                    End Select
                End If

                'SEXO
                Select Case cboboxSearchSexo.SelectedIndex
                    Case 0  'IGNORAR
                    Case 1  'FEMENINO
                        bngsrcResult.Filter = bngsrcResult.Filter & " AND Sexo = 'F'"
                    Case 2  'MASCULINO
                        bngsrcResult.Filter = bngsrcResult.Filter & " AND Sexo = 'M'"
                End Select
            Catch ex As Exception
                MsgBox("Ha ocurrido un Error al intentar aplicar el filtro especificado a la Base de Datos." & vbCr & vbCr & ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
            End Try
        Else
            MsgBox("Debe sepecificar el Tipo de Búsqueda.", MsgBoxStyle.Information, My.Application.Info.Title)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Me.tbladpResult.Fill(Me.datsetPadron.Padron)
        datgrdResult.Columns("IDPersona").Visible = False

        Me.Cursor = Cursors.Arrow

        Select Case Me.datgrdResult.RowCount
            Case Is <= 0    'NO HAY COINCIDENCIAS
                MsgBox("No se encontró ninguna coincidencia.", MsgBoxStyle.Information, My.Application.Info.Title)
                If radbtnSearchDocumento.Checked Then
                    txtboxSearchDocumentoNumero.Focus()
                End If
                If radbtnSearchApellidoNombre.Checked Then
                    txtboxSearchNombre.Focus()
                End If

            Case 1      'HAY UNA SOLA COINCIDENCIA, PASO DIRECTO A LOS DETALLES
                bngsrcDetail.Filter = bngsrcResult.Filter
                ShowMesaData()
                ShowPanel(3)

            Case Else   'HAY MAS DE UNA COINCIDENCIA, MUESTRO LA GRILLA
                lblResultCount.Text = String.Format("{0} Personas coincidentes.", Me.datgrdResult.RowCount)
                ShowPanel(2)
        End Select
    End Sub

    Private Sub btnResultBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResultBack.Click
        ShowPanel(1)
    End Sub

    Private Sub brnResultDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResultDetail.Click
        If datgrdResult.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar al menos una Persona para ver los detalles.", MsgBoxStyle.Information, My.Application.Info.Title)
            datgrdResult.Focus()
        Else
            Dim SelectedDataGridViewRow As DataGridViewRow
            Dim FilterText As String = ""

            For Each SelectedDataGridViewRow In datgrdResult.SelectedRows
                FilterText = FilterText & IIf(FilterText = "", "", ", ") & SelectedDataGridViewRow.Cells("IDPersona").Value
            Next SelectedDataGridViewRow

            Try
                bngsrcDetail.Filter = "IDPersona IN(" & FilterText & ")"
            Catch ex As Exception
                MsgBox("Ha ocurrido un Error al intentar aplicar el filtro especificado a la Base de Datos." & vbCr & vbCr & ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
            End Try

            ShowMesaData()
            ShowPanel(3)
        End If
    End Sub

    Private Sub ShowMesaData()
        If CircuitoTextBox.Text <> "" Then
            bngsrcMesa.Filter = "Circuito = '" & CircuitoTextBox.Text & "' AND MesaDesde <= " & MesaTextBox.Text & " AND MesaHasta >= " & MesaTextBox.Text
        End If
    End Sub

    Private Sub bngsrcDetail_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bngsrcDetail.PositionChanged
        ShowMesaData()
    End Sub

    Private Sub btnNewSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetailNewSearch.Click
        InitializeControls()
    End Sub

    Private Sub btnDetailBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetailBack.Click
        If datgrdResult.RowCount = 1 Then
            ShowPanel(1)
        Else
            ShowPanel(2)
        End If
    End Sub

    Private Sub BindingNavigatorPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BindingNavigatorPrint.Click
        prnfrmMain.DocumentName = "Detalles de " & NombreTextBox.Text
        prnfrmMain.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
    End Sub
End Class
